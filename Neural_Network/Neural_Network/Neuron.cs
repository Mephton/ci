using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Neuron : Cell
    {
        private List<Synapse> incomingSynpases = new List<Synapse>();
        private List<Synapse> outgoingSynpases = new List<Synapse>();
        private List<double> weights = new List<double>();

        public Neuron()
        {

        }
    
        public void addIncomingSynapse(Synapse s)
        {
            incomingSynpases.Add(s);
        }
    }
}
