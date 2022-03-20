using ismap;
using System;

namespace micro;


public static class Program
{
    
    private static PipelineInstruction? MatchInstructionOpcode(InstructionSet instructionSet, string instructionString)
    {
        var elements = instructionString
            .Split(new char[] { ',', ' ', '\t' },
                   StringSplitOptions.RemoveEmptyEntries |
                   StringSplitOptions.TrimEntries)
            .Select(e => e.ToUpper())
            .ToArray();


        var template = string.Join('_', elements);
        PipelineInstruction? instruction = null;
        if(!instructionSet.Instructions.TryGetValue(template, out instruction))
        {

        }
        return instruction;
    }
    public static int Main(string[] args)
    {

        Console.Clear();

        string insLdi = "ldi a, $";
        string insMovReg = "mov a, b";
        string insLd = "ld a, [ara]";
        string insStr = "ld a, [ara]";
        string insAdd = "add a, a, b";
        string insJmp = "jmp ara";
        string insJnz = "jnz";

        //add [ara], a, b

        MatchInstructionOpcode(CPU16.InstructionSet, insLdi);
        MatchInstructionOpcode(CPU16.InstructionSet, insMovReg);
        MatchInstructionOpcode(CPU16.InstructionSet, insLd);
        MatchInstructionOpcode(CPU16.InstructionSet, insStr);
        MatchInstructionOpcode(CPU16.InstructionSet, insAdd);
        MatchInstructionOpcode(CPU16.InstructionSet, insJmp);
        MatchInstructionOpcode(CPU16.InstructionSet, insJnz);


        //byte s0b0 = (byte)(((UInt64)nop.Stage0 & 0x0000FF) >> 0);
        //byte s0b1 = (byte)(((UInt64)nop.Stage0 & 0x00FF00) >> 8);
        //byte s0b2 = (byte)(((UInt64)nop.Stage0 & 0xFF0000) >> 16);

        //byte s1b0 = (byte)(((UInt64)nop.Stage1 & 0x0000FF) >> 0);
        //byte s1b1 = (byte)(((UInt64)nop.Stage1 & 0x00FF00) >> 8);
        //byte s1b2 = (byte)(((UInt64)nop.Stage1 & 0xFF0000) >> 16);

        System.IO.File.Delete("instructionset.txt");
        System.IO.File.Delete("pipeline-stage0.hex");
        System.IO.File.Delete("pipeline-stage1.hex");
        System.IO.File.AppendAllText("pipeline-stage0.hex", "v2.0 raw\n");
        System.IO.File.AppendAllText("pipeline-stage1.hex", "v2.0 raw\n");
        foreach (var instructionGroup in CPU16.InstructionSet)
        {

            System.IO.File.AppendAllText("instructionset.txt",
                                         instructionGroup.Name + "\n");
            System.IO.File.AppendAllText("pipeline-stage0.hex",
                                         $"#{instructionGroup.Name}\n");
            System.IO.File.AppendAllText("pipeline-stage1.hex",
                                         $"#{instructionGroup.Name}\n");

            foreach (var instruction in instructionGroup)
            {
                System.IO.File.AppendAllText("instructionset.txt",
                                            $" {instruction.Name}:\t0x{instruction.InstructionIndex:X4}\n");
                System.IO.File.AppendAllText("pipeline-stage0.hex",
                                            $"#  {instruction.Name}:\t{instruction.InstructionIndex}\t0x{instruction.InstructionIndex:X4}\n");
                System.IO.File.AppendAllText("pipeline-stage1.hex",
                                            $"#  {instruction.Name}:\t{instruction.InstructionIndex}\t0x{instruction.InstructionIndex:X4}\n");

                System.IO.File.AppendAllText("pipeline-stage0.hex", 
                                            $"{((UInt64)instruction.Stage0):X8}\n");
                System.IO.File.AppendAllText("pipeline-stage1.hex",
                                            $"{((UInt64)instruction.Stage1):X8}\n");
            }
        }

        Console.WriteLine(CPU16.InstructionSet);
        return 0;
    }

    //public static BitFlagsAttribute? GetBitFlags<T>() where T : Enum
    //{
    //    return (BitFlagsAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(BitFlagsAttribute));
    //}
}




/*


var instructionSet = new InstructionSet();
//ALU OPERATIONS



//NO OPERATION
instructionSet.Add(new InstructionGroup("NOP")
{
    {
        "NOP",
             PS0.NONE,
             PS1.NONE
            }
});

        //GPR OPERATIONS
        instructionSet.Add(new InstructionGroup("MOV_A")
{
    {
        "MOV_A_A",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_A},
            {
        "MOV_A_B",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_B},
            {
        "MOV_A_C",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_C},
            {
        "MOV_A_D",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_D},
            {
        "MOV_A_I",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_I},
            {
        "MOV_A_TXL",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_TXL},
            {
        "MOV_A_TXH",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_TXH},
            {
        "MOV_A_BA",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_BA},
            {
        "MOV_A_BB",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_BB},
            {
        "MOV_A_BC",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_BC},
            {
        "MOV_A_BD",
             PS0.NONE,
             PS1.R_LD_A | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_B")
{
    {
        "MOV_B_A",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_A},
            {
        "MOV_B_B",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_B},
            {
        "MOV_B_C",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_C},
            {
        "MOV_B_D",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_D},
            {
        "MOV_B_I",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_I},
            {
        "MOV_B_TXL",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_TXL},
            {
        "MOV_B_TXH",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_TXH},
            {
        "MOV_B_BA",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_BA},
            {
        "MOV_B_BB",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_BB},
            {
        "MOV_B_BC",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_BC},
            {
        "MOV_B_BD",
             PS0.NONE,
             PS1.R_LD_B | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_C")
{
    {
        "MOV_C_A",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_A},
            {
        "MOV_C_B",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_B},
            {
        "MOV_C_C",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_C},
            {
        "MOV_C_D",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_D},
            {
        "MOV_C_I",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_I},
            {
        "MOV_C_TXL",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_TXL},
            {
        "MOV_C_TXH",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_TXH},
            {
        "MOV_C_BA",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_BA},
            {
        "MOV_C_BB",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_BB},
            {
        "MOV_C_BC",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_BC},
            {
        "MOV_C_BD",
             PS0.NONE,
             PS1.R_LD_C | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_D")
{
    {
        "MOV_D_A",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_A},
            {
        "MOV_D_B",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_B},
            {
        "MOV_D_C",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_C},
            {
        "MOV_D_D",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_D},
            {
        "MOV_D_I",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_I},
            {
        "MOV_D_TXL",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_TXL},
            {
        "MOV_D_TXH",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_TXH},
            {
        "MOV_D_BA",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_BA},
            {
        "MOV_D_BB",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_BB},
            {
        "MOV_D_BC",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_BC},
            {
        "MOV_D_BD",
             PS0.NONE,
             PS1.R_LD_D | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_O")
{
    {
        "MOV_O_A",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_A},
            {
        "MOV_O_B",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_B},
            {
        "MOV_O_C",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_C},
            {
        "MOV_O_D",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_D},
            {
        "MOV_O_I",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_I},
            {
        "MOV_O_TXL",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_TXL},
            {
        "MOV_O_TXH",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_TXH},
            {
        "MOV_O_BA",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_BA},
            {
        "MOV_O_BB",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_BB},
            {
        "MOV_O_BC",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_BC},
            {
        "MOV_O_BD",
             PS0.NONE,
             PS1.R_LD_O | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_BA")
{
    {
        "MOV_BA_A",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_A},
            {
        "MOV_BA_B",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_B},
            {
        "MOV_BA_C",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_C},
            {
        "MOV_BA_D",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_D},
            {
        "MOV_BA_I",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_I},
            {
        "MOV_BA_TXL",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_TXL},
            {
        "MOV_BA_TXH",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_TXH},
            {
        "MOV_BA_BA",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_BA},
            {
        "MOV_BA_BB",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_BB},
            {
        "MOV_BA_BC",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_BC},
            {
        "MOV_BA_BD",
             PS0.NONE,
             PS1.R_LD_BA | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_BB")
{
    {
        "MOV_BB_A",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_A},
            {
        "MOV_BB_B",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_B},
            {
        "MOV_BB_C",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_C},
            {
        "MOV_BB_D",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_D},
            {
        "MOV_BB_I",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_I},
            {
        "MOV_BB_TXL",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_TXL},
            {
        "MOV_BB_TXH",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_TXH},
            {
        "MOV_BB_BA",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_BA},
            {
        "MOV_BB_BB",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_BB},
            {
        "MOV_BB_BC",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_BC},
            {
        "MOV_BB_BD",
             PS0.NONE,
             PS1.R_LD_BB | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_BC")
{
    {
        "MOV_BC_A",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_A},
            {
        "MOV_BC_B",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_B},
            {
        "MOV_BC_C",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_C},
            {
        "MOV_BC_D",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_D},
            {
        "MOV_BC_I",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_I},
            {
        "MOV_BC_TXL",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_TXL},
            {
        "MOV_BC_TXH",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_TXH},
            {
        "MOV_BC_BA",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_BA},
            {
        "MOV_BC_BB",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_BB},
            {
        "MOV_BC_BC",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_BC},
            {
        "MOV_BC_BD",
             PS0.NONE,
             PS1.R_LD_BC | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_BD")
{
    {
        "MOV_BD_A",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_A},
            {
        "MOV_BD_B",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_B},
            {
        "MOV_BD_C",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_C},
            {
        "MOV_BD_D",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_D},
            {
        "MOV_BD_I",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_I},
            {
        "MOV_BD_TXL",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_TXL},
            {
        "MOV_BD_TXH",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_TXH},
            {
        "MOV_BD_BA",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_BA},
            {
        "MOV_BD_BB",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_BB},
            {
        "MOV_BD_BC",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_BC},
            {
        "MOV_BD_BD",
             PS0.NONE,
             PS1.R_LD_BD | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_TXL")
{
    {
        "MOV_TXL_A",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_A},
            {
        "MOV_TXL_B",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_B},
            {
        "MOV_TXL_C",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_C},
            {
        "MOV_TXL_D",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_D},
            {
        "MOV_TXL_I",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_I},
            {
        "MOV_TXL_TXL",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_TXL},
            {
        "MOV_TXL_TXH",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_TXH},
            {
        "MOV_TXL_BA",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_BA},
            {
        "MOV_TXL_BB",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_BB},
            {
        "MOV_TXL_BC",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_BC},
            {
        "MOV_TXL_BD",
             PS0.NONE,
             PS1.R_LD_TXL | PS1.R_OE_BD},
        });
        instructionSet.Add(new InstructionGroup("MOV_TXH")
{
    {
        "MOV_TXH_A",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_A},
            {
        "MOV_TXH_B",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_B},
            {
        "MOV_TXH_C",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_C},
            {
        "MOV_TXH_D",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_D},
            {
        "MOV_TXH_I",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_I},
            {
        "MOV_TXH_TXL",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_TXL},
            {
        "MOV_TXH_TXH",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_TXH},
            {
        "MOV_TXH_BA",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_BA},
            {
        "MOV_TXH_BB",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_BB},
            {
        "MOV_TXH_BC",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_BC},
            {
        "MOV_TXH_BD",
             PS0.NONE,
             PS1.R_LD_TXH | PS1.R_OE_BD},
        });

        //ADR OPERATIONS
        instructionSet.Add(new InstructionGroup("INC")
{
    {
        "INC_ARA",
             PS0.AR_CU_A,
             PS1.NONE
            },
            {
        "INC_ARB",
             PS0.AR_CU_B,
             PS1.NONE
            },
            {
        "INC_ARC",
             PS0.AR_CU_C,
             PS1.NONE
            },
            {
        "INC_ARD",
             PS0.AR_CU_D,
             PS1.NONE
            },
        });
        instructionSet.Add(new InstructionGroup("DEC")
{
    {
        "DEC_ARA",
             PS0.AR_CD_A,
             PS1.NONE
            },
            {
        "DEC_ARB",
             PS0.AR_CD_B,
             PS1.NONE
            },
            {
        "DEC_ARC",
             PS0.AR_CD_C,
             PS1.NONE
            },
            {
        "DEC_ARD",
             PS0.AR_CD_D,
             PS1.NONE
            },
        });
        instructionSet.Add(new InstructionGroup("MOV_ARA")
{
    {
        "MOV_ARA_ARA",
             PS0.AR_LD_ARA | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ARA_ARB",
             PS0.AR_LD_ARA | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ARA_ARC",
             PS0.AR_LD_ARA | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ARA_ARD",
             PS0.AR_LD_ARA | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ARA_ABA",
             PS0.AR_LD_ARA | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ARA_ABB",
             PS0.AR_LD_ARA | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ARA_ABC",
             PS0.AR_LD_ARA | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ARA_ABD",
             PS0.AR_LD_ARA | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ARA_APC",
             PS0.AR_LD_ARA | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ARA_ATX",
             PS0.AR_LD_ARA | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ARB")
{
    {
        "MOV_ARB_ARA",
             PS0.AR_LD_ARB | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ARB_ARB",
             PS0.AR_LD_ARB | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ARB_ARC",
             PS0.AR_LD_ARB | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ARB_ARD",
             PS0.AR_LD_ARB | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ARB_ABA",
             PS0.AR_LD_ARB | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ARB_ABB",
             PS0.AR_LD_ARB | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ARB_ABC",
             PS0.AR_LD_ARB | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ARB_ABD",
             PS0.AR_LD_ARB | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ARB_APC",
             PS0.AR_LD_ARB | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ARB_ATX",
             PS0.AR_LD_ARB | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ARC")
{
    {
        "MOV_ARC_ARA",
             PS0.AR_LD_ARC | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ARC_ARB",
             PS0.AR_LD_ARC | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ARC_ARC",
             PS0.AR_LD_ARC | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ARC_ARD",
             PS0.AR_LD_ARC | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ARC_ABA",
             PS0.AR_LD_ARC | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ARC_ABB",
             PS0.AR_LD_ARC | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ARC_ABC",
             PS0.AR_LD_ARC | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ARC_ABD",
             PS0.AR_LD_ARC | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ARC_APC",
             PS0.AR_LD_ARC | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ARC_ATX",
             PS0.AR_LD_ARC | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ARD")
{
    {
        "MOV_ARD_ARA",
             PS0.AR_LD_ARD | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ARD_ARB",
             PS0.AR_LD_ARD | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ARD_ARC",
             PS0.AR_LD_ARD | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ARD_ARD",
             PS0.AR_LD_ARD | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ARD_ABA",
             PS0.AR_LD_ARD | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ARD_ABB",
             PS0.AR_LD_ARD | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ARD_ABC",
             PS0.AR_LD_ARD | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ARD_ABD",
             PS0.AR_LD_ARD | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ARD_APC",
             PS0.AR_LD_ARD | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ARD_ATX",
             PS0.AR_LD_ARD | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ABA")
{
    {
        "MOV_ABA_ARA",
             PS0.AR_LD_ABA | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ABA_ARB",
             PS0.AR_LD_ABA | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ABA_ARC",
             PS0.AR_LD_ABA | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ABA_ARD",
             PS0.AR_LD_ABA | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ABA_ABA",
             PS0.AR_LD_ABA | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ABA_ABB",
             PS0.AR_LD_ABA | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ABA_ABC",
             PS0.AR_LD_ABA | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ABA_ABD",
             PS0.AR_LD_ABA | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ABA_APC",
             PS0.AR_LD_ABA | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ABA_ATX",
             PS0.AR_LD_ABA | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ABB")
{
    {
        "MOV_ABB_ARA",
             PS0.AR_LD_ABB | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ABB_ARB",
             PS0.AR_LD_ABB | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ABB_ARC",
             PS0.AR_LD_ABB | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ABB_ARD",
             PS0.AR_LD_ABB | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ABB_ABA",
             PS0.AR_LD_ABB | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ABB_ABB",
             PS0.AR_LD_ABB | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ABB_ABC",
             PS0.AR_LD_ABB | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ABB_ABD",
             PS0.AR_LD_ABB | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ABB_APC",
             PS0.AR_LD_ABB | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ABB_ATX",
             PS0.AR_LD_ABB | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ABC")
{
    {
        "MOV_ABC_ARA",
             PS0.AR_LD_ABC | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ABC_ARB",
             PS0.AR_LD_ABC | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ABC_ARC",
             PS0.AR_LD_ABC | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ABC_ARD",
             PS0.AR_LD_ABC | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ABC_ABA",
             PS0.AR_LD_ABC | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ABC_ABB",
             PS0.AR_LD_ABC | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ABC_ABC",
             PS0.AR_LD_ABC | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ABC_ABD",
             PS0.AR_LD_ABC | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ABC_APC",
             PS0.AR_LD_ABC | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ABC_ATX",
             PS0.AR_LD_ABC | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ABD")
{
    {
        "MOV_ABD_ARA",
             PS0.AR_LD_ABD | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ABD_ARB",
             PS0.AR_LD_ABD | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ABD_ARC",
             PS0.AR_LD_ABD | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ABD_ARD",
             PS0.AR_LD_ABD | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ABD_ABA",
             PS0.AR_LD_ABD | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ABD_ABB",
             PS0.AR_LD_ABD | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ABD_ABC",
             PS0.AR_LD_ABD | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ABD_ABD",
             PS0.AR_LD_ABD | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ABD_APC",
             PS0.AR_LD_ABD | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ABD_ATX",
             PS0.AR_LD_ABD | PS0.AR_OE_ATX,
             PS1.NONE},
        });
        instructionSet.Add(new InstructionGroup("MOV_ATX")
{
    {
        "MOV_ATX_ARA",
             PS0.AR_LD_ATX | PS0.AR_OE_ARA,
             PS1.NONE},
            {
        "MOV_ATX_ARB",
             PS0.AR_LD_ATX | PS0.AR_OE_ARB,
             PS1.NONE},
            {
        "MOV_ATX_ARC",
             PS0.AR_LD_ATX | PS0.AR_OE_ARC,
             PS1.NONE},
            {
        "MOV_ATX_ARD",
             PS0.AR_LD_ATX | PS0.AR_OE_ARD,
             PS1.NONE},
            {
        "MOV_ATX_ABA",
             PS0.AR_LD_ATX | PS0.AR_OE_ABA,
             PS1.NONE},
            {
        "MOV_ATX_ABB",
             PS0.AR_LD_ATX | PS0.AR_OE_ABB,
             PS1.NONE},
            {
        "MOV_ATX_ABC",
             PS0.AR_LD_ATX | PS0.AR_OE_ABC,
             PS1.NONE},
            {
        "MOV_ATX_ABD",
             PS0.AR_LD_ATX | PS0.AR_OE_ABD,
             PS1.NONE},
            {
        "MOV_ATX_APC",
             PS0.AR_LD_ATX | PS0.AR_OE_APC,
             PS1.NONE},
            {
        "MOV_ATX_ATX",
             PS0.AR_LD_ATX | PS0.AR_OE_ATX,
             PS1.NONE},
        });

        //JUMP OPERATION
        instructionSet.Add(new InstructionGroup("JMP")
{
    {
        "JMP_ARA",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ARA,
             PS1.NONE
            },
            {
        "JMP_ARB",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ARB,
             PS1.NONE
            },
            {
        "JMP_ARC",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ARC,
             PS1.NONE
            },
            {
        "JMP_ARD",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ARD,
             PS1.NONE
            },
            {
        "JMP_ABA",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ABA,
             PS1.NONE
            },
            {
        "JMP_ABB",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ABB,
             PS1.NONE
            },
            {
        "JMP_ABC",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ABC,
             PS1.NONE
            },
            {
        "JMP_ABD",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ABD,
             PS1.NONE
            },
            {
        "JMP_ATX",
             PS0.JP_ON_N | PS0.AR_LD_APC | PS0.AR_OE_ATX,
             PS1.NONE
            },
        });

        //LOAD CONST 
        instructionSet.Add(new InstructionGroup("LDI")
{
    {
        "LDI_A_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_A},
            {
        "LDI_B_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_B},
            {
        "LDI_C_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_C},
            {
        "LDI_D_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_D},
            {
        "LDI_TXL_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_TXL},
            {
        "LDI_TXH_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_TXH},
            {
        "LDI_BA_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_BA},
            {
        "LDI_BB_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_BB},
            {
        "LDI_BC_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_BC},
            {
        "LDI_BD_$", 2,
             PS0.CR_LD | PS0.MB_INH,
             PS1.R_OE_CR | PS1.R_LD_BD},
        });

        //LOAD FROM ADDRESS
        instructionSet.Add(new InstructionGroup("LD_A")
{
    {
        "LD_A_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_A_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_B")
{
    {
        "LD_B_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_B_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_C")
{
    {
        "LD_C_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_C_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_D")
{
    {
        "LD_D_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_D_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_BA")
{
    {
        "LD_BA_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BA_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_BB")
{
    {
        "LD_BB_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BB_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_BC")
{
    {
        "LD_BC_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BC_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_BD")
{
    {
        "LD_BD_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_BD_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_O")
{
    {
        "LD_O_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_O_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_TXL")
{
    {
        "LD_TXL_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXL_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("LD_TXH")
{
    {
        "LD_TXH_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "LD_TXH_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
        });

        //STORE AT ADDRESS
        instructionSet.Add(new InstructionGroup("STR_A")
{
    {
        "STR_A_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_A_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_B")
{
    {
        "STR_B_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_B_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_C")
{
    {
        "STR_C_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_C_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_D")
{
    {
        "STR_D_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_D_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_BA")
{
    {
        "STR_BA_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BA_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_BB")
{
    {
        "STR_BB_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BB_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_BC")
{
    {
        "STR_BC_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BC_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_BD")
{
    {
        "STR_BD_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_BD_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_I")
{
    {
        "STR_I_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_I_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_TXL")
{
    {
        "STR_TXL_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXL_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
            },
        });
        instructionSet.Add(new InstructionGroup("STR_TXH")
{
    {
        "STR_TXH_[ARA]",
             PS0.AR_OE_ARA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ARB]",
             PS0.AR_OE_ARB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ARC]",
             PS0.AR_OE_ARC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ARD]",
             PS0.AR_OE_ARD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ABA]",
             PS0.AR_OE_ABA | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ABB]",
             PS0.AR_OE_ABB | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ABC]",
             PS0.AR_OE_ABC | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ABD]",
             PS0.AR_OE_ABD | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
            {
        "STR_TXH_[ATX]",
             PS0.AR_OE_ATX | PS0.MB_INH,
             PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
            },
        });

*/