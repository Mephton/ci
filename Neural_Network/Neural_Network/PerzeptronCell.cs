using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class PerzeptronCell : Neuron
    {
        protected double theta = 0.0;
        protected double bias = 0;

        public override void learn(TrainingInstance t)
        {
            double phi = 0.0;
            for (int i = 0; i < incomingSynapses.Count(); ++i)
            {
                phi += weights[i] * t.inputVector[i];
            }
            phi += bias;

            double output = phi > theta ? 1.0 : 0.0;

            for (int i = 0; i < weights.Count(); ++i)
            {
                weights[i]=weights[i]+learningRate*(t.expectedOutput-output)*t.inputVector[i];
                //bias = bias+learningRate*(t.expectedOutput-output)
            }

        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<weights.Count(); ++i){
                sb.Append("weight "+i.ToString()+": "+weights[i].ToString()+"\t");
            }

            return sb.ToString();
        }
    }
}
