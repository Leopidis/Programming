using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        Pen pen;
        Bitmap bitmap,bitmap2;
        Graphics graphics,graphics2;
        Point start, stop;
        bool draw;
        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.Image = bitmap;
            pictureBox1.Parent= pictureBox2;
            bitmap2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            graphics2 = Graphics.FromImage(bitmap2);
            pictureBox2.Image = bitmap2;
            start = new Point();
            stop= new Point();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw= true;
            start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            graphics.Clear(Color.Transparent);
            pictureBox1.Refresh();
            graphics2.DrawLine(pen, start,e.Location );
            draw= false;
            pictureBox2.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                graphics.Clear(Color.Transparent);
                graphics.DrawLine (pen, start, e.Location );
                stop= e.Location;  
                pictureBox1.Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
