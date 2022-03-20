using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.labels
{
    public class LabelParserResult : ParserResult
    {
        public Label Label { get; }

        public LabelParserResult(bool success, Label label) : base(success)
        {
            Label = label;
        }
    }
}
