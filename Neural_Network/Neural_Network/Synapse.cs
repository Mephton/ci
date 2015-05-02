using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Synapse
    {
		public Neuron from;
		public Neuron to;
		public double voltage = 0.0;

		public Synapse(Neuron from, Neuron to) {
			this.from = from;
			this.to = to;
		}
    }
}
