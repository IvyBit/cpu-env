namespace ismap
{


    [Flags]
    public enum PS0 : UInt64
    {
        NONE = 0,
        MB_INH = (1 << 0),
        CR_LD = (1 << 1),
        RET_LD = (1 << 2),
        AR_CU  = (1 << 3),
        AR_LC  = (1 << 4),
        AR_LC0 = (1 << 5),
        AR_LC1 = (1 << 6),
        AR_LC2 = (1 << 7),
        AR_LC3 = (1 << 8),
        AR_OE0 = (1 << 9),
        AR_OE1 = (1 << 10),
        AR_OE2 = (1 << 11),
        AR_OE3 = (1 << 12),

        JP_CON0 = (1 << 13),
        JP_CON1 = (1 << 14),
        JP_CON2 = (1 << 15),
        JP_CON3 = (1 << 16),

        ALU_EN = (1 << 17),
        ALU_OP0 = (1 << 18),
        ALU_OP1 = (1 << 19),
        ALU_OP2 = (1 << 20),
        ALU_OP3 = (1 << 21),
        ALU_OP4 = (1 << 22),
        ALU_AS0 = (1 << 23),
        ALU_AS1 = (1 << 24),
        ALU_BS0 = (1 << 25),
        ALU_BS1 = (1 << 26),
        //X = (1 << 27),
        //X = (1 << 28),
        //X = (1 << 29),
        //X = (1 << 30),
        INT_EN = (1UL << 31),


        //ADDRESS REGISTER COUNT DOWN SELECT
        AR_CU_A = AR_LC | AR_LC0,
        AR_CU_B = AR_LC | AR_LC1,
        AR_CU_C = AR_LC | AR_LC1 | AR_LC0,
        AR_CU_D = AR_LC | AR_LC2,
        //AR_CU_X = AR_LC | AR_LC2 | AR_LC0,
        //AR_CU_X = AR_LC | AR_LC2 | AR_LC1,
        //AR_CU_X = AR_LC | AR_LC2 | AR_LC1 | AR_LC0,
        //AR_CU_X = AR_LC | AR_LC3,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC0,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC1,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC1 | AR_LC0,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC2,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC2 | AR_LC0,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC2 | AR_LC1,
        //AR_CU_X = AR_LC | AR_LC3 | AR_LC2 | AR_LC1 | AR_LC0,

        //ADDRESS REGISTER COUNT UP SELECT
        AR_CD_A    = AR_LC | AR_CU | AR_LC0,
        AR_CD_B    = AR_LC | AR_CU | AR_LC1,
        AR_CD_C    = AR_LC | AR_CU | AR_LC1 | AR_LC0,
        AR_CD_D    = AR_LC | AR_CU | AR_LC2,
        AR_CD_SP   = AR_LC | AR_CU | AR_LC2 | AR_LC0,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC2 | AR_LC1,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC2 | AR_LC1 | AR_LC0,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3 | AR_LC0,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3 | AR_LC1,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3 | AR_LC1 | AR_LC0,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3 | AR_LC2,
        //AR_CD_X    = AR_LC | AR_CU | AR_LC3 | AR_LC2 | AR_LC0,
        //AR_CD_X   = AR_LC | AR_CU | AR_LC3 | AR_LC2 | AR_LC1,
        //AR_CD_X   = AR_LC | AR_CU | AR_LC3 | AR_LC2 | AR_LC1 | AR_LC0,


        //ADDRESS REGISTER LOAD SELECT
        AR_LD_ARA = AR_LC0,
        AR_LD_ARB = AR_LC1,
        AR_LD_ARC = AR_LC1 | AR_LC0,
        AR_LD_ARD = AR_LC2,
        AR_LD_SP  = AR_LC2 | AR_LC0,
        AR_LD_ISSR = AR_LC2 | AR_LC1,
        AR_LD_PC = AR_LC2 | AR_LC1 | AR_LC0,
        AR_LD_ABA = AR_LC3,
        AR_LD_ABB = AR_LC3 | AR_LC0,
        AR_LD_ABC = AR_LC3 | AR_LC1,
        AR_LD_ABD = AR_LC3 | AR_LC1 | AR_LC0,
        //AR_LD_X = AR_LC3 | AR_LC2,
        //AR_LD_X = AR_LC3 | AR_LC2 | AR_LC0,
        //AR_LD_X = AR_LC3 | AR_LC2 | AR_LC1,
        AR_LD_ATX = AR_LC3 | AR_LC2 | AR_LC1 | AR_LC0,


        //ADDRESS REGISTER OUTPUT SELECT
        AR_OE_ARA = AR_OE0,
        AR_OE_ARB = AR_OE1,
        AR_OE_ARC = AR_OE1 | AR_OE0,
        AR_OE_ARD = AR_OE2,
        AR_OE_SP  = AR_OE2 | AR_OE0,
        AR_OE_RET = AR_OE2 | AR_OE1,
        AR_OE_ISSR = AR_OE2 | AR_OE1 | AR_OE0,
        AR_OE_ABA = AR_OE3,
        AR_OE_ABB = AR_OE3 | AR_OE0,
        AR_OE_ABC = AR_OE3 | AR_OE1,
        AR_OE_ABD = AR_OE3 | AR_OE1 | AR_OE0,
        //AR_OE_X = AR_OE3 | AR_OE2,
        //AR_OE_X = AR_OE3 | AR_OE2 | AR_OE0,
        AR_OE_APC = AR_OE3 | AR_OE2 | AR_OE1,
        AR_OE_ATX = AR_OE3 | AR_OE2 | AR_OE1 | AR_OE0,

        //JUMP CONDITION SELECT
        JP_ON_N = 0,
        JP_ON_CARRY     = JP_CON0,
        JP_ON_ODD       = JP_CON1,
        JP_ON_SIGNED    = JP_CON1 | JP_CON0,
        JP_ON_ZERO      = JP_CON2,
        JP_ON_EQUAL     = JP_CON2 | JP_CON0,

        JP_ON_NOTCARRY   = JP_CON2 | JP_CON1,
        JP_ON_NOTODD    = JP_CON2 | JP_CON1 | JP_CON0,
        JP_ON_NOTSIGNED = JP_CON3,
        JP_ON_NOTZERO   = JP_CON3 | JP_CON0,
        JP_ON_NOTEQUAL  = JP_CON3 | JP_CON1,
        //JP_ON_B         = JP_CON3 | JP_CON1 | JP_CON0,
        //JP_ON_C         = JP_CON3 | JP_CON2,
        //JP_ON_D         = JP_CON3 | JP_CON2 | JP_CON0,
        //JP_ON_E         = JP_CON3 | JP_CON2 | JP_CON1,
        //JP_ON_F         = JP_CON3 | JP_CON2 | JP_CON1 | JP_CON0,

        /*
        0	FALSE	    abl
        1	NOR	        nor 
        2	A & !B	    lanr
        3	!B	        nr
        4	!A & B	    nlar
        5	!A	        nl
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
        //ALU OPERATION SELECT
        //ALU_OP_N  = 0,
        ALU_OP_ABL  = ALU_EN,                                                     //0 0000
        ALU_OP_NOR  = ALU_EN | ALU_OP0,                                           //0 0001
        ALU_OP_LANR = ALU_EN | ALU_OP1,                                           //0 0010
        //ALU_OP_NR   = ALU_EN | ALU_OP1 | ALU_OP0,                                 //0 0011
        ALU_OP_NLAR = ALU_EN | ALU_OP2,                                           //0 0100
        ALU_OP_NOT   = ALU_EN | ALU_OP2 | ALU_OP0,                                //0 0101
        ALU_OP_XOR  = ALU_EN | ALU_OP2 | ALU_OP1,                                 //0 0110
        ALU_OP_NAND = ALU_EN | ALU_OP2 | ALU_OP1 | ALU_OP0,                       //0 0111
        ALU_OP_AND  = ALU_EN | ALU_OP3,                                           //0 1000
        ALU_OP_XNOR = ALU_EN | ALU_OP3 | ALU_OP0,                                 //0 1001
        //ALU_OP_LH   = ALU_EN | ALU_OP3 | ALU_OP1,                                 //0 1010
        ALU_OP_LONR = ALU_EN | ALU_OP3 | ALU_OP1 | ALU_OP0,                       //0 1011
        ALU_OP_RH   = ALU_EN | ALU_OP3 | ALU_OP2,                                 //0 1100
        ALU_OP_NLOR = ALU_EN | ALU_OP3 | ALU_OP2 | ALU_OP0,                       //0 1101
        ALU_OP_OR   = ALU_EN | ALU_OP3 | ALU_OP2 | ALU_OP1,                       //0 1110
        ALU_OP_ABH  = ALU_EN | ALU_OP3 | ALU_OP2 | ALU_OP1 | ALU_OP0,             //0 1111
        /*
        0 LSL LOGICAL SHIFT LEFT
        1 LSA ARITHMETIC SHIFT LEFT
        2 LRO ROTATE LEFT
        3 LSH SHIFT LEFT << 1
         */
        ALU_OP_LSL = ALU_EN | ALU_OP4,                                           //1 0000
        ALU_OP_LSA = ALU_EN | ALU_OP4 | ALU_OP0,                                 //1 0001
        ALU_OP_LRO = ALU_EN | ALU_OP4 | ALU_OP1,                                 //1 0010
        ALU_OP_LSH = ALU_EN | ALU_OP4 | ALU_OP1 | ALU_OP0,                       //1 0011        
        /*
        0 RSL LOGICAL SHIFT RIGHT
        1 RSA ARITHMETIC SHIFT RIGHT
        2 RRO ROTATE RIGHT
        3 RSH 1 >> SHIFT RIGHT
         */
        ALU_OP_RSL = ALU_EN | ALU_OP4 | ALU_OP2,                                 //1 0100
        ALU_OP_RSA = ALU_EN | ALU_OP4 | ALU_OP2 | ALU_OP0,                       //1 0101
        ALU_OP_RRO = ALU_EN | ALU_OP4 | ALU_OP2 | ALU_OP1,                       //1 0110
        ALU_OP_RSH = ALU_EN | ALU_OP4 | ALU_OP2 | ALU_OP1 | ALU_OP0,             //1 0111

        /*
        0 ADD: (R + R + 0)
        1 SUB: (R + ~R + 1)
        2 INC: (R + L + 1)
        3 DEC: (R + H + 0)
        4 ADC: (R + R + ?CARRY)
        5 SBC: (R + ~R + ?CARRY)
        */
        ALU_OP_ADD = ALU_EN | ALU_OP4 | ALU_OP3,                                 //1 1000
        ALU_OP_SUB = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP0,                       //1 1001
        ALU_OP_INC = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP1,                       //1 1010
        ALU_OP_DEC = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP1 | ALU_OP0,             //1 1011
        ALU_OP_ADC = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP2,                       //1 1100
        ALU_OP_SBC = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP2 | ALU_OP0,             //1 1101
        //ALU_OP_1E = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP2 | ALU_OP1,              //1 1110
        //ALU_OP_1F = ALU_EN | ALU_OP4 | ALU_OP3 | ALU_OP2 | ALU_OP1 | ALU_OP0,    //1 1111

        //ALU LEFT HAND SELECT
        ALU_SL_A = 0,
        ALU_SL_B = ALU_AS0,
        ALU_SL_C = ALU_AS1,
        ALU_SL_D = ALU_AS1 | ALU_AS0,

        //ALU RIGHT HAND SELECT
        ALU_SR_A = 0,
        ALU_SR_B = ALU_BS0,
        ALU_SR_C = ALU_BS1,
        ALU_SR_D = ALU_BS1 | ALU_BS0,
    }


    [Flags]
    public enum PS1 : UInt64
    {
        NONE = 0,
        PC_INH = (1 << 0),
        OP_DELAY = (1 << 1),
        MEM_RW   = (1 << 2),
        MEM_ACS = (1 << 3),
        R_LD0 = (1 << 4),
        R_LD1 = (1 << 5),
        R_LD2 = (1 << 6),
        R_LD3 = (1 << 7),
        R_OE0 = (1 << 8),
        R_OE1 = (1 << 9),
        R_OE2 = (1 << 10),
        R_OE3 = (1 << 11),
        SP_CU = (1 << 12),
        //X     = (1 << 13),
        //X     = (1 << 14),
        INT_EN = (1 << 15),
        //X     = (1 << 16),
        //X     = (1 << 17),
        //X     = (1 << 18),
        //X     = (1 << 19),
        //X     = (1 << 20),
        //X     = (1 << 21),
        //X     = (1 << 22),
        //X     = (1 << 23),

        //MEMORY READ WRITE
        MEM_READ = MEM_ACS,
        MEM_WRITE = MEM_ACS | MEM_RW,

        //REGISTER OUTPUT SELECT
        R_OE_A = R_OE0,
        R_OE_B = R_OE1,
        R_OE_C = R_OE1 | R_OE0,
        R_OE_D = R_OE2,
        R_OE_BA = R_OE2 | R_OE0,
        R_OE_BB = R_OE2 | R_OE1,
        R_OE_BC = R_OE2 | R_OE1 | R_OE0,
        R_OE_BD = R_OE3,
        R_OE_S = R_OE3 | R_OE0,
        R_OE_R = R_OE3 | R_OE1,
        R_OE_CFG = R_OE3 | R_OE1 | R_OE0,
        R_OE_I = R_OE3 | R_OE2,
        R_OE_CR = R_OE3 | R_OE2 | R_OE0,
        R_OE_TXL = R_OE3 | R_OE2 | R_OE1,
        R_OE_TXH = R_OE3 | R_OE2 | R_OE1 | R_OE0,

        //REGISTER LOAD SELECT
        R_LD_A = R_LD0,
        R_LD_B = R_LD1,
        R_LD_C = R_LD1 | R_LD0,
        R_LD_D = R_LD2,
        R_LD_BA = R_LD2 | R_LD0,
        R_LD_BB = R_LD2 | R_LD1,
        R_LD_BC = R_LD2 | R_LD1 | R_LD0,
        R_LD_BD = R_LD3,
        R_LD_S = R_LD3 | R_LD0,
        //R_LD_X = R_LD3 | R_LD1,
        R_LD_CFG = R_LD3 | R_LD1 | R_LD0,
        R_LD_O = R_LD3 | R_LD2,
        //R_LD_X = R_LD3 | R_LD2 | R_LD0,
        R_LD_TXL = R_LD3 | R_LD2 | R_LD1,
        R_LD_TXH = R_LD3 | R_LD2 | R_LD1 | R_LD0,

    }

}



