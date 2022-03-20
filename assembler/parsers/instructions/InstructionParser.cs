using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assembler.parsers.instructions
{
    public class InstructionParser : Parser
    {
        public override InstructionParserResult Parse(TextElement textElement)
        {
            var instruction = new Instruction();
            if (!TryReadInstructionMnemonic(textElement.Text, ref instruction))
            {
                return new InstructionParserResult(false, instruction);
            }

            if (!TryReadInstructionOperands(textElement.Text, ref instruction))
            {
                return new InstructionParserResult(false, instruction);
            }

            return new InstructionParserResult(true, instruction);
        }


     
        protected virtual bool TryReadInstructionMnemonic(string value, ref Instruction instruction)
        {
            var elements = SplitQuotedInstructionString(value);
            if (elements.Length > 0)
            {
                var stringMnemonic = elements[0].ToUpper().Trim();
             
                if (!string.IsNullOrWhiteSpace(stringMnemonic))
                {
                    instruction.Mnemonic = stringMnemonic;
                    return true;
                }
            }
            instruction.Mnemonic = string.Empty;
            return true;
        }


        protected virtual bool TryReadInstructionOperands(string value, ref Instruction instruction)
        {
            var elements = SplitQuotedInstructionString(value);
            if (elements.Length > 1)
            {
                var operands = new List<Operand>();
                foreach (var operandValue in elements.Skip(1))
                {
                    Operand operand;
                    if (TryParseOperand(operandValue, out operand))
                    {
                        operands.Add(operand);
                    }
                }
                instruction.Operands = operands.ToArray();
                if (instruction.Operands.Length == elements.Length - 1)
                {
                    return true;
                }
            }
            
            return elements.Length > 0;
        }
        protected virtual bool TryParseOperand(string value, out Operand operand)
        {
            operand = new Operand();

            OperandType operandType;
            if (TryParseOperandType(value, out operandType))
            {
                operand.OperandType = operandType;

                switch (operandType)
                {
                    case OperandType.CONST:
                        if (TryParseOperandConst(value, ref operand))
                        {
                            return true;
                        }
                        break;
                    case OperandType.REGISTER:
                        if (TryParseOperandRegister(value, ref operand))
                        {
                            return true;
                        }
                        break;
                    case OperandType.ADDRESS:
                        if (TryParseOperandAddress(value, ref operand))
                        {
                            return true;
                        }
                        break;
                    case OperandType.EXPRESSION:
                        if (TryParseOperandExpression(value, ref operand))
                        {
                            return true;
                        }
                        break;
                }
            }

            operand.Text = value;
            operand.OperandType = OperandType.INVALID;
            return false;
        }
        protected virtual bool TryParseOperandType(string value, out OperandType operandType)
        {
            //^\s{0,}(?<value>'([^']|\\[\\'\w])')(\s+$|$)   const '\0'
            Match match = Regex.Match(value, @"^\s{0,}(?<value>'([^']|\\[\\'\w])'|0b[01]+|0x[a-fA-F0-9]+|[0-9]+)(\s+$|$)");
            if (match.Success)
            {
                operandType = OperandType.CONST;
                return true;
            }

            //^\s{0,}(?<value>([a-zA-Z]+))(\s+$|$)          register a ba ara aba...
            match = Regex.Match(value, @"^\s{0,}(?<value>([a-zA-Z]+))(\s+$|$)");
            if (match.Success)
            {
                operandType = OperandType.REGISTER;
                return true;
            }

            //^\s{0,}(?<value>\[[a-zA-Z]+\])(\s+$|$)        address [var] [msg]...
            match = Regex.Match(value, @"^\s{0,}(?<value>\[.*\].*)(\s+$|$)");
            if (match.Success)
            {
                operandType = OperandType.ADDRESS;
                return true;
            }

            //^\s{0,}(?<value>\(.+\))(\s+$|$)               expression ([ara] + 1)
            match = Regex.Match(value, @"^\s{0,}(?<value>\(.+\))(\s+$|$)");
            if (match.Success)
            {
                operandType = OperandType.EXPRESSION;
                return true;
            }

            operandType = OperandType.INVALID;
            return false;
        }


        protected virtual bool TryParseOperandConst(string value, ref Operand operand)
        {
            operand.Text = value.Trim();
            operand.OperandType = OperandType.CONST;
            operand.Expression = $@"({value.Trim()})";
            return true;
        }
        protected virtual bool TryParseOperandRegister(string value, ref Operand operand)
        {
            operand.OperandType = OperandType.REGISTER;
            operand.Text = value.ToUpper().Trim();
            return true;
        }
        protected virtual bool TryParseOperandAddress(string value, ref Operand operand)
        {
            operand.OperandType = OperandType.ADDRESS;
            operand.Text = value.Trim();
            var expression = value.Trim();
            if (TransformAddressToExpression(value, ref expression))
            {
                operand.Expression = expression;
                return true;
            }
            return true;
        }
        protected virtual bool TryParseOperandExpression(string value, ref Operand operand)
        {
            operand.Text = value.Trim();

            var regex = @"((?<!\w)\[[a-zA-Z]{1,}[^\]]+\])";
            var match = Regex.Match(value, regex);
            
            while (match.Success)
            {
                string addrExpression = string.Empty; 
                if(TransformAddressToExpression(value.Substring(match.Index, match.Length), ref addrExpression)){
                    value = value.Remove(match.Index, match.Length);
                    value = value.Insert(match.Index, addrExpression);
                    match = Regex.Match(value, regex);
                }
              
            }
            operand.OperandType = OperandType.EXPRESSION;            
            operand.Expression = value.Trim();
            return true;
        }

        protected virtual bool TransformAddressToExpression(string value, ref string expression)
        {
            //[msg] -> @msg[+0]
            //[msg + 1] -> @msg[+1]
            //[msg + len] >> 16 -> @msg[+len] >> 16
            var match = Regex.Match(value, @"\[(?<name>[\w_]+)(\s+(?<value>.*)|)\](?<expr>.*)");
            if (match.Success)
            {
                var variableName = match.Groups["name"].Captures.FirstOrDefault()?.Value;
                var index = match.Groups["value"].Captures.FirstOrDefault()?.Value;
                var expressionBody = match.Groups["expr"].Captures.FirstOrDefault()?.Value;

                expression = @$"(@{variableName}[{index ?? "+0"}] {expressionBody??""})";
                return true;
            }

            return false;
        }
        protected virtual string[] SplitQuotedInstructionString(string value)
        {
            bool quoted = false;

            var chrBuffer = new List<char>();
            var stringBuffer = new List<string>();

            var backtrack = (int i) => i > 0 ? value[i - 1] : '\0';
            int i = 0;

            bool mnemonic = false;
            for (; i < value.Length; ++i)
            {
                char chr = value[i];
                if (!mnemonic && !char.IsWhiteSpace(chr))
                {
                    mnemonic = true;
                }
                if (mnemonic && char.IsWhiteSpace(chr))
                {
                    chrBuffer.Add(chr);
                    ++i;
                    break;
                }
                chrBuffer.Add(chr);
            }
            stringBuffer.Add(new string(chrBuffer.ToArray()));
            chrBuffer.Clear();

            for (; i < value.Length; ++i)
            {

                char chr = value[i];
                if (!quoted && chr == ',')
                {
                    stringBuffer.Add(new string(chrBuffer.ToArray()));
                    chrBuffer.Clear();
                }
                else if (!quoted && chr == '\'' && backtrack(i) != '\\')
                {
                    stringBuffer.Add(new string(chrBuffer.ToArray()));
                    chrBuffer.Clear();
                    chrBuffer.Add(chr);
                    quoted = true;
                }
                else if (quoted && chr == '\'' && backtrack(i) != '\\')
                {
                    chrBuffer.Add(chr);
                    stringBuffer.Add(new string(chrBuffer.ToArray()));
                    chrBuffer.Clear();
                    quoted = false;
                }
                else
                {
                    chrBuffer.Add(chr);
                }

            }
            stringBuffer.Add(new string(chrBuffer.ToArray()));

            return stringBuffer.Select(s => s.Trim()).Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

        }


        

    }
}
