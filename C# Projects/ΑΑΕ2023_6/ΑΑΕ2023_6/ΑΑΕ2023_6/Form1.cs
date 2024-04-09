using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ΑΑΕ2023_6
{
    public partial class Form1 : Form
    {
        Pen pen, eraser;
        Graphics graphics;
        bool draw;
        Point start, stop;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            eraser = new Pen(BackColor, 3);
            graphics = this.CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            start = e.Location;
            points.Add(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw= false;
            stop = e.Location;
            graphics.DrawLine(pen, start, stop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.name = "Petros";
            s1.email = "pet@unipi.gr";

            String jsonString = JsonSerializer.Serialize(s1);
            richTextBox1.Text = jsonString;
            File.WriteAllText("student.json", jsonString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String jsonString = JsonSerializer.Serialize(points);
            File.WriteAllText("points.json", jsonString);
            points.Clear();
            MessageBox.Show("Saved!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String jsonString = File.ReadAllText("points.json");
            points.Clear();
            points = JsonSerializer.Deserialize<List<Point>>(jsonString);
            for(int i = 0; i < points.Count-1; i++)
            {
                graphics.DrawLine(pen, points[i], points[i+1]);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                graphics.DrawLine(eraser,start, stop);
                graphics.DrawLine(pen, start, e.Location);
                stop= e.Location;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }
    }
}
