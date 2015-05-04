using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class PerzeptronHiddenCell : Neuron
    {
        public override void learn(TrainingInstance ti) {
			setDelta(ti);

			foreach (Synapse s in incomingSynapses)
            {
				s.weight = -learningRate * currentOutputVoltage * delta;
            }
        }

		public override void setDelta(TrainingInstance t) {
			double sumout = 0.0;
			foreach (Synapse s in outgoingSynapses) {
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
    }
}
