﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            trainer.trainPerceptron();
        }
    }
}
