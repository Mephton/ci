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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g1 = pictureBox1.CreateGraphics();

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            g1.FillRectangle(new SolidBrush(Color.Green) ,new Rectangle(0, 0, w, h));

        }

        Trainer trainer = new Trainer();

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {


            trainer.createTrainingSet();


            Graphics g1 = pictureBox1.CreateGraphics();

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Pen p = new Pen(Color.Red, 0.05F);

            g1.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g1.ScaleTransform(pictureBox1.Width / 20.0F, -pictureBox1.Height / 6.0F);

            //g1.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 1, 1);

            for (int i = 0; i < trainer.training.Count-1; ++i) {
                g1.DrawLine(p,
                    Convert.ToSingle(trainer.training[i].inputVector[0]),
                    Convert.ToSingle(trainer.training[i].expectedOutput),
                    Convert.ToSingle(trainer.training[i + 1].inputVector[0]),
                    Convert.ToSingle(trainer.training[i + 1].expectedOutput)
                    );
            }

            trainer.trainPerceptron();

        }

        private void showNetworkOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<List<double>> tr = trainer.trainingResults();
            Graphics g1 = pictureBox1.CreateGraphics();

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Pen p = new Pen(Color.Red, 0.05F);

            g1.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g1.ScaleTransform(pictureBox1.Width / 20.0F, -pictureBox1.Height / 6.0F);
  
            for (int i = 0; i < tr.Count-1; ++i)
            {

              g1.DrawLine(p,
                    Convert.ToSingle(trainer.training[i].inputVector[0]),
                    Convert.ToSingle(tr[i][0]),
                    Convert.ToSingle(trainer.training[i + 1].inputVector[0]),
                    Convert.ToSingle(tr[i+1][0])
                    );
            }
        }
    }
}
