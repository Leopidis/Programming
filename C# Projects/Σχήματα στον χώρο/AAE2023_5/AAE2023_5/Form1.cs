using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE2023_5
{
    public partial class Form1 : Form
    {
        Pen pen;
        Graphics graphics;
        Bitmap bitmap;
        bool draw;
        Point startPoint, endPoint;
        int choice;
        PointF[] shape;
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice = 3;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (choice == 1)
            {
                graphics.DrawLine(pen, startPoint.X,startPoint.Y, e.Location.X,e.Location.Y);
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                createPolygon(startPoint, e.Location, 6);
            }
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(pen, 50, 50, 500, 340);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("mypic.png", ImageFormat.Png);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            //graphics.DrawLine(pen, 0, 0, 300, 300);
        }
        private void createPolygon(Point start, Point stop, int sides)
        {
            //Βρισκουμε το κέντρο
            var x0 = (start.X + stop.X) / 2;
            var y0 = (start.Y + stop.Y) / 2;

            shape = new PointF[sides];

            float angle = 360 / sides;

            float r = (float)Math.Sqrt(Math.Pow((start.X - stop.X), 2) + Math.Pow((start.Y - stop.Y), 2))/2;

            for(int a = 0; a<sides; a++)
            {
                shape[a] = new PointF(
                    x0 + r * (float)Math.Cos(a * angle * Math.PI / 180f),
                    y0 + r * (float)Math.Sin(a * angle * Math.PI / 180f));
            }
            graphics.DrawPolygon(pen, shape);
            pictureBox1.Refresh();
        }
    }
}
