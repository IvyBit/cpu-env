using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.preprocessor
{
    public class TextElement
    {
        public string Text { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public int LineIndex { get; set; } = 0;
        public int LineCount { get; set; } = 0;

        public bool IsPreprocessorElement { get; set; } = false;
        public int Count => Text.Length;

        public override string ToString()
        {
            var prefix = $@"[{LineIndex}:{LineCount}]";
            var padding = new string(' ', 10 - prefix.Length);
            return $@"{prefix}{padding} ""{Text}"" {Comment}";
        }
    }
}
