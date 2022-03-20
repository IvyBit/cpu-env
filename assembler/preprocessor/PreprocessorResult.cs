using assembler.parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.preprocessor
{
    public class PreprocessorResult : ParserResult
    {
        public List<TextElement> TextElements { get; private set; }

        private Dictionary<string, string> _Definitions;
        public IReadOnlyDictionary<string, string> Definitions => _Definitions;

        public PreprocessorResult(bool success) : base(success)
        {
            _Definitions = new Dictionary<string, string>();
            TextElements = new List<TextElement>();
        }

        public PreprocessorResult(bool success, IEnumerable<TextElement> textElements, Dictionary<string, string> definitions) : base(success)
        {
            TextElements = textElements.ToList();
            _Definitions = definitions;
        }

        public string ToTransformedString()
        {
            var sb = new StringBuilder();
            foreach(var textElement in TextElements)
            {
                sb.AppendLine(textElement.Text);
            }
            return sb.ToString();
        }
    }
}
