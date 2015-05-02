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

		protected double currentOutputVoltage;
		public double getCurrentOutputValue() {
			return currentOutputVoltage;
		}

		public abstract void calc();
		public abstract void sethard(double v);

		public abstract void addIncomingSynapse(Synapse s);
		public abstract void addIncomingSynapse(Synapse s, double weight);
		public void addOutgoingSynapse(Synapse s) {
			outgoingSynapses.Add(s);
		}


		private static Random rand = new Random();
		public static double randomInitWeightGenerator(double min, double max) {
			return rand.NextDouble() * (max - min) + min;
		}

    }
}
