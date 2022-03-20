using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembler.parsers
{
public abstract class ParserResult
{
    public virtual bool Success { get; }
    public ParserResult(bool success)
    {
        Success = success;
    }
}
}
