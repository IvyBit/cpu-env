using assembler.preprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assembler.parsers.variables
{
    public class VariableParser : Parser
    {
        public override VariableParserResult Parse(TextElement textElement)
        {
            var variable = new Variable();
            if (!TryParseVariableType(textElement.Text, ref variable))
            {
                return new VariableParserResult(false, variable);
            }
            if (!TryParseVariableName(textElement.Text, ref variable))
            {
                return new VariableParserResult(false, variable);
            }
            if (!TryParseVariableValueType(textElement.Text, ref variable))
            {
                return new VariableParserResult(false, variable);
            }
            if (!TryParseVariableData(textElement.Text, ref variable))
            {
                return new VariableParserResult(false, variable);
            }

            return new VariableParserResult(true, variable);
        }



        protected virtual bool TryParseVariableType(string value, ref Variable variable)
        {
            var elements = value.Split(new char[] { ' ', '\t' },
                                       StringSplitOptions.RemoveEmptyEntries |
                                       StringSplitOptions.TrimEntries);
            DataType valueType;

            if (elements.Length > 0 &&
               Enum.TryParse(elements[0].ToUpper(), out valueType))
            {
                variable.dataType = valueType;
                return true;
            }
            else
            {
                variable.dataType = DataType.INVALID;
                return false;
            }
        }

        protected virtual bool TryParseVariableName(string value, ref Variable variable)
        {
            var elements = value.Split(new char[] { ' ', '\t' },
                               StringSplitOptions.RemoveEmptyEntries |
                               StringSplitOptions.TrimEntries);

            if (elements.Length > 1 && !string.IsNullOrWhiteSpace(elements[1]))
            {
                variable.name = elements[1];
                return true;
            }
            else
            {
                variable.name = string.Empty;
                return false;
            }
        }

        protected virtual bool TryParseValueType(string value, ref Variable variable)
        {
            var match = Regex.Match(value, @"^'.*'$");
            if (match.Success)
            {
                variable.valueType = ValueType.STR;
                return true;
            }

            match = Regex.Match(value, @"^{.*}$");
            if (match.Success)
            {
                variable.valueType = ValueType.ARR;
                return true;
            }

            match = Regex.Match(value, @"^(0x[a-fA-F0-9]+)|(0b[01]+)|([1-9][0-9]{0,})(\s{0,}$)");
            if (match.Success)
            {
                variable.valueType = ValueType.VAL;
                return true;
            }

            variable.valueType = ValueType.INVALID;
            return false;
        }

        protected virtual bool TryParseVariableValueType(string value, ref Variable variable)
        {
            var match = Regex.Match(value, @"^\s{0,}\w+\s+\w+\s+(?<value>.+)");

            if (match.Success)
            {
                var variableValue = match.Groups["value"].Captures[0].Value;

                if (TryParseValueType(variableValue, ref variable))
                {
                    switch (variable.valueType)
                    {
                        case ValueType.VAL:
                            break;
                        case ValueType.ARR:
                            break;
                        case ValueType.STR:
                            break;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual bool TryParseVariableData(string value, ref Variable variable)
        {
            var match = Regex.Match(value, @"^\s{0,}\w+\s{0,}\w+\s{0,}(?<value>.*)");
            if (match.Success)
            {
                string stringValue = match.Groups["value"].Captures[0].Value.Trim();
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    variable.stringData = stringValue;
                    UInt64[] data;
                    switch (variable.valueType)
                    {
                        case ValueType.VAL:
                            if (TryParseVariableValue(stringValue, variable.dataType, out data))
                            {
                                variable.data = PackValueData(data, variable.dataType);
                                return true;
                            }
                            break;
                        case ValueType.ARR:
                            if (TryParseVariableArray(stringValue, variable.dataType, out data))
                            {
                                variable.data = PackValueData(data, variable.dataType);
                                return true;
                            }
                            break;
                        case ValueType.STR:
                            if (TryParseVariableString(stringValue, variable.dataType, out data))
                            {
                                variable.data = PackValueData(data, variable.dataType);
                                return true;
                            }
                            break;
                    }


                }
            }

            variable.data = new UInt16[0];
            return false;
        }

        protected virtual bool TryParseVariableValue(string value, DataType dataType, out UInt64[] data)
        {
            UInt64 dataValue = 0;
            bool success = false;
            Match? match = null;

            //HEX
            if (!success)
            {
                match = Regex.Match(value.ToLower(), @"0x(?<value>[0-9a-f]+)$");
                if (!success && match.Success)
                {
                    dataValue = Convert.ToUInt64(match.Groups["value"].Captures[0].Value, 16);
                    success = true;
                }
            }
            //BIN
            if (!success)
            {
                match = Regex.Match(value.ToLower(), @"0b(?<value>[01]+)$");
                if (match.Success)
                {
                    dataValue = Convert.ToUInt64(match.Groups["value"].Captures[0].Value, 2);
                    success = true;
                }
            }
            //DEC
            if (!success)
            {
                match = Regex.Match(value.ToLower(), @"^(?<value>[0-9]+)$");
                if (match.Success)
                {
                    dataValue = Convert.ToUInt64(match.Groups["value"].Captures[0].Value, 10);
                    success = true;
                }
            }

            if (success)
            {
                data = new UInt64[] { dataValue };
                return true;
            }

            data = new UInt64[0];
            return false;
        }

        protected virtual bool TryParseVariableArray(string value, DataType dataType, out UInt64[] data)
        {
            var values = SplitValueArray(value);
            if (values.Any())
            {
                var arrayValues = new List<UInt64>();
                foreach (var arrayValue in values)
                {
                    UInt64[] arrayData;
                    if (TryParseVariableValue(arrayValue, dataType, out arrayData))
                    {
                        arrayValues.Add(arrayData[0]);
                    }
                    else
                    {
                        data = new UInt64[0];
                        return false;
                    }
                }
                data = arrayValues.ToArray();
                return true;
            }

            data = new UInt64[0];
            return false;
        }

        protected virtual bool TryParseVariableString(string value, DataType dataType, out UInt64[] data)
        {
            var chrMap = new Dictionary<char, char>
            {
                { '0', '\0' },
                { 'a', '\a' },
                { 'b', '\b' },
                { 'f', '\f' },
                { 'n', '\n' },
                { 'r', '\r' },
                { 't', '\t' },
                { 'v', '\v' }
            };

            bool quoted = false;
            var chrStack = new Stack<UInt64>();
            var backtrack = () => chrStack.Any() ? chrStack.Peek() : '\0';

            for (int i = 0; i < value.Length; i++)
            {
                char chr = value[i];
                if (char.IsAscii(chr))
                {
                    if (!quoted && chr == '\'')
                    {
                        quoted = true;
                        continue;
                    }

                    if (quoted && chr == '\'' && backtrack() != '\\')
                    {
                        quoted = false;
                        break;
                    }

                    if (quoted && chr == '\'' && backtrack() == '\\')
                    {
                        chrStack.Pop();
                        chrStack.Push(chr);
                        continue;
                    }

                    if (chrMap.Keys.Contains(chr) && backtrack() == '\\')
                    {
                        chrStack.Pop();
                        chrStack.Push(chrMap[chr]);
                    }
                    else
                    {
                        chrStack.Push(chr);
                    }

                }
                else
                {
                    data = new UInt64[0];
                    return false;
                }
            }


            if (!quoted && chrStack.Any())
            {
                data = chrStack.AsEnumerable().Reverse().ToArray();
                return true;
            }


            data = new UInt64[0];
            return false;
        }




        protected virtual string[] SplitValueArray(string value)
        {
            var values = new List<string>();
            string valueBuffer = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                char chr = value[i];
                if (char.IsWhiteSpace(chr) || chr == '{' || chr == '}') continue;

                if (chr != ',')
                {
                    valueBuffer += chr;
                }
                else
                {
                    values.Add(valueBuffer.Trim());
                    valueBuffer = string.Empty;
                }
            }
            values.Add(valueBuffer.Trim());
            return values.ToArray();
        }
        protected virtual UInt16[] PackValueData(UInt64[] data, DataType dataType)
        {
            var unaligned = new Stack<UInt64>();

            if (dataType == DataType.U8 && data.Length % 2 != 0)
            {
                unaligned.Push(0x0);
            }

            foreach (var element in data.Reverse())
            {
                unaligned.Push(element);
            }

            var aligned = new List<UInt16>();

            while (unaligned.Any())
            {
                switch (dataType)
                {
                    case DataType.U8:
                        {
                            var val0 = ((UInt16)((unaligned.Pop() & 0x00FF)));
                            var val1 = ((UInt16)((unaligned.Pop() & 0x00FF)));
                            var value = (UInt16)(val0 | (val1 << 8));
                            aligned.Add(value);
                        }
                        break;

                    case DataType.U16:
                        {
                            var value = unaligned.Pop();
                            var val0 = ((UInt16)((value >> (16 * 0)) & 0xFFFF));
                            aligned.Add(val0);
                        }
                        break;

                    case DataType.U32:
                        {
                            var value = unaligned.Pop();
                            var val0 = ((UInt16)((value >> (16 * 0)) & 0xFFFF));
                            var val1 = ((UInt16)((value >> (16 * 1)) & 0xFFFF));
                            aligned.Add(val0);
                            aligned.Add(val1);
                        }
                        break;
                    case DataType.U64:
                        {
                            var value = unaligned.Pop();
                            var val0 = ((UInt16)((value >> (16 * 0)) & 0xFFFF));
                            var val1 = ((UInt16)((value >> (16 * 1)) & 0xFFFF));
                            var val2 = ((UInt16)((value >> (16 * 2)) & 0xFFFF));
                            var val3 = ((UInt16)((value >> (16 * 3)) & 0xFFFF));
                            aligned.Add(val0);
                            aligned.Add(val1);
                            aligned.Add(val2);
                            aligned.Add(val3);
                        }
                        break;
                }
            }
            return aligned.ToArray();
        }
    }
}
