using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.variables
{
    public class VariableParserResult : ParserResult
    {
        public Variable Variable { get; }

        public VariableParserResult(bool success, Variable variable)
        : base(success)
        {
            Variable = variable;
        }
    }
}
