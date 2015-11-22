using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    public abstract class Neuron : Cell
    {
        protected List<Synapse> incomingSynapses = new List<Synapse>();
        protected List<Synapse> outgoingSynapses = new List<Synapse>();

        protected decimal defaultWeight = 1m;
		protected decimal learningRate = 0.3m;
		public decimal delta = 0.0m;


        public Neuron()
        {

        }


		public abstract void learn(TrainingInstance t);
		public virtual void setDelta(TrainingInstance t) { }

		protected decimal currentOutputVoltage;
		public decimal getCurrentOutputValue() {
			return activate(excitation());
		}

		public virtual void setStaticOutput(decimal v){}

		public virtual void addIncomingSynapse(Synapse s) {
			incomingSynapses.Add(s);
			s.weight = defaultWeight;
		}
		public virtual void addIncomingSynapse(Synapse s, decimal initWeight) {
			incomingSynapses.Add(s);
			s.weight = initWeight;
		}

		public virtual void addOutgoingSynapse(Synapse s) {
			outgoingSynapses.Add(s);
		}


		private static Random rand = new Random();
		public static decimal randomInitWeightGenerator(decimal min, decimal max) {
			return (decimal) rand.NextDouble() * (max - min) + min;
		}


		protected virtual decimal excitation() {
			decimal sum = 0.0m;
			foreach (Synapse s in incomingSynapses) {
				sum += s.voltage * s.weight;
			}
			return sum;
		}

		protected virtual decimal activate(decimal sum) {
			//return -3.50 + 7.0 / (1.0 + Math.Pow(Math.E, -0.3 * sum));
			return -3.0m + 6.0m / (1.0m + (decimal) Math.Pow(Math.E, -0.2 * (double) sum));
			//return (6.0 / (1 + Math.Pow(Math.E, -sum)) - 3);
		}

		protected virtual decimal activateDifferentiated(decimal sum) {
			//return 2.1 * Math.Pow(Math.E, -0.3 * sum) / Math.Pow(1.0 + Math.Pow(Math.E, -0.3 * sum), 2.0);
			return 3.0m * (decimal)Math.Pow(Math.E, -0.2 * (double)sum) / (decimal) Math.Pow(1.0 + Math.Pow(Math.E, (double)(-0.2m * sum)), 2.0);
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
