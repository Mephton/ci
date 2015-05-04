using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	class PerceptronOutputCell : Neuron {

		public override void learn(TrainingInstance t) {
			setDelta(t);

			foreach (Synapse s in incomingSynapses) {
				s.weight += -learningRate * s.voltage * delta;
			}
		}

		public override void setDelta(TrainingInstance t) {
			delta = activateDifferentiated(excitation()) * (currentOutputVoltage - t.expectedOutput);
		}
	}
}
