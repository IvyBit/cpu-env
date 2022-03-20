using assembler.parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assembler.preprocessor
{
    
    public class Preprocessor
    {       
        public Dictionary<string, string> StaticDefinitions { get; private set; } = new Dictionary<string, string>();


        public PreprocessorResult Parse(Stream sourceStream)
        {           

            using StreamReader reader = new StreamReader(sourceStream);

            return Parse(reader);


        }
        public PreprocessorResult Parse(string value)
        {
            using MemoryStream ms = new MemoryStream();
            using StreamWriter sw = new StreamWriter(ms) { AutoFlush = true };

            sw.Write(value);
            ms.Position = 0;

            using StreamReader reader = new StreamReader(ms);

           return Parse(reader);
        }

        public PreprocessorResult Parse(StreamReader reader)
        {
            var lines = SplitLines(reader);
            if (!lines.Any())
            {
                return new PreprocessorResult(false);
            }

            var textElements = SplitParserBlocks(lines);
            if (!textElements.Any())
            {
                return new PreprocessorResult(false);
            }

            Dictionary<string, string> definitions;
            if (!TryApplyDefinitions(textElements, out definitions))
            {
                return new PreprocessorResult(false);
            }

            return new PreprocessorResult(true, textElements, definitions);
        }


        public List<string> ExtractIncludes(Stream sourceStream)
        {

            using StreamReader reader = new StreamReader(sourceStream);

            return ExtractIncludes(reader);


        }
        public List<string> ExtractIncludes(string value)
        {
            using MemoryStream ms = new MemoryStream();
            using StreamWriter sw = new StreamWriter(ms) { AutoFlush = true };

            sw.Write(value);
            ms.Position = 0;

            using StreamReader reader = new StreamReader(ms);

            return ExtractIncludes(reader);
        }

        public List<string> ExtractIncludes(StreamReader reader)
        {
            var files = new List<string>();
            var lines = SplitLines(reader);
            if (!lines.Any())
            {
                Console.Write("file empty...");
            }

            var elements = SplitParserBlocks(lines);
            if (!elements.Any())
            {
                Console.Write("no elements...");
            }

            foreach (var element in elements)
            {
                //^\s{0,}#include\s+""(?<file>[^""]+)""
                var match = Regex.Match(element.Text, @"^\s{0,}#include\s+""(?<file>[^""]+)""");
                if (match.Success)
                {
                    var file = match.Groups["file"].Captures[0].Value;
                    
                    files.Add(file);
                }
             }

            return files;
        }

        private List<string> SplitLines(StreamReader reader)
        {
            var lines = new List<string>(); 
            string? line = null; 
            while((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            return lines;
        }

        private List<TextElement> SplitParserBlocks(IEnumerable<string> lines)
        {
            var textElements = new List<TextElement>();
            var stringBlock = string.Empty;
            var lineNumber = 0;
            var blockNumber = 0;

            foreach (var line in lines)
            {
                var match = Regex.Match(line, @"(?<value>^.*)\\$");
                if (match.Success)
                {
                    stringBlock += match.Groups["value"].Captures[0].Value;
                    blockNumber++;
                }
                else 
                {
                    stringBlock += line;
                    var text = StripComment(stringBlock);
                    var comment = stringBlock.Substring(text.Length).Trim();

                    if (!string.IsNullOrEmpty(text))
                    {
                        textElements.Add(new TextElement
                        {
                            Text = text.Trim(),
                            Comment = comment.Trim(),
                            LineIndex = lineNumber - blockNumber,
                            LineCount = blockNumber + 1,
                        });
                    }
                    stringBlock = string.Empty;
                    blockNumber = 0;
                }
                lineNumber++;
            }
            return textElements;
        }
        private bool TryApplyDefinitions(IEnumerable<TextElement> elements, out Dictionary<string, string> definitions)
        {
            definitions = new Dictionary<string, string>(StaticDefinitions);
            foreach (var element in elements)
            {
                var match = Regex.Match(element.Text, @"^\s{0,}#define\s+(?<name>[^\s]+)\s+(?<value>.*)");
                if (match.Success)
                {
                    element.IsPreprocessorElement = true;
                    var name = match.Groups["name"].Captures[0].Value;
                    var value = match.Groups["value"].Captures[0].Value;
                    if (!definitions.ContainsKey(name))
                    {
                        element.Text = string.Empty;
                        definitions.Add(name, value);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    foreach (var definition in definitions)
                    {
                        ReplaceNonQuotedString(element, definition.Key, definition.Value);
                    }
                }
            }

            return true;
        }

        private void ReplaceNonQuotedString(TextElement element, string oldValue, string newValue)
        {
            bool quoted = false;

            var chrBuffer = new List<char>();
            var stringBuffer = new Dictionary<string, bool>();

            var backtrack = (int i) => i > 0 ? element.Text[i - 1] : '\0';
            for (int i = 0; i < element.Text.Length; i++)
            {

                char chr = element.Text[i];

                if (!quoted && chr == '\'' && backtrack(i) != '\\')
                {
                    stringBuffer.Add(new string(chrBuffer.ToArray()), false);
                    chrBuffer.Clear();
                    chrBuffer.Add(chr);
                    quoted = true;
                }
                else if (quoted && chr == '\'' && backtrack(i) != '\\')
                {
                    chrBuffer.Add(chr);
                    stringBuffer.Add(new string(chrBuffer.ToArray()), true);
                    chrBuffer.Clear();
                    quoted = false;
                }
                else
                {
                    chrBuffer.Add(chr);
                }

            }
            stringBuffer.Add(new string(chrBuffer.ToArray()), false);

            var resultBuffer = new List<string>();
            foreach (var section in stringBuffer)
            {
                if (!section.Value)
                {
                    if (section.Key.Contains(oldValue))
                    {
                        resultBuffer.Add(section.Key.Replace(oldValue, newValue));
                        element.IsPreprocessorElement = true;
                    }
                    else
                    {
                        resultBuffer.Add(section.Key);
                    }
                }
                else
                {
                    resultBuffer.Add(section.Key);
                }
            }
            element.Text = string.Concat(resultBuffer);
        }

        private string StripComment(string input)
        {
            var expression = new Stack<char>();
            var backtrack = () => expression.Any() ? expression.Peek() : '\0';
            bool quoted = false;
            for (int i = 0; i < input.Length; i++)
            {
                char chr = input[i];

                if (!quoted && chr == '\'')
                {
                    quoted = true;
                    expression.Push(chr);
                    continue;
                }

                if (quoted && chr == '\'' && backtrack() != '\\')
                {
                    quoted = false;
                    expression.Push(chr);
                    continue;
                }

                if (!quoted && chr == ';')
                {
                    break;
                }

                expression.Push(chr);
            }
            //EFFICIENCY +10 !!
            return new string(expression.Reverse().ToArray());
        }


    }
}
