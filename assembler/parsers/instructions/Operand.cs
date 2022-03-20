using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.instructions
{
    public class Operand
    {
        public string Text { get; set; } = string.Empty;
        public OperandType OperandType { get; set; } = OperandType.INVALID;
        public string Expression { get; set; } = string.Empty;

        public override string ToString()
        {
            return @$"({OperandType}: {Text})";
        }
    }
}
