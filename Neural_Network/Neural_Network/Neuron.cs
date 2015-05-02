using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    abstract class Neuron : Cell
    {
        protected List<Synapse> incomingSynapses = new List<Synapse>();
        protected List<Synapse> outgoingSynapses = new List<Synapse>();
        protected List<double> weights = new List<double>();

        protected double defaultWeight = 1;
        protected double learningRate = 0.3;

        public abstract void learn(TrainingInstance t);

        public Neuron()
        {

        }
    
        public void addIncomingSynapse(Synapse s)
        {
            incomingSynapses.Add(s);
            weights.Add(defaultWeight);
        }
    }
}
