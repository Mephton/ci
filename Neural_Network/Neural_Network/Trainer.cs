using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Trainer
    {
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
            perzeptron.addIncomingSynapse(new Synapse());

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
