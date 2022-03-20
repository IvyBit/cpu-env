using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.instructions
{
    public class InstructionParserResult : ParserResult
    {
        public Instruction Instruction { get; }

        public InstructionParserResult(bool success, Instruction instruction)
        : base(success)
        {
            Instruction = instruction;
        }
    }
}
