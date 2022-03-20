using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismap
{



    public class PipelineInstructionComparer : IEqualityComparer<PipelineInstruction>
    {
        public bool Equals(PipelineInstruction? x, PipelineInstruction? y)
        {
            if(x == null && y == null)
            {
                return true;
            }else if((x == null) != (y == null))
            {
                return false;
            }else
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return x.Stage0 == y.Stage0 && x.Stage1 == y.Stage1;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        public int GetHashCode([DisallowNull] PipelineInstruction obj)
        {
            return obj.GetHashCode();
        }
    }
    public class PipelineInstruction
    {
        public string Name { get; set; } = string.Empty;
        public PS0 Stage0 { get; set; }
        public PS1 Stage1 { get; set; }

        public byte MemoryDepth { get; set; } = 1;

        public int InstructionIndex { get; set; } = 0;

        public string ToString(string prefix)
        {
            return $"{prefix}{InstructionIndex}: {Name}\n{prefix} S0: {Stage0}\n{prefix} S1: {Stage1}\n";
        }
        public override string ToString()
        {
            return $"{InstructionIndex}: {Name}\n S0: {Stage0}\n S1: {Stage1}\n";
        }

        public override int GetHashCode()
        {
            return $"{(UInt64)Stage0}{(UInt64)Stage1}".GetHashCode();
        }
    }
}
