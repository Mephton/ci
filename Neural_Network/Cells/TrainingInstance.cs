using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    public class TrainingInstance
    {
        public TrainingInstance(List<decimal> inputVector, decimal expectedOutput)
        {
            this.expectedOutput = expectedOutput;
            this.inputVector = inputVector;
        }
        public decimal expectedOutput;
        public List<decimal> inputVector;
    }
}
