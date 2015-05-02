using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
	class Perceptron {


		public Layer inputLayer;
		private Layer outputLayer;
		private List<Layer> hiddenLayers;
		private double initWeightMin;
		private double initWeightMax;

		public Perceptron(List<int> numberOfNeurons, double initWeightMin, double initWeightMax) {

			inputLayer = new InputLayer(numberOfNeurons[0]);
			hiddenLayers = new List<Layer>();
			for (int i = 1; i < numberOfNeurons.Count - 1; ++i) {
				hiddenLayers.Add(new HiddenLayer(numberOfNeurons[i]));
			}
			outputLayer = new OutputLayer(numberOfNeurons[numberOfNeurons.Count - 1]);

			this.initWeightMax = initWeightMax;
			this.initWeightMin = initWeightMin;

			connectFully();
		}


		private void connectFully() {
			for (int i = 0; i < hiddenLayers.Count; ++i) {
				Layer current = i < hiddenLayers.Count-1 ? hiddenLayers[i] : inputLayer;
				Layer next = i < hiddenLayers.Count - 1 ? hiddenLayers[i + 1] : hiddenLayers[0];
				foreach (Neuron from in current.neurons) {
					foreach (Neuron to in next.neurons) {
						if (to.GetType() == typeof(BiasNeuron)) {
							continue;
						}
						Synapse s = new Synapse(from, to);
						from.addOutgoingSynapse(s);
						to.addIncomingSynapse(s, Neuron.randomInitWeightGenerator(initWeightMin, initWeightMax));
					}
				}
			}
		}


		public string outputLayerToString() {
			return outputLayer.ToString();
		}
	}
}
