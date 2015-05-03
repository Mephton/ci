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


		private double sumUp() {
			if(incomingSynapses.Count != weights.Count) {
				throw new Exception("amount of synapses do not match amount of weights");
			}

			double sum = 0.0;
			for (int i = 0; i < weights.Count; ++i) {
				sum += incomingSynapses[i].voltage * weights[i];
			}

			return sum;
		}

		public override void calc() {
			double sum = sumUp();
			currentOutputVoltage = (1.0 / (1 + Math.Pow(Math.E, -sum)));
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = currentOutputVoltage;
			}

		}



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

		public override void addIncomingSynapse(Synapse s) {
			incomingSynapses.Add(s);
			weights.Add(defaultWeight);
		}
		public override void addIncomingSynapse(Synapse s, double initWeight) {
			incomingSynapses.Add(s);
			weights.Add(initWeight);
		}

		public override void sethard(double v) {
			throw new NotImplementedException();
		}
    }
}
