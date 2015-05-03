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





        public void trainPerceptron()
        {
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

            PerzeptronCell perzeptron = new PerzeptronCell();
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
