using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    public class Synapse
    {
		public Neuron from;
		public Neuron to;
		public decimal voltage = 0.0m;
        public decimal weight = 1.0m; //only to be set by "to" neuron

		public Synapse(Neuron from, Neuron to) {
			assign(from, to);
		}

		private void assign(Neuron from, Neuron to){
			this.from = from;
			this.to = to;
		}

		public Synapse(Neuron from, Neuron to, bool append) {
			assign(from, to);
			if(append){
				from.addOutgoingSynapse(this);
				to.addIncomingSynapse(this);
			}
		}
    }
}
