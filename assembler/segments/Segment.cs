using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.segments
{
    public class Segment
    {
        public string Name { get; set; }
        public List<TextElement> Elements { get; private set; }

        public Segment(string name, IEnumerable<TextElement> elements)
        {
            Name = name;
            Elements = elements.ToList();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
