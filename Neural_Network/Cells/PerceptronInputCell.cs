using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	public class PerceptronInputCell : Neuron {
		public override void setStaticOutput(decimal value) {
			currentOutputVoltage = value;
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = currentOutputVoltage;
			}
		}

		public override void learn(TrainingInstance t) {
			throw new InvalidOperationException("Input Cells cannot learn");
		}
	}
}
