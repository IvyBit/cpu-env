using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismap
{
    public class InstructionSet : List<InstructionGroup>
    {
        private int _instructionIndex = 0;

        private Dictionary<string, PipelineInstruction> _instructions = new Dictionary<string, PipelineInstruction>();
        public IReadOnlyDictionary<string, PipelineInstruction> Instructions => _instructions;

        public new void Add(InstructionGroup instructionGroup)
        {
            instructionGroup.GroupOffset = _instructionIndex;
            base.Add(instructionGroup);

            foreach (var instruction in instructionGroup)
            {
                instruction.InstructionIndex = _instructionIndex;
                _instructions.Add(instruction.Name, instruction);
                _instructionIndex++;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var instructioGroup in this)
            {
                sb.Append(instructioGroup.ToString());
            }
            return sb.ToString();
        }
    }
}
