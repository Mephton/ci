using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	class PerceptronInputCell : PerzeptronCell {
		public override void sethard(double value) {
			currentOutputVoltage = value;
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = currentOutputVoltage;
			}
		}
	}
}
