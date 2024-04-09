using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ΑΑΕ2023_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Form mouse enter\n");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Form mouse leave\n");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Button mouse enter\n");
            this.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Button mouse leave\n");
            BackColor = Color.Red;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString()+","+e.Y.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            richTextBox1.AppendText(e.KeyData.ToString()+"\n");
        }
    }
}
