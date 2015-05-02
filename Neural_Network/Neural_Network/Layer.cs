using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	abstract class Layer {
		public List<Neuron> neurons = new List<Neuron>();
		public Layer(int capacity) {
			construct(capacity);
		}

		protected abstract void construct(int capacity);

		public string ToString() {
			StringBuilder sb = new StringBuilder();
			foreach (Neuron n in neurons) {
				sb.Append(n.getCurrentOutputValue().ToString() + "\t");
			}
			return sb.ToString();
		}
	}
	class InputLayer : Layer {
		public InputLayer(int capacity)
			: base(capacity) {
		}
		protected override void construct(int capacity) {
			for (int i = 0; i < capacity; ++i) {
				neurons.Add(new PerceptronInputCell());
			}
		}
	}
	class HiddenLayer : Layer {
		public HiddenLayer(int capacity)
			: base(capacity) {
		}
		protected override void construct(int capacity) {
			neurons.Add(new BiasNeuron());
			for (int i = 1; i < capacity; ++i) {
				neurons.Add(new PerzeptronCell());
			}
		}
	}
	class OutputLayer : Layer {
		public OutputLayer(int capacity)
			: base(capacity) {
		}
		protected override void construct(int capacity) {
			for (int i = 0; i < capacity; ++i) {
				neurons.Add(new PerzeptronCell());
			}
		}
	}
}
