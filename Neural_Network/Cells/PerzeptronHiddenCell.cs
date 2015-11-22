using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    public class PerzeptronHiddenCell : Neuron
    {
        public override void learn(TrainingInstance ti) {
			setDelta(ti);

			foreach (Synapse s in incomingSynapses)
            {
				s.weight += -learningRate * s.voltage * delta;
            }
        }

		public override void setDelta(TrainingInstance t) {
			decimal sumout = 0.0m;
			foreach (Synapse s in outgoingSynapses) {
				s.to.calc();
				s.to.setDelta(t);
				sumout += s.weight * s.to.delta;
			}
			delta = activateDifferentiated(excitation()) * sumout;
		}

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<incomingSynapses.Count(); ++i){
				sb.Append("weight " + i.ToString() + ": " + incomingSynapses[i].weight.ToString() + "\t");
            }
            return sb.ToString();
        }


        protected override decimal activate(decimal sum)
        {
            return (decimal)(1 / (1 + Math.Pow(Math.E, (double)-sum)));
        }

        protected override decimal activateDifferentiated(decimal sum)
        {
            decimal a = activate(sum);
            return a*(1.0m-a);
        }
    }
}
