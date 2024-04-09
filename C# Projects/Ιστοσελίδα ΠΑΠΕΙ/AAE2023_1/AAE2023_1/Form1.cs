using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE2023_1
{
    public partial class Form1 : Form
    {
        int count;
        bool visibility = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString()+" times pressed!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.unipi.gr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*visibility = !visibility;
            pictureBox1.Visible = visibility;*/// 1ος τρόπος

            pictureBox1.Visible = !pictureBox1.Visible;//2ος τρόπος (σούπερ)

            /*if (visibility)
            {
                pictureBox1.Visible = false;
                visibility= false;
            }
            else
            {
                pictureBox1.Visible = true;
                visibility= true;
            }*///3ος τρόπος (κλασικός)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Android!");
        }
    }
}
