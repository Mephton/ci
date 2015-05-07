using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network
{
    public partial class Visualizer : Form
    {
        public Visualizer()
        {
            InitializeComponent();
        }

        Trainer trainer = new Trainer();

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < trainer.training.Count-1; ++i) {
				g1.DrawLine(p1,
					Convert.ToSingle(trainer.training[i].inputVector[0]),
					Convert.ToSingle(trainer.training[i].expectedOutput),
					Convert.ToSingle(trainer.training[i + 1].inputVector[0]),
					Convert.ToSingle(trainer.training[i + 1].expectedOutput)
					);
				//g1.DrawRectangle(p,Convert.ToSingle(trainer.training[i].inputVector[0]), Convert.ToSingle(trainer.training[i].expectedOutput), 0.001f, 0.001f);
            }
        }

        Graphics g1;
        int w, h;
        Pen p1, p2;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            g1 = pictureBox1.CreateGraphics();

            w = pictureBox1.Width;
            h = pictureBox1.Height;


            g1.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g1.ScaleTransform(pictureBox1.Width / 20.0F, -pictureBox1.Height / 6.0F);


            p1 = new Pen(Color.Green, 0.05F); // target function
            p2 = new Pen(Color.Black, 0.05F); // coord axis

        }

		int outputCounter = 0;

        private void showNetworkOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<List<double>> tr = trainer.trainingResults();
            
            //vary output color
            Pen p = new Pen(Color.FromArgb((255*5-3*outputCounter)%255,(outputCounter)%255,(10*outputCounter++)%255), 0.001F);
            
            //axis
            g1.DrawLine(p2, -10f, 0f, 10f, 0f);
            g1.DrawLine(p2, 0f, -3f, 0f, 3f);

            for (int i = 0; i < tr.Count-1; ++i)
            {
              g1.DrawLine(p,
                    Convert.ToSingle(trainer.training[i].inputVector[0]),
                    Convert.ToSingle(tr[i][0]),
                    Convert.ToSingle(trainer.training[i + 1].inputVector[0]),
                    Convert.ToSingle(tr[i+1][0])
                    );
            }

			toolStripStatusLabel1.Text = trainer.meanSquareError().ToString();
        }

        private void trainOutputLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainer.trainOutputLayer();
			showNetworkOutputToolStripMenuItem_Click(sender, e);
        }

		private void trainHiddenLayer0ToolStripMenuItem_Click(object sender, EventArgs e) {
			trainer.trainHiddenLayer();
			showNetworkOutputToolStripMenuItem_Click(sender, e);
		}
    }
}
