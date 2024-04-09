using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE2023_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyData == Keys.Right 
                && (pictureBox1.Location.X+pictureBox1.Width)<this.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X+15,
                    pictureBox1.Location.Y);
            }
            else if (e.KeyData == Keys.Left)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 15,
                    pictureBox1.Location.Y);
            }
            else if (e.KeyData == Keys.Up)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X,
                    pictureBox1.Location.Y-15);
            }
            else if (e.KeyData == Keys.Down)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X,
                    pictureBox1.Location.Y+15);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Unipi!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 15,
                    pictureBox1.Location.Y+10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
        }
    }
}
