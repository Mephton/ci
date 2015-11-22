using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {


	class DynamicNetwork {

		private class MultNeuron : Neuron {
			protected override decimal activate(decimal sum) {
				return sum;
			}
			protected override decimal activateDifferentiated(decimal sum) {
				return 1;
			}
			protected override decimal excitation() {
				decimal prod = 1.0m;
				foreach (Synapse s in incomingSynapses) {
					prod *= s.voltage * s.weight;
				}
				return prod;
			}
			public override void learn(TrainingInstance t) {
				throw new NotImplementedException();
			}
		}

		private class SumNeuron : Neuron {
			protected override decimal activate(decimal sum) {
				return sum;
			}
			protected override decimal activateDifferentiated(decimal sum) {
				return 1;
			}
			protected override decimal excitation() {
				decimal sum = 0.0m;
				foreach (Synapse s in incomingSynapses) {
					sum += s.voltage * s.weight;
				}
				return sum;
			}
			public override void setStaticOutput(decimal v) {
				currentOutputVoltage = v;
				foreach (Synapse s in outgoingSynapses) {
					s.voltage = currentOutputVoltage;
				}
			}
			public override void learn(TrainingInstance t) {
				throw new NotImplementedException();
			}
		}

		public DynamicNetwork() {
			init(0.5m, 0m);

			List<KeyValuePair<decimal, decimal>> values = new List<KeyValuePair<decimal, decimal>>();

			for (int i = 0; i < 1000; ++i) {
				runstep();
				values.Add(new KeyValuePair<decimal, decimal>(x1.getCurrentOutputValue(), x2.getCurrentOutputValue()));
			}
		}

		Neuron x1 = new SumNeuron();
		Neuron x2 = new SumNeuron();

		MultNeuron x1h3 = new MultNeuron();
		MultNeuron x2h2x1 = new MultNeuron();
		MultNeuron x1h2x2 = new MultNeuron();
		MultNeuron x2h3 = new MultNeuron();


		SumNeuron prex1 = new SumNeuron();
		SumNeuron prex2 = new SumNeuron();

		void runstep() {
			x1h3.calc();
			x2h2x1.calc();
			x1h2x2.calc();
			x2h3.calc();
			prex1.calc();
			prex2.calc();
			x1.calc();
			x2.calc();
		}

		void init(decimal x1start, decimal x2start) {


			new Synapse(x1, x1h3, true); // true => auto-append this synapse to neurons
			new Synapse(x1, x1h3, true);
			new Synapse(x1, x1h3, true);
			new Synapse(x1, x2h2x1, true);
			new Synapse(x1, x1h2x2, true);
			new Synapse(x1, x1h2x2, true);

			new Synapse(x2, x2h2x1, true);
			new Synapse(x2, x2h2x1, true);
			new Synapse(x2, x1h2x2, true);
			new Synapse(x2, x2h3, true);
			new Synapse(x2, x2h3, true);
			new Synapse(x2, x2h3, true);


			Synapse s01 = new Synapse(x2, prex1, true);
			s01.weight = -1.0m;
			Synapse s02 = new Synapse(x1, prex1, true);
			s02.weight = 2.0m;
			Synapse s03 = new Synapse(x1h3, prex1, true);
			s03.weight = -1.0m;
			Synapse s04 = new Synapse(x2h2x1, prex1, true);
			s04.weight = -1.0m;



			Synapse s05 = new Synapse(x1, prex2, true);
			s01.weight = +1.0m;
			Synapse s06 = new Synapse(x2, prex2, true);
			s02.weight = 2.0m;
			Synapse s07 = new Synapse(x2h3, prex2, true);
			s03.weight = -1.0m;
			Synapse s08 = new Synapse(x1h2x2, prex2, true);
			s04.weight = -1.0m;


			Synapse s42 = new Synapse(prex1, x1, true);
			Synapse s43 = new Synapse(prex2, x2, true);
			s42.weight = 0.01m;
			s43.weight = 0.01m;

			new Synapse(x1, x1, true);
			new Synapse(x2, x2, true);


			x1.setStaticOutput(x1start);
			x2.setStaticOutput(x2start);
		}
	}
}
