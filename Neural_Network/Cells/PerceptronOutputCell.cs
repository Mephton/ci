using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	public class PerceptronOutputCell : Neuron {

		public override void learn(TrainingInstance t) {
			setDelta(t);

			foreach (Synapse s in incomingSynapses) {
				s.weight += -learningRate * s.voltage * delta;
			}
		}

		public override void setDelta(TrainingInstance t) {
			calc();
			delta = activateDifferentiated(excitation()) * (currentOutputVoltage - t.expectedOutput);
		}

        protected override decimal activate(decimal sum)
        {
            return sum;
        }

        protected override decimal activateDifferentiated(decimal sum)
        {
            return 1;
        }
	}
}
