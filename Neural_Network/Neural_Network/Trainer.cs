using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Trainer
    {
		Perceptron perceptron;

		public Trainer() {
			List<int> numberOfNeurons = new List<int>(new int[] {1,10,1});
			perceptron = new Perceptron(numberOfNeurons, -0.5, 0.5);

			createTrainingSet();

		}

		private double f(double x) {
			return Math.Cos(x);
			return (Math.Cos(x / 3) + Math.Sin(10 / (Math.Abs(x) + 0.1)) + 0.1 * x); 
		}

        public List<TrainingInstance> training;

		public void createTrainingSet() {
			training = new List<TrainingInstance>();
			for (int i = 0; i < 1001; ++i) {
				training.Add(new TrainingInstance(new List<double>(new double[] { -10.0 + i * 20.0 / 1001.0 }), f(-10.0 + i * 20.0 / 1001.0)));
			}
		}

        public List<List<double>> trainingResults()
        {
            List<List<double>> results = new List<List<double>>();

            foreach (TrainingInstance ti in training)
            {
                results.Add(perceptron.feedForward(ti));
            }
            return results;
        }


        
        public void trainOutputLayer()
        {
			//TrainingInstance t1 = new TrainingInstance(new List<double>() { 7 }, -2);
			//TrainingInstance t2 = new TrainingInstance(new List<double>() { -7 }, 2);

			//perceptron.feedForward(t1);
			//foreach (Neuron n in perceptron.outputLayer.neurons)
			//{
			//	n.learn(t1);
			//}
			//perceptron.feedForward(t2);
			//foreach (Neuron n in perceptron.outputLayer.neurons) {
			//	n.learn(t2);
			//}

			//return;



			//TrainingInstance tr = training[r.Next(training.Count)];
            
			//perceptron.feedForward(tr);
			//foreach (Neuron n in perceptron.outputLayer.neurons)
			//{
			//	n.learn(tr);
			//}


			//return;

			var permed = training.OrderBy(item => r.Next());

			foreach (TrainingInstance ti in permed) {
				perceptron.feedForward(ti);
                foreach (Neuron n in perceptron.outputLayer.neurons)
                {
                    n.learn(ti);
                }
				//break;
            }
        }
        private int counter=0;


        Random r = new Random();


		public void trainHiddenLayer() {


			//TrainingInstance t1 = new TrainingInstance(new List<double>() { 7 }, 2);
			//perceptron.feedForward(t1);
			//foreach (Neuron o in perceptron.outputLayer.neurons) { //in case of MLP not always output layer!
			//	o.setDelta(t1);
			//}
			//for (int i = 1; i < perceptron.hiddenLayers[0].neurons.Count; ++i) {//in case of MLP not always  layer 0!
			//	perceptron.hiddenLayers[0].neurons[i].learn(t1);
			//}


			//TrainingInstance t2 = new TrainingInstance(new List<double>() { -7 }, 0);
			//perceptron.feedForward(t2);
			//foreach (Neuron o in perceptron.outputLayer.neurons) { //in case of MLP not always output layer!
			//	o.setDelta(t2);
			//}
			//for (int i = 1; i < perceptron.hiddenLayers[0].neurons.Count; ++i) {//in case of MLP not always  layer 0!
			//	perceptron.hiddenLayers[0].neurons[i].learn(t2);
			//}

			//return;


			//TrainingInstance tr = training[r.Next(training.Count)];
			//perceptron.feedForward(tr);
			//for (int i = 1; i < perceptron.hiddenLayers[0].neurons.Count; ++i) {
			//	((PerzeptronHiddenCell)perceptron.hiddenLayers[0].neurons[i]).learn(tr);
			//}

			//return;

			var permed = training.OrderBy(item => r.Next());

			foreach (TrainingInstance ti in permed) {
				perceptron.feedForward(ti);
				for (int i = 1; i < perceptron.hiddenLayers[0].neurons.Count; ++i ) {
					perceptron.hiddenLayers[0].neurons[i].learn(ti);
				}
				//break;
			}
		}


		public double meanSquareError() {

			double d=0.0;
			
			foreach (TrainingInstance ti in training) {
				perceptron.feedForward(ti);

				d+=Math.Pow(perceptron.outputLayer.neurons[0].getCurrentOutputValue()-ti.expectedOutput, 2.0);
			}

			d /= training.Count;
			return d;
		}

        public void trainPerceptron()
        {
			throw new NotImplementedException();


            List<double> a = new List<double>();
            a.Add(-4.0);
            List<double> b = new List<double>();
            b.Add(-3.0);
            List<double> c = new List<double>();
            c.Add(-1.0);
            List<double> d = new List<double>();
            d.Add(1.0);
            List<double> e = new List<double>();
            e.Add(2.0);

            List<TrainingInstance> training = new List<TrainingInstance>();
            training.Add(new TrainingInstance(a, 1));
            training.Add(new TrainingInstance(b, 1));
            training.Add(new TrainingInstance(c, 1));
            training.Add(new TrainingInstance(d, 1));
            training.Add(new TrainingInstance(e, 1));

            PerzeptronHiddenCell perzeptron = new PerzeptronHiddenCell();
            //perzeptron.addIncomingSynapse(new Synapse());

            for (int runs = 0; runs < 10; ++runs)
            {
                foreach (TrainingInstance t in training)
                {
                    perzeptron.learn(t);
                    Console.WriteLine(perzeptron.ToString());
                }
            }
            
        }
    }
}
