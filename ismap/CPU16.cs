using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismap
{
    public static class CPU16
    {
        public static InstructionSet InstructionSet { get; }
        static CPU16()
        {
            var instructionSet = new InstructionSet();
            //ALU OPERATIONS


            //NO OPERATION
            instructionSet.Add(new InstructionGroup("NOP")
            {
                {"NOP",
                 PS0.INT_EN,
                 PS1.INT_EN
                }
            });

            //NO OPERATION INTERNAL
            instructionSet.Add(new InstructionGroup("NOPI")
            {
                {"NOPI",
                 PS0.NONE,
                 PS1.NONE
                }
            });

            //GPR OPERATIONS
            instructionSet.Add(new InstructionGroup("MOV_A")
            {
                {"MOV_A_A",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_A},
                {"MOV_A_B",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_B},
                {"MOV_A_C",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_C},
                {"MOV_A_D",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_D},
                {"MOV_A_I",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_I},
                {"MOV_A_TXL",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_TXL},
                {"MOV_A_TXH",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_TXH},
                {"MOV_A_BA",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_BA},
                {"MOV_A_BB",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_BB},
                {"MOV_A_BC",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_BC},
                {"MOV_A_BD",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_BD},
                {"MOV_A_S",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_S},
                {"MOV_A_CFG",
                 PS0.NONE,
                 PS1.R_LD_A | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_B")
            {
                {"MOV_B_A",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_A},
                {"MOV_B_B",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_B},
                {"MOV_B_C",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_C},
                {"MOV_B_D",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_D},
                {"MOV_B_I",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_I},
                {"MOV_B_TXL",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_TXL},
                {"MOV_B_TXH",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_TXH},
                {"MOV_B_BA",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_BA},
                {"MOV_B_BB",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_BB},
                {"MOV_B_BC",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_BC},
                {"MOV_B_BD",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_BD},
                {"MOV_B_S",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_S},
                {"MOV_B_CFG",
                 PS0.NONE,
                 PS1.R_LD_B | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_C")
            {
                {"MOV_C_A",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_A},
                {"MOV_C_B",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_B},
                {"MOV_C_C",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_C},
                {"MOV_C_D",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_D},
                {"MOV_C_I",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_I},
                {"MOV_C_TXL",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_TXL},
                {"MOV_C_TXH",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_TXH},
                {"MOV_C_BA",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_BA},
                {"MOV_C_BB",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_BB},
                {"MOV_C_BC",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_BC},
                {"MOV_C_BD",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_BD},
                {"MOV_C_S",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_S},
                {"MOV_C_CFG",
                 PS0.NONE,
                 PS1.R_LD_C | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_D")
            {
                {"MOV_D_A",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_A},
                {"MOV_D_B",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_B},
                {"MOV_D_C",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_C},
                {"MOV_D_D",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_D},
                {"MOV_D_I",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_I},
                {"MOV_D_TXL",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_TXL},
                {"MOV_D_TXH",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_TXH},
                {"MOV_D_BA",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_BA},
                {"MOV_D_BB",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_BB},
                {"MOV_D_BC",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_BC},
                {"MOV_D_BD",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_BD},
                {"MOV_D_S",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_S},
                {"MOV_D_CFG",
                 PS0.NONE,
                 PS1.R_LD_D | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_O")
            {
                {"MOV_O_A",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_A},
                {"MOV_O_B",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_B},
                {"MOV_O_C",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_C},
                {"MOV_O_D",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_D},
                {"MOV_O_I",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_I},
                {"MOV_O_TXL",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_TXL},
                {"MOV_O_TXH",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_TXH},
                {"MOV_O_BA",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_BA},
                {"MOV_O_BB",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_BB},
                {"MOV_O_BC",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_BC},
                {"MOV_O_BD",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_BD},
                {"MOV_O_S",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_S},
                {"MOV_O_CFG",
                 PS0.NONE,
                 PS1.R_LD_O | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_BA")
            {
                {"MOV_BA_A",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_A},
                {"MOV_BA_B",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_B},
                {"MOV_BA_C",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_C},
                {"MOV_BA_D",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_D},
                {"MOV_BA_I",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_I},
                {"MOV_BA_TXL",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_TXL},
                {"MOV_BA_TXH",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_TXH},
                {"MOV_BA_BA",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_BA},
                {"MOV_BA_BB",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_BB},
                {"MOV_BA_BC",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_BC},
                {"MOV_BA_BD",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_BD},
                {"MOV_BA_S",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_S},
                {"MOV_BA_CFG",
                 PS0.NONE,
                 PS1.R_LD_BA | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_BB")
            {
                {"MOV_BB_A",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_A},
                {"MOV_BB_B",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_B},
                {"MOV_BB_C",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_C},
                {"MOV_BB_D",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_D},
                {"MOV_BB_I",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_I},
                {"MOV_BB_TXL",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_TXL},
                {"MOV_BB_TXH",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_TXH},
                {"MOV_BB_BA",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_BA},
                {"MOV_BB_BB",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_BB},
                {"MOV_BB_BC",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_BC},
                {"MOV_BB_BD",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_BD},
                {"MOV_BB_S",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_S},
                {"MOV_BB_CFG",
                 PS0.NONE,
                 PS1.R_LD_BB | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_BC")
            {
                {"MOV_BC_A",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_A},
                {"MOV_BC_B",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_B},
                {"MOV_BC_C",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_C},
                {"MOV_BC_D",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_D},
                {"MOV_BC_I",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_I},
                {"MOV_BC_TXL",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_TXL},
                {"MOV_BC_TXH",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_TXH},
                {"MOV_BC_BA",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_BA},
                {"MOV_BC_BB",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_BB},
                {"MOV_BC_BC",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_BC},
                {"MOV_BC_BD",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_BD},
                {"MOV_BC_S",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_S},
                {"MOV_BC_CFG",
                 PS0.NONE,
                 PS1.R_LD_BC | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_BD")
            {
                {"MOV_BD_A",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_A},
                {"MOV_BD_B",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_B},
                {"MOV_BD_C",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_C},
                {"MOV_BD_D",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_D},
                {"MOV_BD_I",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_I},
                {"MOV_BD_TXL",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_TXL},
                {"MOV_BD_TXH",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_TXH},
                {"MOV_BD_BA",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_BA},
                {"MOV_BD_BB",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_BB},
                {"MOV_BD_BC",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_BC},
                {"MOV_BD_BD",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_BD},
                {"MOV_BD_S",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_S},
                {"MOV_BD_CFG",
                 PS0.NONE,
                 PS1.R_LD_BD | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_TXL")
            {
                {"MOV_TXL_A",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_A},
                {"MOV_TXL_B",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_B},
                {"MOV_TXL_C",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_C},
                {"MOV_TXL_D",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_D},
                {"MOV_TXL_I",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_I},
                {"MOV_TXL_TXL",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_TXL},
                {"MOV_TXL_TXH",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_TXH},
                {"MOV_TXL_BA",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_BA},
                {"MOV_TXL_BB",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_BB},
                {"MOV_TXL_BC",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_BC},
                {"MOV_TXL_BD",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_BD},
                {"MOV_TXL_S",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_S},
                {"MOV_TXL_CFG",
                 PS0.NONE,
                 PS1.R_LD_TXL | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_TXH")
            {
                {"MOV_TXH_A",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_A},
                {"MOV_TXH_B",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_B},
                {"MOV_TXH_C",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_C},
                {"MOV_TXH_D",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_D},
                {"MOV_TXH_I",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_I},
                {"MOV_TXH_TXL",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_TXL},
                {"MOV_TXH_TXH",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_TXH},
                {"MOV_TXH_BA",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_BA},
                {"MOV_TXH_BB",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_BB},
                {"MOV_TXH_BC",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_BC},
                {"MOV_TXH_BD",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_BD},
                {"MOV_TXH_S",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_S},
                {"MOV_TXH_CFG",
                 PS0.NONE,
                 PS1.R_LD_TXH | PS1.R_OE_CFG},
            });
            instructionSet.Add(new InstructionGroup("MOV_S")
            {
                {"MOV_S_A",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_A},
                {"MOV_S_B",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_B},
                {"MOV_S_C",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_C},
                {"MOV_S_D",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_D},
                {"MOV_S_I",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_I},
                {"MOV_S_TXL",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_TXL},
                {"MOV_S_TXH",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_TXH},
                {"MOV_S_BA",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_BA},
                {"MOV_S_BB",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_BB},
                {"MOV_S_BC",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_BC},
                {"MOV_S_BD",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_BD},
                {"MOV_S_S",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_S},
                {"MOV_S_CFG",
                 PS0.NONE,
                 PS1.R_LD_S | PS1.R_OE_CFG},
            });

            //ADR OPERATIONS
            instructionSet.Add(new InstructionGroup("INC")
            {
                {"INC_ARA",
                 PS0.AR_CU_A,
                 PS1.NONE
                },
                {"INC_ARB",
                 PS0.AR_CU_B,
                 PS1.NONE
                },
                {"INC_ARC",
                 PS0.AR_CU_C,
                 PS1.NONE
                },
                {"INC_ARD",
                 PS0.AR_CU_D,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("DEC")
            {
                {"DEC_ARA",
                 PS0.AR_CD_A,
                 PS1.NONE
                },
                {"DEC_ARB",
                 PS0.AR_CD_B,
                 PS1.NONE
                },
                {"DEC_ARC",
                 PS0.AR_CD_C,
                 PS1.NONE
                },
                {"DEC_ARD",
                 PS0.AR_CD_D,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("MOV_ARA")
            {
                {"MOV_ARA_ARA",
                 PS0.AR_LD_ARA | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ARA_ARB",
                 PS0.AR_LD_ARA | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ARA_ARC",
                 PS0.AR_LD_ARA | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ARA_ARD",
                 PS0.AR_LD_ARA | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ARA_ABA",
                 PS0.AR_LD_ARA | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ARA_ABB",
                 PS0.AR_LD_ARA | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ARA_ABC",
                 PS0.AR_LD_ARA | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ARA_ABD",
                 PS0.AR_LD_ARA | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ARA_APC",
                 PS0.AR_LD_ARA | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ARA_ATX",
                 PS0.AR_LD_ARA | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ARA_SP",
                 PS0.AR_LD_ARA | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ARA_RET",
                 PS0.AR_LD_ARA | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ARA_ISSR",
                 PS0.AR_LD_ARA | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ARB")
            {
                {"MOV_ARB_ARA",
                 PS0.AR_LD_ARB | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ARB_ARB",
                 PS0.AR_LD_ARB | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ARB_ARC",
                 PS0.AR_LD_ARB | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ARB_ARD",
                 PS0.AR_LD_ARB | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ARB_ABA",
                 PS0.AR_LD_ARB | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ARB_ABB",
                 PS0.AR_LD_ARB | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ARB_ABC",
                 PS0.AR_LD_ARB | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ARB_ABD",
                 PS0.AR_LD_ARB | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ARB_APC",
                 PS0.AR_LD_ARB | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ARB_ATX",
                 PS0.AR_LD_ARB | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ARB_SP",
                 PS0.AR_LD_ARB | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ARB_RET",
                 PS0.AR_LD_ARB | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ARB_ISSR",
                 PS0.AR_LD_ARB | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ARC")
            {
                {"MOV_ARC_ARA",
                 PS0.AR_LD_ARC | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ARC_ARB",
                 PS0.AR_LD_ARC | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ARC_ARC",
                 PS0.AR_LD_ARC | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ARC_ARD",
                 PS0.AR_LD_ARC | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ARC_ABA",
                 PS0.AR_LD_ARC | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ARC_ABB",
                 PS0.AR_LD_ARC | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ARC_ABC",
                 PS0.AR_LD_ARC | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ARC_ABD",
                 PS0.AR_LD_ARC | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ARC_APC",
                 PS0.AR_LD_ARC | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ARC_ATX",
                 PS0.AR_LD_ARC | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ARC_SP",
                 PS0.AR_LD_ARC | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ARC_RET",
                 PS0.AR_LD_ARC | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ARC_ISSR",
                 PS0.AR_LD_ARC | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ARD")
            {
                {"MOV_ARD_ARA",
                 PS0.AR_LD_ARD | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ARD_ARB",
                 PS0.AR_LD_ARD | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ARD_ARC",
                 PS0.AR_LD_ARD | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ARD_ARD",
                 PS0.AR_LD_ARD | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ARD_ABA",
                 PS0.AR_LD_ARD | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ARD_ABB",
                 PS0.AR_LD_ARD | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ARD_ABC",
                 PS0.AR_LD_ARD | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ARD_ABD",
                 PS0.AR_LD_ARD | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ARD_APC",
                 PS0.AR_LD_ARD | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ARD_ATX",
                 PS0.AR_LD_ARD | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ARD_SP",
                 PS0.AR_LD_ARD | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ARD_RET",
                 PS0.AR_LD_ARD | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ARD_ISSR",
                 PS0.AR_LD_ARD | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ABA")
            {
                {"MOV_ABA_ARA",
                 PS0.AR_LD_ABA | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ABA_ARB",
                 PS0.AR_LD_ABA | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ABA_ARC",
                 PS0.AR_LD_ABA | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ABA_ARD",
                 PS0.AR_LD_ABA | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ABA_ABA",
                 PS0.AR_LD_ABA | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ABA_ABB",
                 PS0.AR_LD_ABA | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ABA_ABC",
                 PS0.AR_LD_ABA | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ABA_ABD",
                 PS0.AR_LD_ABA | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ABA_APC",
                 PS0.AR_LD_ABA | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ABA_ATX",
                 PS0.AR_LD_ABA | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ABA_SP",
                 PS0.AR_LD_ABA | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ABA_RET",
                 PS0.AR_LD_ABA | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ABA_ISSR",
                 PS0.AR_LD_ABA | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ABB")
            {
                {"MOV_ABB_ARA",
                 PS0.AR_LD_ABB | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ABB_ARB",
                 PS0.AR_LD_ABB | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ABB_ARC",
                 PS0.AR_LD_ABB | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ABB_ARD",
                 PS0.AR_LD_ABB | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ABB_ABA",
                 PS0.AR_LD_ABB | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ABB_ABB",
                 PS0.AR_LD_ABB | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ABB_ABC",
                 PS0.AR_LD_ABB | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ABB_ABD",
                 PS0.AR_LD_ABB | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ABB_APC",
                 PS0.AR_LD_ABB | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ABB_ATX",
                 PS0.AR_LD_ABB | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ABB_SP",
                 PS0.AR_LD_ABB | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ABB_RET",
                 PS0.AR_LD_ABB | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ABB_ISSR",
                 PS0.AR_LD_ABB | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ABC")
            {
                {"MOV_ABC_ARA",
                 PS0.AR_LD_ABC | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ABC_ARB",
                 PS0.AR_LD_ABC | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ABC_ARC",
                 PS0.AR_LD_ABC | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ABC_ARD",
                 PS0.AR_LD_ABC | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ABC_ABA",
                 PS0.AR_LD_ABC | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ABC_ABB",
                 PS0.AR_LD_ABC | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ABC_ABC",
                 PS0.AR_LD_ABC | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ABC_ABD",
                 PS0.AR_LD_ABC | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ABC_APC",
                 PS0.AR_LD_ABC | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ABC_ATX",
                 PS0.AR_LD_ABC | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ABC_SP",
                 PS0.AR_LD_ABC | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ABC_RET",
                 PS0.AR_LD_ABC | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ABC_ISSR",
                 PS0.AR_LD_ABC | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ABD")
            {
                {"MOV_ABD_ARA",
                 PS0.AR_LD_ABD | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ABD_ARB",
                 PS0.AR_LD_ABD | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ABD_ARC",
                 PS0.AR_LD_ABD | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ABD_ARD",
                 PS0.AR_LD_ABD | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ABD_ABA",
                 PS0.AR_LD_ABD | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ABD_ABB",
                 PS0.AR_LD_ABD | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ABD_ABC",
                 PS0.AR_LD_ABD | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ABD_ABD",
                 PS0.AR_LD_ABD | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ABD_APC",
                 PS0.AR_LD_ABD | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ABD_ATX",
                 PS0.AR_LD_ABD | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ABD_SP",
                 PS0.AR_LD_ABA | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ABD_RET",
                 PS0.AR_LD_ABD | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ABD_ISSR",
                 PS0.AR_LD_ABA | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ATX")
            {
                {"MOV_ATX_ARA",
                 PS0.AR_LD_ATX | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ATX_ARB",
                 PS0.AR_LD_ATX | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ATX_ARC",
                 PS0.AR_LD_ATX | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ATX_ARD",
                 PS0.AR_LD_ATX | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ATX_ABA",
                 PS0.AR_LD_ATX | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ATX_ABB",
                 PS0.AR_LD_ATX | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ATX_ABC",
                 PS0.AR_LD_ATX | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ATX_ABD",
                 PS0.AR_LD_ATX | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ATX_APC",
                 PS0.AR_LD_ATX | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ATX_ATX",
                 PS0.AR_LD_ATX | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ATX_SP",
                 PS0.AR_LD_ATX | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ATX_RET",
                 PS0.AR_LD_ATX | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ATX_ISSR",
                 PS0.AR_LD_ATX | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_SP")
            {
                {"MOV_SP_ARA",
                 PS0.AR_LD_SP | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_SP_ARB",
                 PS0.AR_LD_SP | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_SP_ARC",
                 PS0.AR_LD_SP | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_SP_ARD",
                 PS0.AR_LD_SP | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_SP_ABA",
                 PS0.AR_LD_SP | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_SP_ABB",
                 PS0.AR_LD_SP | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_SP_ABC",
                 PS0.AR_LD_SP | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_SP_ABD",
                 PS0.AR_LD_SP | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_SP_APC",
                 PS0.AR_LD_SP | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_SP_ATX",
                 PS0.AR_LD_SP | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_SP_SP",
                 PS0.AR_LD_SP | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_SP_RET",
                 PS0.AR_LD_SP | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_SP_ISSR",
                 PS0.AR_LD_SP| PS0.AR_OE_ISSR,
                 PS1.NONE},
            });
            instructionSet.Add(new InstructionGroup("MOV_ISSR")
            {
                {"MOV_ISSR_ARA",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ARA,
                 PS1.NONE},
                {"MOV_ISSR_ARB",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ARB,
                 PS1.NONE},
                {"MOV_ISSR_ARC",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ARC,
                 PS1.NONE},
                {"MOV_ISSR_ARD",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ARD,
                 PS1.NONE},
                {"MOV_ISSR_ABA",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ABA,
                 PS1.NONE},
                {"MOV_ISSR_ABB",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ABB,
                 PS1.NONE},
                {"MOV_ISSR_ABC",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ABC,
                 PS1.NONE},
                {"MOV_ISSR_ABD",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ABD,
                 PS1.NONE},
                {"MOV_ISSR_APC",
                 PS0.AR_LD_ISSR | PS0.AR_OE_APC,
                 PS1.NONE},
                {"MOV_ISSR_ATX",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ATX,
                 PS1.NONE},
                {"MOV_ISSR_SP",
                 PS0.AR_LD_ISSR | PS0.AR_OE_SP,
                 PS1.NONE},
                {"MOV_ISSR_RET",
                 PS0.AR_LD_ISSR | PS0.AR_OE_RET,
                 PS1.NONE},
                {"MOV_ISSR_ISSR",
                 PS0.AR_LD_ISSR | PS0.AR_OE_ISSR,
                 PS1.NONE},
            });

            instructionSet.Add(new InstructionGroup("CALL")
            {
                {"CALL_ARA",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARA | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ARB",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARB | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ARC",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARC | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ARD",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARD | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ABA",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABA | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ABB",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABB | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ABC",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABC | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ABD",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABD | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ATX",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ATX | PS0.RET_LD,
                 PS1.NONE
                },
                {"CALL_ISSR",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ISSR | PS0.RET_LD,
                 PS1.NONE
                },
            });

            //JUMP OPERATION
            /*
            JP_ON_CARRY     JC
            JP_ON_ODD       JO
            JP_ON_SIGNED    JS
            JP_ON_ZERO      JZ
            JP_ON_EQUAL     JE
            JP_ON_NOTCARRY  JNC
            JP_ON_NOTODD    JNO    
            JP_ON_NOTSIGNED JNS
            JP_ON_NOTZERO   JNZ
            JP_ON_NOTEQUAL  JNE
            */
            instructionSet.Add(new InstructionGroup("JMP")
            {
                {"JMP_ARA",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JMP_ARB",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JMP_ARC",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JMP_ARD",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JMP_ABA",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JMP_ABB",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JMP_ABC",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JMP_ABD",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JMP_ATX",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
                {"JMP_RET",
                 PS0.JP_ON_N | PS0.AR_LD_PC | PS0.AR_OE_RET,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JC")
            {
                {"JC_ARA",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JC_ARB",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JC_ARC",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JC_ARD",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JC_ABA",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JC_ABB",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JC_ABC",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JC_ABD",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JC_ATX",
                 PS0.JP_ON_CARRY | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JO")
            {
                {"JO_ARA",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JO_ARB",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JO_ARC",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JO_ARD",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JO_ABA",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JO_ABB",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JO_ABC",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JO_ABD",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JO_ATX",
                 PS0.JP_ON_ODD | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JS")
            {
                {"JS_ARA",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JS_ARB",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JS_ARC",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JS_ARD",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JS_ABA",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JS_ABB",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JS_ABC",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JS_ABD",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JS_ATX",
                 PS0.JP_ON_SIGNED | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JZ")
            {
                {"JZ_ARA",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JZ_ARB",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JZ_ARC",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JZ_ARD",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JZ_ABA",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JZ_ABB",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JZ_ABC",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JZ_ABD",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JZ_ATX",
                 PS0.JP_ON_ZERO | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JE")
            {
                {"JE_ARA",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JE_ARB",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JE_ARC",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JE_ARD",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JE_ABA",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JE_ABB",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JE_ABC",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JE_ABD",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JE_ATX",
                 PS0.JP_ON_EQUAL | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JNC")
            {
                {"JNC_ARA",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JNC_ARB",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JNC_ARC",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JNC_ARD",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JNC_ABA",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JNC_ABB",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JNC_ABC",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JNC_ABD",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JNC_ATX",
                 PS0.JP_ON_NOTCARRY | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JNO")
            {
                {"JNO_ARA",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JNO_ARB",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JNO_ARC",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JNO_ARD",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JNO_ABA",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JNO_ABB",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JNO_ABC",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JNO_ABD",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JNO_ATX",
                 PS0.JP_ON_NOTODD | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JNS")
            {
                {"JNS_ARA",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JNS_ARB",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JNS_ARC",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JNS_ARD",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JNS_ABA",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JNS_ABB",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JNS_ABC",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JNS_ABD",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JNS_ATX",
                 PS0.JP_ON_NOTSIGNED | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JNZ")
            {
                {"JNZ_ARA",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JNZ_ARB",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JNZ_ARC",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JNZ_ARD",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JNZ_ABA",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JNZ_ABB",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JNZ_ABC",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JNZ_ABD",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JNZ_ATX",
                 PS0.JP_ON_NOTZERO | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });
            instructionSet.Add(new InstructionGroup("JNE")
            {
                {"JNE_ARA",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARA,
                 PS1.NONE
                },
                {"JNE_ARB",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARB,
                 PS1.NONE
                },
                {"JNE_ARC",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARC,
                 PS1.NONE
                },
                {"JNE_ARD",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ARD,
                 PS1.NONE
                },
                {"JNE_ABA",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABA,
                 PS1.NONE
                },
                {"JNE_ABB",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABB,
                 PS1.NONE
                },
                {"JNE_ABC",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABC,
                 PS1.NONE
                },
                {"JNE_ABD",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ABD,
                 PS1.NONE
                },
                {"JNE_ATX",
                 PS0.JP_ON_NOTEQUAL | PS0.AR_LD_PC | PS0.AR_OE_ATX,
                 PS1.NONE
                },
            });



            //LOAD CONST 
            instructionSet.Add(new InstructionGroup("LDI")
            {
                {"LDI_A_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_A
                },
                {"LDI_B_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_B
                },
                {"LDI_C_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_C
                },
                {"LDI_D_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_D
                },
                {"LDI_O_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_O
                },
                {"LDI_BA_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_BA
                },
                {"LDI_BB_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_BB
                },
                {"LDI_BC_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_BC
                },
                {"LDI_BD_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_BD
                },
                {"LDI_TXL_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_TXL
                },
                {"LDI_TXH_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_TXH
                },
                {"LDI_S_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_S
                },
                {"LDI_CFG_$", 2,
                 PS0.CR_LD | PS0.MB_INH,
                 PS1.R_OE_CR | PS1.R_LD_CFG
                },
            });

            //LOAD FROM ADDRESS
            instructionSet.Add(new InstructionGroup("LD_A")
            {
                {"LD_A_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_A_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_B")
            {
                {"LD_B_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_B_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_C")
            {
                {"LD_C_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_C_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_D")
            {
                {"LD_D_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_D_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_BA")
            {
                {"LD_BA_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BA_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_BB")
            {
                {"LD_BB_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BB_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_BC")
            {
                {"LD_BC_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BC_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_BD")
            {
                {"LD_BD_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_BD_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_O")
            {
                {"LD_O_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_O_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_TXL")
            {
                {"LD_TXL_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXL_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_TXH")
            {
                {"LD_TXH_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_TXH_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_S")
            {
                {"LD_S_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_S_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("LD_CFG")
            {
                {"LD_CFG_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"LD_CFG_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
            });

            //STORE AT ADDRESS
            instructionSet.Add(new InstructionGroup("STR_A")
            {
                {"STR_A_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY
                },
                {"STR_A_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_A_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_B")
            {
                {"STR_B_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_B_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_C")
            {
                {"STR_C_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_C_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_D")
            {
                {"STR_D_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_D_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_BA")
            {
                {"STR_BA_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BA_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_BB")
            {
                {"STR_BB_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BB_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_BC")
            {
                {"STR_BC_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BC_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_BD")
            {
                {"STR_BD_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_BD_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_I")
            {
                {"STR_I_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_I_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_TXL")
            {
                {"STR_TXL_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXL_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_TXH")
            {
                {"STR_TXH_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_TXH_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_S")
            {
                {"STR_S_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_S_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH  | PS1.OP_DELAY
                },
            });
            instructionSet.Add(new InstructionGroup("STR_CFG")
            {
                {"STR_CFG_ARA",
                 PS0.AR_OE_ARA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ARB",
                 PS0.AR_OE_ARB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ARC",
                 PS0.AR_OE_ARC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ARD",
                 PS0.AR_OE_ARD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ABA",
                 PS0.AR_OE_ABA | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ABB",
                 PS0.AR_OE_ABB | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ABC",
                 PS0.AR_OE_ABC | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ABD",
                 PS0.AR_OE_ABD | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
                {"STR_CFG_ATX",
                 PS0.AR_OE_ATX | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH  | PS1.OP_DELAY
                },
            });


            //PUSH DECREMENT SP WRITE MEM
            instructionSet.Add(new InstructionGroup("PUSH")
            {
                {"PUSH_A",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,                 
                 PS1.MEM_WRITE | PS1.R_OE_A | PS1.PC_INH | PS1.OP_DELAY     
                },
                {"PUSH_B",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_B | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_C",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_C | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_D",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_D | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_BA",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BA | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_BB",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BB | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_BC",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BC | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_BD",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_BD | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_I",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_I | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_TXL",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXL | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_TXH",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_TXH | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_S",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_S | PS1.PC_INH | PS1.OP_DELAY
                },
                {"PUSH_CFG",
                 PS0.AR_OE_SP | PS0.AR_CD_SP | PS0.MB_INH,
                 PS1.MEM_WRITE | PS1.R_OE_CFG | PS1.PC_INH | PS1.OP_DELAY
                },
            });
            //POP INCREMENT SP WRITE MEM
            instructionSet.Add(new InstructionGroup("POP")
            {
                {"POP_A",
                 PS0.AR_OE_SP | PS0.MB_INH,                 
                 PS1.MEM_READ | PS1.R_LD_A | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU  
                },
                {"POP_B",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_B | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_C",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_C | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_D",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_D | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_BA",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BA | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_BB",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BB | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_BC",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BC | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_BD",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_BD | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_O",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_O | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_TXL",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXL | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_TXH",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_TXH | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_S",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_S | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
                {"POP_CFG",
                 PS0.AR_OE_SP | PS0.MB_INH,
                 PS1.MEM_READ | PS1.R_LD_CFG | PS1.PC_INH  | PS1.OP_DELAY | PS1.SP_CU
                },
            });



            //ADD R + R
            instructionSet.Add(new InstructionGroup("ADD_A")
            {
                {"ADD_A_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADD_A_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADD_A_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADD_A_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADD_A_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_B")
            {
                {"ADD_B_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADD_B_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_C")
            {
                {"ADD_C_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADD_C_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_D")
            {
                {"ADD_D_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADD_D_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_BA")
            {
                {"ADD_BA_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADD_BA_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_BB")
            {
                {"ADD_BB_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADD_BB_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_BC")
            {
                {"ADD_BC_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADD_BC_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_BD")
            {
                {"ADD_BD_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADD_BD_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_O")
            {
                {"ADD_O_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADD_O_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_TXL")
            {
                {"ADD_TXL_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADD_TXL_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_TXH")
            {
                {"ADD_TXH_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADD_TXH_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("ADD_CFG")
            {
                {"ADD_CFG_A_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_A_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_A_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_A_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_B_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_B_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_B_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_B_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_C_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_C_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_C_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_C_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_D_A",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_D_B",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_D_C",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADD_CFG_D_D",
                 PS0.ALU_OP_ADD | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //SUBTRACT R - R
            instructionSet.Add(new InstructionGroup("SUB_A")
            {
                {"SUB_A_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SUB_A_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SUB_A_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SUB_A_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SUB_A_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_B")
            {
                {"SUB_B_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SUB_B_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_C")
            {
                {"SUB_C_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SUB_C_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_D")
            {
                {"SUB_D_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SUB_D_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_BA")
            {
                {"SUB_BA_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SUB_BA_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_BB")
            {
                {"SUB_BB_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SUB_BB_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_BC")
            {
                {"SUB_BC_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SUB_BC_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_BD")
            {
                {"SUB_BD_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SUB_BD_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_O")
            {
                {"SUB_O_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SUB_O_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_TXL")
            {
                {"SUB_TXL_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SUB_TXL_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_TXH")
            {
                {"SUB_TXH_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SUB_TXH_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("SUB_CFG")
            {
                {"SUB_CFG_A_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_A_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_A_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_A_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_B_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_B_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_B_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_B_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_C_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_C_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_C_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_C_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_D_A",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_D_B",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_D_C",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SUB_CFG_D_D",
                 PS0.ALU_OP_SUB | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });

            //INCREMENT S AND MOVE TO T
            instructionSet.Add(new InstructionGroup("INC_A")
            {
                {"INC_A_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"INC_A_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"INC_A_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"INC_A_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("INC_B")
            {
                {"INC_B_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"INC_B_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"INC_B_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"INC_B_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("INC_C")
            {
                {"INC_C_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"INC_C_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"INC_C_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"INC_C_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("INC_D")
            {
                {"INC_D_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"INC_D_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"INC_D_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"INC_D_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("INC_BA")
            {
                {"INC_BA_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"INC_BA_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"INC_BA_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"INC_BA_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("INC_BB")
            {
                {"INC_BB_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"INC_BB_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"INC_BB_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"INC_BB_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("INC_BC")
            {
                {"INC_BC_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"INC_BC_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"INC_BC_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"INC_BC_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("INC_BD")
            {
                {"INC_BD_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"INC_BD_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"INC_BD_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"INC_BD_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("INC_O")
            {
                {"INC_O_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"INC_O_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"INC_O_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"INC_O_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("INC_TXL")
            {
                {"INC_TXL_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"INC_TXL_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"INC_TXL_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"INC_TXL_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("INC_TXH")
            {
                {"INC_TXH_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"INC_TXH_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"INC_TXH_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"INC_TXH_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("INC_CFG")
            {
                {"INC_CFG_A",
                 PS0.ALU_OP_INC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"INC_CFG_B",
                 PS0.ALU_OP_INC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"INC_CFG_C",
                 PS0.ALU_OP_INC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"INC_CFG_D",
                 PS0.ALU_OP_INC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //DECREMENT S AND MOVE TO T
            instructionSet.Add(new InstructionGroup("DEC_A")
            {
                {"DEC_A_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"DEC_A_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"DEC_A_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"DEC_A_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_B")
            {
                {"DEC_B_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"DEC_B_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"DEC_B_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"DEC_B_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_C")
            {
                {"DEC_C_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"DEC_C_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"DEC_C_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"DEC_C_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_D")
            {
                {"DEC_D_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"DEC_D_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"DEC_D_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"DEC_D_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_BA")
            {
                {"DEC_BA_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"DEC_BA_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"DEC_BA_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"DEC_BA_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_BB")
            {
                {"DEC_BB_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"DEC_BB_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"DEC_BB_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"DEC_BB_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_BC")
            {
                {"DEC_BC_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"DEC_BC_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"DEC_BC_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"DEC_BC_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_BD")
            {
                {"DEC_BD_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"DEC_BD_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"DEC_BD_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"DEC_BD_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_O")
            {
                {"DEC_O_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"DEC_O_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"DEC_O_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"DEC_O_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_TXL")
            {
                {"DEC_TXL_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"DEC_TXL_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"DEC_TXL_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"DEC_TXL_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_TXH")
            {
                {"DEC_TXH_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"DEC_TXH_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"DEC_TXH_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"DEC_TXH_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("DEC_CFG")
            {
                {"DEC_CFG_A",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"DEC_CFG_B",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"DEC_CFG_C",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"DEC_CFG_D",
                 PS0.ALU_OP_DEC | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });

            //ADD WITH CARRY
            instructionSet.Add(new InstructionGroup("ADC_A")
            {
                {"ADC_A_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADC_A_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADC_A_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"ADC_A_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ADC_A_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_B")
            {
                {"ADC_B_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ADC_B_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_C")
            {
                {"ADC_C_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ADC_C_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_D")
            {
                {"ADC_D_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"ADC_D_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_BA")
            {
                {"ADC_BA_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ADC_BA_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_BB")
            {
                {"ADC_BB_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ADC_BB_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_BC")
            {
                {"ADC_BC_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ADC_BC_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_BD")
            {
                {"ADC_BD_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"ADC_BD_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_O")
            {
                {"ADC_O_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ADC_O_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_TXL")
            {
                {"ADC_TXL_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ADC_TXL_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_TXH")
            {
                {"ADC_TXH_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ADC_TXH_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("ADC_CFG")
            {
                {"ADC_CFG_A_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_A_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_A_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_A_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_B_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_B_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_B_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_B_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_C_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_C_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_C_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_C_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_D_A",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_D_B",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_D_C",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"ADC_CFG_D_D",
                 PS0.ALU_OP_ADC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //SUBTRACT WITH BORROW
            instructionSet.Add(new InstructionGroup("SBC_A")
            {
                {"SBC_A_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SBC_A_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SBC_A_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"SBC_A_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"SBC_A_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_B")
            {
                {"SBC_B_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"SBC_B_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_C")
            {
                {"SBC_C_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"SBC_C_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_D")
            {
                {"SBC_D_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"SBC_D_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_BA")
            {
                {"SBC_BA_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"SBC_BA_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_BB")
            {
                {"SBC_BB_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"SBC_BB_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_BC")
            {
                {"SBC_BC_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"SBC_BC_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_BD")
            {
                {"SBC_BD_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"SBC_BD_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_O")
            {
                {"SBC_O_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"SBC_O_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_TXL")
            {
                {"SBC_TXL_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"SBC_TXL_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_TXH")
            {
                {"SBC_TXH_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"SBC_TXH_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("SBC_CFG")
            {
                {"SBC_CFG_A_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_A_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_A_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_A_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_B_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_B_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_B_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_B_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_C_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_C_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_C_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_C_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_D_A",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_D_B",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_D_C",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"SBC_CFG_D_D",
                 PS0.ALU_OP_SBC | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });




            //0 LSL LOGICAL SHIFT LEFT
            instructionSet.Add(new InstructionGroup("LSL_A")
            {
                {"LSL_A_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSL_A_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSL_A_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSL_A_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_B")
            {
                {"LSL_B_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSL_B_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSL_B_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSL_B_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_C")
            {
                {"LSL_C_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSL_C_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSL_C_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSL_C_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_D")
            {
                {"LSL_D_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSL_D_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSL_D_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSL_D_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_BA")
            {
                {"LSL_BA_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSL_BA_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSL_BA_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSL_BA_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_BB")
            {
                {"LSL_BB_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSL_BB_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSL_BB_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSL_BB_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_BC")
            {
                {"LSL_BC_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSL_BC_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSL_BC_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSL_BC_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_BD")
            {
                {"LSL_BD_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSL_BD_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSL_BD_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSL_BD_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_O")
            {
                {"LSL_O_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSL_O_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSL_O_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSL_O_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_TXL")
            {
                {"LSL_TXL_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSL_TXL_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSL_TXL_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSL_TXL_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_TXH")
            {
                {"LSL_TXH_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSL_TXH_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSL_TXH_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSL_TXH_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LSL_CFG")
            {
                {"LSL_CFG_A",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSL_CFG_B",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSL_CFG_C",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSL_CFG_D",
                 PS0.ALU_OP_LSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //1 LSA ARITHMETIC SHIFT LEFT
            instructionSet.Add(new InstructionGroup("LSA_A")
            {
                {"LSA_A_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSA_A_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSA_A_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSA_A_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_B")
            {
                {"LSA_B_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSA_B_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSA_B_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSA_B_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_C")
            {
                {"LSA_C_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSA_C_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSA_C_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSA_C_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_D")
            {
                {"LSA_D_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSA_D_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSA_D_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSA_D_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_BA")
            {
                {"LSA_BA_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSA_BA_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSA_BA_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSA_BA_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_BB")
            {
                {"LSA_BB_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSA_BB_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSA_BB_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSA_BB_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_BC")
            {
                {"LSA_BC_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSA_BC_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSA_BC_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSA_BC_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_BD")
            {
                {"LSA_BD_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSA_BD_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSA_BD_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSA_BD_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_O")
            {
                {"LSA_O_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSA_O_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSA_O_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSA_O_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_TXL")
            {
                {"LSA_TXL_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSA_TXL_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSA_TXL_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSA_TXL_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_TXH")
            {
                {"LSA_TXH_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSA_TXH_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSA_TXH_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSA_TXH_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LSA_CFG")
            {
                {"LSA_CFG_A",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSA_CFG_B",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSA_CFG_C",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSA_CFG_D",
                 PS0.ALU_OP_LSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //2 LRO ROTATE LEFT
            instructionSet.Add(new InstructionGroup("LRO_A")
            {
                {"LRO_A_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LRO_A_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LRO_A_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LRO_A_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_B")
            {
                {"LRO_B_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LRO_B_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LRO_B_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LRO_B_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_C")
            {
                {"LRO_C_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LRO_C_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LRO_C_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LRO_C_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_D")
            {
                {"LRO_D_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LRO_D_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LRO_D_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LRO_D_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_BA")
            {
                {"LRO_BA_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LRO_BA_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LRO_BA_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LRO_BA_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_BB")
            {
                {"LRO_BB_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LRO_BB_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LRO_BB_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LRO_BB_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_BC")
            {
                {"LRO_BC_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LRO_BC_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LRO_BC_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LRO_BC_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_BD")
            {
                {"LRO_BD_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LRO_BD_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LRO_BD_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LRO_BD_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_O")
            {
                {"LRO_O_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LRO_O_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LRO_O_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LRO_O_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_TXL")
            {
                {"LRO_TXL_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LRO_TXL_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LRO_TXL_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LRO_TXL_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_TXH")
            {
                {"LRO_TXH_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LRO_TXH_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LRO_TXH_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LRO_TXH_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LRO_CFG")
            {
                {"LRO_CFG_A",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LRO_CFG_B",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LRO_CFG_C",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LRO_CFG_D",
                 PS0.ALU_OP_LRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //3 LSH SHIFT LEFT << 1
            instructionSet.Add(new InstructionGroup("LSH_A")
            {
                {"LSH_A_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSH_A_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSH_A_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LSH_A_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_B")
            {
                {"LSH_B_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSH_B_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSH_B_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LSH_B_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_C")
            {
                {"LSH_C_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSH_C_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSH_C_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LSH_C_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_D")
            {
                {"LSH_D_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSH_D_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSH_D_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LSH_D_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_BA")
            {
                {"LSH_BA_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSH_BA_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSH_BA_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LSH_BA_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_BB")
            {
                {"LSH_BB_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSH_BB_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSH_BB_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LSH_BB_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_BC")
            {
                {"LSH_BC_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSH_BC_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSH_BC_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LSH_BC_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_BD")
            {
                {"LSH_BD_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSH_BD_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSH_BD_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LSH_BD_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_O")
            {
                {"LSH_O_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSH_O_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSH_O_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LSH_O_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_TXL")
            {
                {"LSH_TXL_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSH_TXL_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSH_TXL_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LSH_TXL_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_TXH")
            {
                {"LSH_TXH_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSH_TXH_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSH_TXH_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LSH_TXH_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LSH_CFG")
            {
                {"LSH_CFG_A",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSH_CFG_B",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSH_CFG_C",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LSH_CFG_D",
                 PS0.ALU_OP_LSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });

            //0 RSL LOGICAL SHIFT RIGHT
            instructionSet.Add(new InstructionGroup("RSL_A")
            {
                {"RSL_A_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSL_A_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSL_A_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSL_A_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_B")
            {
                {"RSL_B_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSL_B_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSL_B_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSL_B_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_C")
            {
                {"RSL_C_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSL_C_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSL_C_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSL_C_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_D")
            {
                {"RSL_D_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSL_D_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSL_D_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSL_D_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_BA")
            {
                {"RSL_BA_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSL_BA_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSL_BA_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSL_BA_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_BB")
            {
                {"RSL_BB_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSL_BB_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSL_BB_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSL_BB_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_BC")
            {
                {"RSL_BC_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSL_BC_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSL_BC_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSL_BC_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_BD")
            {
                {"RSL_BD_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSL_BD_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSL_BD_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSL_BD_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_O")
            {
                {"RSL_O_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSL_O_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSL_O_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSL_O_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_TXL")
            {
                {"RSL_TXL_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSL_TXL_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSL_TXL_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSL_TXL_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_TXH")
            {
                {"RSL_TXH_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSL_TXH_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSL_TXH_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSL_TXH_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("RSL_CFG")
            {
                {"RSL_CFG_A",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSL_CFG_B",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSL_CFG_C",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSL_CFG_D",
                 PS0.ALU_OP_RSL | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //1 RSA ARITHMETIC SHIFT RIGHT
            instructionSet.Add(new InstructionGroup("RSA_A")
            {
                {"RSA_A_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSA_A_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSA_A_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSA_A_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_B")
            {
                {"RSA_B_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSA_B_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSA_B_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSA_B_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_C")
            {
                {"RSA_C_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSA_C_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSA_C_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSA_C_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_D")
            {
                {"RSA_D_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSA_D_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSA_D_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSA_D_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_BA")
            {
                {"RSA_BA_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSA_BA_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSA_BA_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSA_BA_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_BB")
            {
                {"RSA_BB_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSA_BB_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSA_BB_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSA_BB_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_BC")
            {
                {"RSA_BC_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSA_BC_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSA_BC_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSA_BC_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_BD")
            {
                {"RSA_BD_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSA_BD_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSA_BD_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSA_BD_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_O")
            {
                {"RSA_O_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSA_O_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSA_O_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSA_O_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_TXL")
            {
                {"RSA_TXL_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSA_TXL_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSA_TXL_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSA_TXL_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_TXH")
            {
                {"RSA_TXH_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSA_TXH_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSA_TXH_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSA_TXH_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("RSA_CFG")
            {
                {"RSA_CFG_A",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSA_CFG_B",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSA_CFG_C",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSA_CFG_D",
                 PS0.ALU_OP_RSA | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //2 RRO ROTATE RIGHT
            instructionSet.Add(new InstructionGroup("RRO_A")
            {
                {"RRO_A_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RRO_A_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RRO_A_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RRO_A_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_B")
            {
                {"RRO_B_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RRO_B_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RRO_B_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RRO_B_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_C")
            {
                {"RRO_C_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RRO_C_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RRO_C_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RRO_C_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_D")
            {
                {"RRO_D_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RRO_D_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RRO_D_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RRO_D_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_BA")
            {
                {"RRO_BA_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RRO_BA_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RRO_BA_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RRO_BA_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_BB")
            {
                {"RRO_BB_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RRO_BB_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RRO_BB_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RRO_BB_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_BC")
            {
                {"RRO_BC_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RRO_BC_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RRO_BC_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RRO_BC_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_BD")
            {
                {"RRO_BD_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RRO_BD_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RRO_BD_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RRO_BD_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_O")
            {
                {"RRO_O_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RRO_O_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RRO_O_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RRO_O_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_TXL")
            {
                {"RRO_TXL_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RRO_TXL_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RRO_TXL_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RRO_TXL_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_TXH")
            {
                {"RRO_TXH_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RRO_TXH_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RRO_TXH_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RRO_TXH_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("RRO_CFG")
            {
                {"RRO_CFG_A",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RRO_CFG_B",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RRO_CFG_C",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RRO_CFG_D",
                 PS0.ALU_OP_RRO | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //3 RSH 1 >> SHIFT RIGHT
            instructionSet.Add(new InstructionGroup("RSH_A")
            {
                {"RSH_A_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSH_A_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSH_A_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"RSH_A_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_B")
            {
                {"RSH_B_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSH_B_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSH_B_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"RSH_B_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_C")
            {
                {"RSH_C_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSH_C_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSH_C_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"RSH_C_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_D")
            {
                {"RSH_D_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSH_D_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSH_D_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"RSH_D_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_BA")
            {
                {"RSH_BA_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSH_BA_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSH_BA_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"RSH_BA_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_BB")
            {
                {"RSH_BB_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSH_BB_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSH_BB_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"RSH_BB_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_BC")
            {
                {"RSH_BC_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSH_BC_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSH_BC_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"RSH_BC_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_BD")
            {
                {"RSH_BD_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSH_BD_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSH_BD_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"RSH_BD_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_O")
            {
                {"RSH_O_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSH_O_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSH_O_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"RSH_O_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_TXL")
            {
                {"RSH_TXL_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSH_TXL_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSH_TXL_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"RSH_TXL_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_TXH")
            {
                {"RSH_TXH_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSH_TXH_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSH_TXH_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"RSH_TXH_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("RSH_CFG")
            {
                {"RSH_CFG_A",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSH_CFG_B",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSH_CFG_C",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"RSH_CFG_D",
                 PS0.ALU_OP_RSH | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });


            /*
            0	FALSE	    abl
            1	NOR	        nor 
            2	A & !B	    lanr
                                    3	!B	        nr
            4	!A & B	    nlar
            5	!A	        not
            6	XOR	        xor
            7	NAND	    nand
            8	AND	        and
            9	XNOR	    xnor
                                    10	A	        lh
            11	A | !B	    lonr
                                    12	B	        rh
            13	!A | B	    nlor
            14	OR	        or
            15	TRUE	    abh        
            */

            //0	FALSE	    abl
            instructionSet.Add(new InstructionGroup("ABL")
            {
                {"ABL_A",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ABL_B",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ABL_C",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ABL_D",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_D
                },

                {"ABL_BA",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ABL_BB",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ABL_BC",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ABL_BD",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_BD
                },

                {"ABL_O",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ABL_TXL",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ABL_TXH",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ABL_CFG",
                 PS0.ALU_OP_ABL,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //1	NOR	        nor 
            instructionSet.Add(new InstructionGroup("NOR_A")
            {
                {"NOR_A_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NOR_A_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NOR_A_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NOR_A_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOR_A_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_B")
            {
                {"NOR_B_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOR_B_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_C")
            {
                {"NOR_C_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOR_C_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_D")
            {
                {"NOR_D_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOR_D_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_BA")
            {
                {"NOR_BA_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOR_BA_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_BB")
            {
                {"NOR_BB_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOR_BB_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_BC")
            {
                {"NOR_BC_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOR_BC_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_BD")
            {
                {"NOR_BD_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOR_BD_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_O")
            {
                {"NOR_O_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOR_O_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_TXL")
            {
                {"NOR_TXL_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOR_TXL_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_TXH")
            {
                {"NOR_TXH_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOR_TXH_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("NOR_CFG")
            {
                {"NOR_CFG_A_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_A_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_A_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_A_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_B_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_B_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_B_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_B_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_C_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_C_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_C_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_C_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_D_A",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_D_B",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_D_C",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOR_CFG_D_D",
                 PS0.ALU_OP_NOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //2	A & !B	    lanr
            instructionSet.Add(new InstructionGroup("LANR_A")
            {
                {"LANR_A_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LANR_A_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LANR_A_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LANR_A_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LANR_A_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_B")
            {
                {"LANR_B_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LANR_B_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_C")
            {
                {"LANR_C_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LANR_C_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_D")
            {
                {"LANR_D_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LANR_D_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_BA")
            {
                {"LANR_BA_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LANR_BA_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_BB")
            {
                {"LANR_BB_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LANR_BB_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_BC")
            {
                {"LANR_BC_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LANR_BC_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_BD")
            {
                {"LANR_BD_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LANR_BD_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_O")
            {
                {"LANR_O_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LANR_O_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_TXL")
            {
                {"LANR_TXL_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LANR_TXL_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_TXH")
            {
                {"LANR_TXH_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LANR_TXH_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LANR_CFG")
            {
                {"LANR_CFG_A_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_A_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_A_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_A_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_B_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_B_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_B_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_B_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_C_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_C_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_C_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_C_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_D_A",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_D_B",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_D_C",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LANR_CFG_D_D",
                 PS0.ALU_OP_LANR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //4	!A & B	    nlar
            instructionSet.Add(new InstructionGroup("NLAR_A")
            {
                {"NLAR_A_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLAR_A_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLAR_A_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLAR_A_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLAR_A_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_B")
            {
                {"NLAR_B_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLAR_B_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_C")
            {
                {"NLAR_C_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLAR_C_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_D")
            {
                {"NLAR_D_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLAR_D_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_BA")
            {
                {"NLAR_BA_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLAR_BA_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_BB")
            {
                {"NLAR_BB_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLAR_BB_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_BC")
            {
                {"NLAR_BC_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLAR_BC_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_BD")
            {
                {"NLAR_BD_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLAR_BD_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_O")
            {
                {"NLAR_O_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLAR_O_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_TXL")
            {
                {"NLAR_TXL_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLAR_TXL_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_TXH")
            {
                {"NLAR_TXH_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLAR_TXH_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("NLAR_CFG")
            {
                {"NLAR_CFG_A_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_A_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_A_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_A_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_B_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_B_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_B_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_B_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_C_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_C_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_C_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_C_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_D_A",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_D_B",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_D_C",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLAR_CFG_D_D",
                 PS0.ALU_OP_NLAR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //5	!A	        not
            instructionSet.Add(new InstructionGroup("NOT_A")
            {
                {"NOT_A_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOT_A_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOT_A_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NOT_A_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_B")
            {
                {"NOT_B_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOT_B_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOT_B_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NOT_B_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_C")
            {
                {"NOT_C_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOT_C_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOT_C_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NOT_C_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_D")
            {
                {"NOT_D_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOT_D_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOT_D_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NOT_D_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_BA")
            {
                {"NOT_BA_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOT_BA_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOT_BA_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NOT_BA_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_BB")
            {
                {"NOT_BB_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOT_BB_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOT_BB_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NOT_BB_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_BC")
            {
                {"NOT_BC_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOT_BC_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOT_BC_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NOT_BC_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_BD")
            {
                {"NOT_BD_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOT_BD_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOT_BD_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NOT_BD_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_O")
            {
                {"NOT_O_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOT_O_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOT_O_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NOT_O_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_TXL")
            {
                {"NOT_TXL_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOT_TXL_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOT_TXL_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NOT_TXL_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_TXH")
            {
                {"NOT_TXH_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOT_TXH_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOT_TXH_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NOT_TXH_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("NOT_CFG")
            {
                {"NOT_CFG_A",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOT_CFG_B",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOT_CFG_C",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NOT_CFG_D",
                 PS0.ALU_OP_NOT | PS0.ALU_SL_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //6	XOR	        xor
            instructionSet.Add(new InstructionGroup("XOR_A")
            {
                {"XOR_A_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XOR_A_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XOR_A_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XOR_A_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XOR_A_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_B")
            {
                {"XOR_B_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XOR_B_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_C")
            {
                {"XOR_C_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XOR_C_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_D")
            {
                {"XOR_D_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XOR_D_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_BA")
            {
                {"XOR_BA_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XOR_BA_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_BB")
            {
                {"XOR_BB_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XOR_BB_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_BC")
            {
                {"XOR_BC_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XOR_BC_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_BD")
            {
                {"XOR_BD_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XOR_BD_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_O")
            {
                {"XOR_O_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XOR_O_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_TXL")
            {
                {"XOR_TXL_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XOR_TXL_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_TXH")
            {
                {"XOR_TXH_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XOR_TXH_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("XOR_CFG")
            {
                {"XOR_CFG_A_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_A_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_A_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_A_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_B_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_B_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_B_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_B_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_C_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_C_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_C_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_C_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_D_A",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_D_B",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_D_C",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XOR_CFG_D_D",
                 PS0.ALU_OP_XOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //7	NAND	    nand
            instructionSet.Add(new InstructionGroup("NAND_A")
            {
                {"NAND_A_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NAND_A_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NAND_A_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NAND_A_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NAND_A_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_B")
            {
                {"NAND_B_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NAND_B_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_C")
            {
                {"NAND_C_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NAND_C_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_D")
            {
                {"NAND_D_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NAND_D_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_BA")
            {
                {"NAND_BA_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NAND_BA_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_BB")
            {
                {"NAND_BB_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NAND_BB_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_BC")
            {
                {"NAND_BC_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NAND_BC_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_BD")
            {
                {"NAND_BD_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NAND_BD_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_O")
            {
                {"NAND_O_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NAND_O_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_TXL")
            {
                {"NAND_TXL_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NAND_TXL_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_TXH")
            {
                {"NAND_TXH_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NAND_TXH_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("NAND_CFG")
            {
                {"NAND_CFG_A_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_A_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_A_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_A_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_B_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_B_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_B_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_B_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_C_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_C_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_C_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_C_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_D_A",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_D_B",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_D_C",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NAND_CFG_D_D",
                 PS0.ALU_OP_NAND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //8	AND	        and
            instructionSet.Add(new InstructionGroup("AND_A")
            {
                {"AND_A_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"AND_A_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"AND_A_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"AND_A_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"AND_A_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("AND_B")
            {
                {"AND_B_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"AND_B_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("AND_C")
            {
                {"AND_C_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"AND_C_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("AND_D")
            {
                {"AND_D_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"AND_D_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("AND_BA")
            {
                {"AND_BA_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"AND_BA_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("AND_BB")
            {
                {"AND_BB_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"AND_BB_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("AND_BC")
            {
                {"AND_BC_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"AND_BC_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("AND_BD")
            {
                {"AND_BD_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"AND_BD_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("AND_O")
            {
                {"AND_O_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"AND_O_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("AND_TXL")
            {
                {"AND_TXL_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"AND_TXL_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("AND_TXH")
            {
                {"AND_TXH_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"AND_TXH_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("AND_CFG")
            {
                {"AND_CFG_A_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_A_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_A_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_A_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_B_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_B_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_B_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_B_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_C_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_C_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_C_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_C_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_D_A",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_D_B",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_D_C",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"AND_CFG_D_D",
                 PS0.ALU_OP_AND | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //9	XNOR	    xnor
            instructionSet.Add(new InstructionGroup("XNOR_A")
            {
                {"XNOR_A_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XNOR_A_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XNOR_A_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"XNOR_A_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"XNOR_A_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_B")
            {
                {"XNOR_B_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"XNOR_B_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_C")
            {
                {"XNOR_C_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"XNOR_C_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_D")
            {
                {"XNOR_D_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"XNOR_D_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_BA")
            {
                {"XNOR_BA_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"XNOR_BA_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_BB")
            {
                {"XNOR_BB_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"XNOR_BB_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_BC")
            {
                {"XNOR_BC_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"XNOR_BC_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_BD")
            {
                {"XNOR_BD_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"XNOR_BD_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_O")
            {
                {"XNOR_O_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"XNOR_O_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_TXL")
            {
                {"XNOR_TXL_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"XNOR_TXL_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_TXH")
            {
                {"XNOR_TXH_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"XNOR_TXH_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("XNOR_CFG")
            {
                {"XNOR_CFG_A_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_A_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_A_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_A_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_B_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_B_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_B_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_B_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_C_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_C_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_C_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_C_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_D_A",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_D_B",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_D_C",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"XNOR_CFG_D_D",
                 PS0.ALU_OP_XNOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //11	A | !B	    lonr
            instructionSet.Add(new InstructionGroup("LONR_A")
            {
                {"LONR_A_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LONR_A_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LONR_A_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"LONR_A_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"LONR_A_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_B")
            {
                {"LONR_B_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"LONR_B_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_C")
            {
                {"LONR_C_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"LONR_C_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_D")
            {
                {"LONR_D_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"LONR_D_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_BA")
            {
                {"LONR_BA_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"LONR_BA_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_BB")
            {
                {"LONR_BB_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"LONR_BB_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_BC")
            {
                {"LONR_BC_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"LONR_BC_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_BD")
            {
                {"LONR_BD_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"LONR_BD_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_O")
            {
                {"LONR_O_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"LONR_O_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_TXL")
            {
                {"LONR_TXL_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"LONR_TXL_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_TXH")
            {
                {"LONR_TXH_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"LONR_TXH_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("LONR_CFG")
            {
                {"LONR_CFG_A_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_A_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_A_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_A_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_B_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_B_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_B_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_B_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_C_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_C_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_C_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_C_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_D_A",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_D_B",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_D_C",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"LONR_CFG_D_D",
                 PS0.ALU_OP_LONR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //13	!A | B	    nlor
            instructionSet.Add(new InstructionGroup("NLOR_A")
            {
                {"NLOR_A_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLOR_A_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLOR_A_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"NLOR_A_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"NLOR_A_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_B")
            {
                {"NLOR_B_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"NLOR_B_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_C")
            {
                {"NLOR_C_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"NLOR_C_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_D")
            {
                {"NLOR_D_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"NLOR_D_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_BA")
            {
                {"NLOR_BA_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"NLOR_BA_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_BB")
            {
                {"NLOR_BB_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"NLOR_BB_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_BC")
            {
                {"NLOR_BC_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"NLOR_BC_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_BD")
            {
                {"NLOR_BD_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"NLOR_BD_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_O")
            {
                {"NLOR_O_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"NLOR_O_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_TXL")
            {
                {"NLOR_TXL_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"NLOR_TXL_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_TXH")
            {
                {"NLOR_TXH_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"NLOR_TXH_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("NLOR_CFG")
            {
                {"NLOR_CFG_A_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_A_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_A_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_A_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_B_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_B_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_B_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_B_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_C_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_C_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_C_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_C_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_D_A",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_D_B",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_D_C",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"NLOR_CFG_D_D",
                 PS0.ALU_OP_NLOR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //14	OR	        or
            instructionSet.Add(new InstructionGroup("OR_A")
            {
                {"OR_A_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"OR_A_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"OR_A_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },

                {"OR_A_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"OR_A_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_A
                },
            });
            instructionSet.Add(new InstructionGroup("OR_B")
            {
                {"OR_B_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"OR_B_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_B
                },
            });
            instructionSet.Add(new InstructionGroup("OR_C")
            {
                {"OR_C_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"OR_C_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_C
                },
            });
            instructionSet.Add(new InstructionGroup("OR_D")
            {
                {"OR_D_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_D
                },
                {"OR_D_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_D
                },
            });
            instructionSet.Add(new InstructionGroup("OR_BA")
            {
                {"OR_BA_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"OR_BA_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
            });
            instructionSet.Add(new InstructionGroup("OR_BB")
            {
                {"OR_BB_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"OR_BB_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
            });
            instructionSet.Add(new InstructionGroup("OR_BC")
            {
                {"OR_BC_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"OR_BC_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
            });
            instructionSet.Add(new InstructionGroup("OR_BD")
            {
                {"OR_BD_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
                {"OR_BD_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_BD
                },
            });
            instructionSet.Add(new InstructionGroup("OR_O")
            {
                {"OR_O_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"OR_O_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_O
                },
            });
            instructionSet.Add(new InstructionGroup("OR_TXL")
            {
                {"OR_TXL_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"OR_TXL_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
            });
            instructionSet.Add(new InstructionGroup("OR_TXH")
            {
                {"OR_TXH_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"OR_TXH_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
            });
            instructionSet.Add(new InstructionGroup("OR_CFG")
            {
                {"OR_CFG_A_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_A_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_A_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_A_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_A | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_B_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_B_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_B_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_B_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_B | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_C_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_C_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_C_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_C_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_C | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_D_A",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_A,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_D_B",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_B,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_D_C",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_C,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
                {"OR_CFG_D_D",
                 PS0.ALU_OP_OR | PS0.ALU_SL_D | PS0.ALU_SR_D,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });
            //15	TRUE	    abh 
            instructionSet.Add(new InstructionGroup("ABH")
            {
                {"ABH_A",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_A
                },
                {"ABH_B",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_B
                },
                {"ABH_C",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_C
                },
                {"ABH_D",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_D
                },

                {"ABH_BA",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_BA
                },
                {"ABH_BB",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_BB
                },
                {"ABH_BC",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_BC
                },
                {"ABH_BD",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_BD
                },

                {"ABH_O",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_O
                },
                {"ABH_TXL",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_TXL
                },
                {"ABH_TXH",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_TXH
                },
                {"ABH_CFG",
                 PS0.ALU_OP_ABH,
                 PS1.R_OE_R | PS1.R_LD_CFG
                },
            });

            foreach(var grp in instructionSet)
            {
                foreach(var pi in grp)
                {
                    if((pi.Stage0 & (PS0.MB_INH | PS0.CR_LD)) == 0 && (pi.Stage0 & (PS0.AR_LD_PC)) != PS0.AR_LD_PC)
                    {
                        pi.Stage0 |= PS0.INT_EN;
                    }

                    /*
                        PC_INH = (1 << 0),
                        OP_DELAY = (1 << 1),
                        MEM_RW   = (1 << 2),
                        MEM_ACS = (1 << 3),
                    */
                    if ((pi.Stage1 & (PS1.PC_INH | PS1.OP_DELAY | PS1.MEM_ACS)) == 0)
                    {
                        pi.Stage1 |= PS1.INT_EN;
                    }
                }
            }


            InstructionSet = instructionSet;
        }
    }
}
