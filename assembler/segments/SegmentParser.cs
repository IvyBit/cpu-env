using assembler.parsers;
using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assembler.segments
{




    public class SegmentParser
    {
        public List<string> AllowedSegments { get; private set; }
        public List<string> RequiredSegments { get; private set; }

        public SegmentParser()
        {
            AllowedSegments = new List<string>() { ".start", ".data", ".bss", ".text" };
            RequiredSegments = new List<string>() { ".text" };
        }

        public SegmentParserResult Parse(IEnumerable<TextElement> textElements)
        {
            var segments = new List<Segment>();
            var segment = new List<TextElement>();
            var segmentName = ".start";

            int segmentCount = 0;
            foreach (var element in textElements)
            {
                var match = Regex.Match(element.Text, @"^\s{0,}segment(?<name>.*)");
                if (match.Success)
                {
                    segments.Add(new Segment(segmentName, segment));
                    segment = new List<TextElement>();

                    var name = match.Groups["name"].Captures[0]?.Value;
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        name = $"unknown_{segmentCount}";
                    }

                    segmentName = name.Trim();
                    segmentCount++;
                }
                else
                {
                    segment.Add(element);
                }
            }
            segments.Add(new Segment(segmentName, segment));

            if (segments.Select(s => s.Name).Intersect(RequiredSegments).Count() != RequiredSegments.Count)
            {
                return new SegmentParserResult(false, segments);
            }

            if (segments.Select(s => s.Name).Except(AllowedSegments).Count() > 0)
            {
                return new SegmentParserResult(false, segments);
            }

            return new SegmentParserResult(true, segments);

        }
    }
}
