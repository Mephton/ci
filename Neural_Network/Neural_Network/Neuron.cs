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

        protected double defaultWeight = 1;
		protected double learningRate = 0.3;
		public double delta = 0.0;


        public Neuron()
        {

        }


		public abstract void learn(TrainingInstance t);
		public virtual void setDelta(TrainingInstance t) { }

		protected double currentOutputVoltage;
		public double getCurrentOutputValue() {
			return currentOutputVoltage;
		}

		public virtual void setStaticOutput(double v){}

		public virtual void addIncomingSynapse(Synapse s) {
			incomingSynapses.Add(s);
			s.weight = defaultWeight;
		}
		public virtual void addIncomingSynapse(Synapse s, double initWeight) {
			incomingSynapses.Add(s);
			s.weight = initWeight;
		}

		public virtual void addOutgoingSynapse(Synapse s) {
			outgoingSynapses.Add(s);
		}


		private static Random rand = new Random();
		public static double randomInitWeightGenerator(double min, double max) {
			return rand.NextDouble() * (max - min) + min;
		}


		protected double excitation() {
			double sum = 0.0;
			foreach (Synapse s in incomingSynapses) {
				sum += s.voltage * s.weight;
			}
			return sum;
		}

		protected virtual double activate(double sum) {
			//return -3.50 + 7.0 / (1.0 + Math.Pow(Math.E, -0.3 * sum));
			return -3.0 + 6.0 / (1.0 + Math.Pow(Math.E, -0.2 * sum));
			//return (6.0 / (1 + Math.Pow(Math.E, -sum)) - 3);
		}

		protected virtual double activateDifferentiated(double sum) {
			//return 2.1 * Math.Pow(Math.E, -0.3 * sum) / Math.Pow(1.0 + Math.Pow(Math.E, -0.3 * sum), 2.0);
			return 3.0 * Math.Pow(Math.E, -0.2 * sum) / Math.Pow(1.0 + Math.Pow(Math.E, -0.2 * sum), 2.0);
			//return 6.0 * Math.Pow(Math.E, -sum) / Math.Pow(1 + Math.Pow(Math.E, -sum), 2.0);
		}


		public virtual void calc() {
			currentOutputVoltage = activate(excitation());
			foreach (Synapse s in outgoingSynapses) {
				s.voltage = currentOutputVoltage;
			}
		}
    }
}
