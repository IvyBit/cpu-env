using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismap
{
    public class InstructionGroup : HashSet<PipelineInstruction>
    {
        public int GroupOffset { get; set; } = 0;

        public string Name { get; }
        public InstructionGroup(string name) : base(new PipelineInstructionComparer())
        {
            Name = name;
        }

        public void Add<TS0, TS1>(string name, TS0 stage0, TS1 stage1) where TS0 : struct where TS1 : struct
        {
            if(!Add(new PipelineInstruction
            {
                Name = name,
                Stage0 = (PS0)(object)stage0,
                Stage1 = (PS1)(object)stage1,
            }))
            {
                throw new Exception("Duplicate instruction");
            }
        }

        public void Add<TS0, TS1>(string name, byte memoryDepth, TS0 stage0, TS1 stage1) where TS0 : struct where TS1 : struct
        {
            if (!Add(new PipelineInstruction
            {
                Name = name,
                Stage0 = (PS0)(object)stage0,
                Stage1 = (PS1)(object)stage1,
                MemoryDepth = memoryDepth,
            }))
            {
                throw new Exception("Duplicate instruction");
            }
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            foreach(PipelineInstruction signalSet in this)
            {
                sb.Append(signalSet.ToString("  "));
            }
            return sb.ToString();
        }
    }
}
