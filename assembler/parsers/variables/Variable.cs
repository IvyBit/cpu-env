using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers.variables
{
    public enum DataType
    {
        INVALID,
        U8,
        U16,
        U32,
        U64,
    }

    public enum ValueType
    {
        INVALID,
        VAL,
        ARR,
        STR
    }

    public class Variable
    {
        public string name = string.Empty;
        public DataType dataType = DataType.INVALID;
        public ValueType valueType = ValueType.INVALID;
        public UInt16[] data = new UInt16[0];
        public string stringData = string.Empty;

        public override string ToString()
        {
            return $"{dataType} {name} {stringData}";
        }
    }
}
