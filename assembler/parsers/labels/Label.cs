using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.labels
{
    public class Label : CodeElement
    {
        public string Name { get; set; } = String.Empty;
        public Label() : base(CodeElementType.LABEL)
        { }

        public override string ToString()
        {
            return $@"{Name}";
        }
    }
}
