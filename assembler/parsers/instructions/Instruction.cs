using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.instructions
{
    //public enum Mnemonic
    //{
    //    INVALID,
    //    NOP,
    //    LDI,
    //}

    public enum OperandType
    {
        INVALID,
        CONST,
        REGISTER,
        ADDRESS,
        EXPRESSION,
    }



    public class Instruction : CodeElement
    {

        public string Text { get; set; } = string.Empty;
        public string Mnemonic { get; set; } = String.Empty;
        public Operand[] Operands { get; set; } = new Operand[0];

        public Instruction() : base(CodeElementType.INSTRUCTION)
        {
        }

        public override string ToString()
        {

            return $@"{Mnemonic} {string.Join<Operand>(',', Operands)}";
        }

    }
}
