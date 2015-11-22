using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	public class BiasNeuron : Neuron {
		public override void learn(TrainingInstance t) {
			throw new Exception("Bias Neuron cannot learn");
		}
		public override void addIncomingSynapse(Synapse s) {
			throw new Exception("Bias Neuron cannot have incoming synapses");
		}
		public override void addIncomingSynapse(Synapse s, decimal initWeight) {
			throw new Exception("Bias Neuron cannot have incoming synapses");
		}

		public override void addOutgoingSynapse(Synapse s) {
			base.addOutgoingSynapse(s);
			s.voltage = 1;
		}

		public override void calc() {
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = 1;
			}
			currentOutputVoltage = 1;
		}
		public override void setStaticOutput(decimal v) {
			throw new NotImplementedException();
		}
	}
}
