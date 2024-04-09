using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE2023_4
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;
        int oldX,oldY;
        Boolean draw = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made in Unipi!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, EventArgs.Empty);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Pen(Color.Blue, 3f);
            g = this.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawCurve(p, new Point[] {
                new Point(50, 50),
                new Point(50, 200),
                new Point(200,200),
                new Point(200,50),
                new Point(50, 50)});

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(p,300,300,200,100);
            g.DrawLine(p, 100, 100, 250, 250);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(p, 150, 150, 80, 80);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(p, oldX, oldY, e.X, e.Y);
            }
            oldX = e.X;
            oldY = e.Y;
            label1.Text = e.X.ToString() + "," + e.Y.ToString();
        }
    }
}
