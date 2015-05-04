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
        public double weight = 0.0; //only to be set by "to" neuron

		public Synapse(Neuron from, Neuron to) {
			this.from = from;
			this.to = to;
		}
    }
}
