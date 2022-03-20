using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers
{
    public enum CodeElementType
    {
        INVALID,
        INSTRUCTION,
        LABEL
    }
    public class CodeElement
    {
        public int Index { get; set; } = 0;
        public int Width { get; set; } = 0;

        public CodeElementType ElementType { get; }

        public CodeElement(CodeElementType elementType)
        {
            ElementType = elementType;
        }

    }
}
