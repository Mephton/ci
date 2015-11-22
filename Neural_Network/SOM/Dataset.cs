using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace SOM {
	class Dataset {


		public Dataset() {
			read();
		}

		public List<Tuple<double,double>> points(){
			return sp;
		}

		private List<Tuple<double, double>> sp;

		private void read() {
			StreamReader srx = new StreamReader("C:/Users/Mirko/Documents/ci/Neural_Network/SOM/x.txt");
			StreamReader sry = new StreamReader("C:/Users/Mirko/Documents/ci/Neural_Network/SOM/y.txt");
			sp = new List<Tuple<double, double>>();

			while (!srx.EndOfStream) {
				string s1 = srx.ReadLine();
				string s2 = sry.ReadLine();
				double x = Convert.ToDouble(s1);
				double y = Convert.ToDouble(s2);
				sp.Add(new Tuple<double,double>(x,y));
			}
		}
	}
}
