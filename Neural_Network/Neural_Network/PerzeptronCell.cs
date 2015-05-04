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

        private double activate(double sum)
        {
            return (6.0 / (1 + Math.Pow(Math.E, -sum)) - 3);
        }

        private double activateDiff(double sum)
        {
            double a=activate(sum);
            return (a * (1.0 - a / 6.0));
        }

		public override void calc() {
			double sum = sumUp();
			currentOutputVoltage = activate(sum);
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = currentOutputVoltage;
			}

		}


        double deltaOut = 0.0; //export to outputCell

        public override void learn(TrainingInstance t)
        { //currently only output layer
            double sum = sumUp();
            calc();

            foreach (Synapse s in incomingSynapses)
            {

            }

            for (int j = 0; j < weights.Count; ++j)
            {
                weights[j] += -learningRate * currentOutputVoltage * activateDiff(sum) * (currentOutputVoltage - t.expectedOutput);
                incomingSynapses[j].weight = weights[j];
            }

        }

        public void learnHidden(TrainingInstance t)
        {//make sure synapses weight has been set....
            double sum = sumUp();
            calc();
            double sumout = 0.0;
            foreach ()
            for (int j = 0; j < weights.Count; ++j)
            {
                weights[j] += -learningRate * currentOutputVoltage * activateDiff(sum) * (currentOutputVoltage - t.expectedOutput);
                incomingSynapses[j].weight = weights[j];
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
