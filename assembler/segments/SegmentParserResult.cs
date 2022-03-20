using assembler.parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.segments
{
    public class SegmentParserResult : ParserResult
    {
        public List<Segment> Segments { get; }

        public SegmentParserResult(bool success) : base(success)
        {
            Segments = new List<Segment>();
        }
        public SegmentParserResult(bool success, List<Segment> segments) : base(success)
        {
            Segments = segments;
        }
    }
}
