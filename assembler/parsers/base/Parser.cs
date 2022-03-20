using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers
{
    public abstract class Parser
    {
        public abstract ParserResult Parse(TextElement textElement);
    }
}
