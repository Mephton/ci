using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class TrainingInstance
    {
        public TrainingInstance(List<double> inputVector, double expectedOutput)
        {
            this.expectedOutput = expectedOutput;
            this.inputVector = inputVector;
        }
        public double expectedOutput;
        public List<double> inputVector;
    }
}
