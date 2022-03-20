using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assembler.parsers.labels
{

    public class LabelParser : Parser
    {
        public override LabelParserResult Parse(TextElement textElement)
        {
            var label = new Label();
            if(TryParseLabelName(textElement, ref label))
            {
                return new LabelParserResult(true, label);
            }
            return new LabelParserResult(false, label); ;        
        }



        protected virtual bool TryParseLabelName(TextElement element, ref Label label)
        {
            var match = Regex.Match(element.Text, @"^\s{0,}(?<name>_\w+[\w-_]+):(\s+$|$)");
            if (match.Success)
            {
                var name = match.Groups["name"].Captures[0].Value;
                if(name.Length >= 3)
                {
                    label.Name = name;
                    return true;
                }
            }
            return false;
        }
    }
}
