using assembler.parsers;
using assembler.parsers.instructions;
using assembler.parsers.labels;
using assembler.parsers.variables;
using assembler.preprocessor;
using assembler.segments;
using DynamicExpresso;
using ismap;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.RegularExpressions;

namespace assembler;
public static class Program
{

   

    public class CompiledInstruction
    {
        public PipelineInstruction PipelineInstruction { get;}
        public Instruction Instruction { get;}
        public UInt16? Data { get; set; } = null;

        public CompiledInstruction(PipelineInstruction pipelineInstruction,
                                   Instruction instruction)
        {
            PipelineInstruction = pipelineInstruction;
            Instruction = instruction;
        }
    }

    public class AssemblerContext
    {
        public Preprocessor Preprocessor { get; set; }
        public SegmentParser SegmentParser { get; set; }
        public VariableParser VariableParser { get; set; }
        public InstructionParser InstructionParser { get; set; }
        public LabelParser LabelParser { get; set; }

        //public List<FileContext> FileContexts { get; private set; }
        public Dictionary<string, VariableAccessor> VariableAccessors { get; private set; } = new Dictionary<string, VariableAccessor>();
        public Dictionary<string, Variable> Variables { get; private set; } = new Dictionary<string, Variable>();
        public List<List<CodeElement>> CodeElements { get; private set; } = new List<List<CodeElement>>();
        public Dictionary<Int64, Label> Labels { get; private set; } = new Dictionary<Int64, Label>();
        public List<CompiledInstruction> CompiledInstructions { get; private set; } = new List<CompiledInstruction>();

        public AssemblerContext()
        {
            Preprocessor = new Preprocessor();
            SegmentParser = new SegmentParser();
            VariableParser = new VariableParser();
            InstructionParser = new InstructionParser();
            LabelParser = new LabelParser();
        }
        public bool Foo(string entryFile)
        {
            if (!BuildDependencies(entryFile))
            {
                return false;
            }

            BuildLabelIndex();

            if (!BuildPipelineInstructions())
            {
                return false;
            }

            BuildInterpreterVariables();

            BuildCompiledInstructions();

            return true;
        }

        public bool BuildDependencies(string entryFile)
        {
            using var fs = new FileStream(entryFile, FileMode.Open, FileAccess.Read);

            var includes = Preprocessor.ExtractIncludes(fs);

            if (BuildFile(entryFile))
            {
                if (includes.Any())
                {
                    foreach (var file in includes)
                    {
                        BuildDependencies(file);
                    }
                }

                return true;
            }
            return false;
        }

        private bool BuildFile(string entryFile)
        {
            var source = File.ReadAllText(entryFile);

            var textElements = RunPreprocessor(source);
            var segments = RunSegmentParser(textElements);

            if (!RunVariableParser(segments))
            {
                return false;
            }

            if (!RunCodeElementsParser(segments))
            {
                return false;
            }

            return true;
        }

        private List<TextElement> RunPreprocessor(string source)
        {
            var preResult = Preprocessor.Parse(source);
            if (preResult.Success)
            {
                //PreprocessorOutput = preResult.ToTransformedString();
                //TextElements = preResult.TextElements;
                //return true;
                
            }
            return preResult.TextElements;
        }

        private List<Segment> RunSegmentParser(List<TextElement> textElements)
        {
            var segmentResult = SegmentParser.Parse(textElements);
            if (segmentResult.Success)
            {
            //    Segments = segmentResult.Segments;
            //    return true;
            }
            return segmentResult.Segments;
        }

        private bool RunVariableParser(List<Segment> segments)
        {
            var dataElements = segments.Where(s => s.Name == ".data").SelectMany(s => s.Elements);
            var bssElements = segments.Where(s => s.Name == ".bss").SelectMany(s => s.Elements);

            var elements = new List<TextElement>();

            if (dataElements.Any())
            {
                elements.AddRange(dataElements);
            }

            if (bssElements.Any())
            {
                elements.AddRange(bssElements);
            }

            if (elements.Any())
            {
                foreach (var element in elements)
                {
                    var varResult = VariableParser.Parse(element);
                    if (varResult.Success)
                    {
                        if (!Variables.ContainsKey(varResult.Variable.name))
                        {
                            Variables.Add(varResult.Variable.name, varResult.Variable);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool RunCodeElementsParser(List<Segment> segments)
        {
            int instructionIndex = 0;
            var fileCodeElements = new List<CodeElement>();
            foreach (var textSegment in segments.Where(s => s.Name == ".text"))
            {
                foreach (var element in textSegment.Elements)
                {
                    if (!string.IsNullOrWhiteSpace(element.Text))
                    {
                        {
                            var labelResult = LabelParser.Parse(element);
                            if (labelResult.Success)
                            {
                                labelResult.Label.Index = instructionIndex;
                                labelResult.Label.Width = 0;
                                fileCodeElements.Add(labelResult.Label);
                                continue;
                            }
                        }

                        {
                            var instructionResult = InstructionParser.Parse(element);
                            if (instructionResult.Success)
                            {
                                instructionResult.Instruction.Index = instructionIndex++;
                                instructionResult.Instruction.Width = 1;
                                fileCodeElements.Add(instructionResult.Instruction);
                                continue;
                            }
                        }
                        return false;
                    }
                }
            }
            CodeElements.Add(fileCodeElements);
            return CodeElements.Any();
        }


        private void BuildLabelIndex()
        {
            Int64 index = 0;

            foreach (var codeElement in CodeElements.SelectMany(cl=> cl))
            {
                if (codeElement.ElementType == CodeElementType.INSTRUCTION)
                {
                    index++;
                }
                else if (codeElement.ElementType == CodeElementType.LABEL)
                {
                    Labels.Add(index, (Label)codeElement);
                }
            }
        }

        private bool BuildPipelineInstructions()
        {
            foreach (var codeElement in CodeElements.SelectMany(cl => cl))
            {
                if (codeElement.ElementType == CodeElementType.INSTRUCTION)
                {
                    var instruction = (Instruction)codeElement;
                    var template = BuildInstructionTemplate(instruction);
                    PipelineInstruction? pipelineInstruction;
                    if (CPU16.InstructionSet.Instructions.TryGetValue(template, out pipelineInstruction))
                    {
                        CompiledInstructions.Add(new CompiledInstruction(pipelineInstruction, instruction));
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return CompiledInstructions.Any();
        }

        private void BuildInterpreterVariables()
        {
            Int64 dataOffset = GetDataOffset(CompiledInstructions.Count - 1) + 1;
            foreach (var variable in Variables)
            {
                var accessor = new VariableAccessor();
                accessor.Name = @$"@{variable.Key}";
                accessor.Offset = dataOffset;
                dataOffset += variable.Value.data.Length;
                VariableAccessors.Add(accessor.Name, accessor);
            }

            foreach (var label in Labels)
            {
                Int64 instructionOffset = GetDataOffset(label.Key);
                var accessor = new VariableAccessor();
                accessor.Name = @$"@{label.Value.Name}";
                accessor.Offset = instructionOffset;
                VariableAccessors.Add(accessor.Name, accessor);
            }
        }

        private void BuildCompiledInstructions()
        {
            var interpreter = new Interpreter();
            foreach (var variable in VariableAccessors)
            {
                interpreter.SetVariable(variable.Value.Name, variable.Value);
            }

            foreach (var compiledInstruction in CompiledInstructions)
            {
                if (compiledInstruction.Instruction.ElementType == CodeElementType.INSTRUCTION)
                {
                    foreach (var op in compiledInstruction.Instruction.Operands)
                    {
                        switch (op.OperandType)
                        {
                            case OperandType.EXPRESSION:
                            case OperandType.CONST:
                            case OperandType.ADDRESS:
                                {
                                    compiledInstruction.Data = interpreter.Eval<UInt16>(op.Expression);
                                }
                                break;
                        }
                    }
                }
            }
        }


        private string BuildInstructionTemplate(Instruction instruction)
        {
            var template = instruction.Mnemonic.Trim().ToUpper();

            foreach (var op in instruction.Operands)
            {
                switch (op.OperandType)
                {
                    case OperandType.EXPRESSION:
                    case OperandType.CONST:
                    case OperandType.ADDRESS:
                        template += $"_$";
                        break;
                    case OperandType.REGISTER:
                        template += $"_{op.Text}";
                        break;
                }
            }

            return template;
        }

        private Int64 GetDataOffset(Int64 instructionIndex)
        {
            Int64 offset = 0;
            for (int i = 0; i < instructionIndex; i++)
            {
                offset += CompiledInstructions[i].PipelineInstruction.MemoryDepth;
            }
            return offset;
        }
    }

    public class VariableAccessor
    {
        public string Name { get; set; } = string.Empty;
        public Int64 Offset { get; set; } = 0;

        public Int64 this[Int64 index]
        {
            get
            {
                return index + Offset;
            }
        }
    }




    public static int Main(string[] args)
    {


        //    var fileMain = @"
        //    ;#include ""clear-registers.asm""
        //    ;#define clear-reg aba

        //    segment .bss
        //        U32 var1 0x00000000

        //    segment .text

        //    ldi txl, [_loop] >>  0
        //    ldi txh, [_loop] >> 16
        //    mov aba, atx        

        //    ldi txl, 0
        //    ldi txh, 0
        //    mov ara, atx

        //    ldi txl, [var1] >> 0
        //    ldi txh, [var1] >> 16
        //    mov abb, atx

        //    ldi a, 0
        //    ldi b, 1
        //_loop:
        //    inc ara
        //    nop
        //    jmp aba
        //    ";
        var fileMain = @"
            segment .text
            nop
            nop
            nop
            nop
            nop
            nopi
            nopi
            nop
            ldi a, 255
            ";
        File.Delete("busy.asm");
        File.WriteAllText("busy.asm", fileMain);

        var asmContext = new AssemblerContext();
        




        if (asmContext.Foo("busy.asm"))
        {
            int index = 0;
            foreach(var ci in asmContext.CompiledInstructions)
            {
                Console.WriteLine($@"{index++:0000} I: {ci.Instruction}");
                if(ci.Data != null)
                {
                    Console.WriteLine($@"{index++:0000} D: {ci.Data}");
                }
            }
            foreach (var variable in asmContext.Variables)
            {
                foreach (var element in variable.Value.data)
                {
                    Console.WriteLine($@"{index++:0000} D: 0x{element:X4}");
                }
            }


            foreach (var ci in asmContext.CompiledInstructions)
            {
                Console.WriteLine($@"0x{ci.PipelineInstruction.InstructionIndex:X4}");
                if (ci.Data != null)
                {
                    Console.WriteLine($@"0x{ci.Data:X4}");
                }
            }

            foreach(var variable in asmContext.Variables)
            {
                foreach(var element in variable.Value.data)
                {
                    Console.WriteLine($@"0x{element:X4}");
                }
            }
        }




        return 0;
    }




}


