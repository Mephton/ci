using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOM {
	public partial class Visualizer : Form {

		Graphics graphics;

		public Visualizer() {
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void init() {

			graphics = pictureBox1.CreateGraphics();
			graphics.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
			graphics.ScaleTransform(pictureBox1.Width / 20, pictureBox1.Height / 20);

		}

	
		private void test1ToolStripMenuItem_Click(object sender, EventArgs e) {
			init();
			graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, 1, 1);
			paintDataSet();
		}

		private void paintDataSet() {
			Dataset data = new Dataset();
			foreach (Tuple<double,double> p in data.points()) {
				graphics.FillEllipse(new SolidBrush(Color.Green), (float) p.Item1 - 0.1F, (float) p.Item2 - 0.1F, 0.2F, 0.2F);
			}
		}

	}
}
