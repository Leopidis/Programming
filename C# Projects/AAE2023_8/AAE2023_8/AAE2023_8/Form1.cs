using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE2023_8
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button myButton = new Button();
            myButton.Location = new Point(200, 43);
            myButton.Name = "myButton";
            myButton.Size = new Size(110, 40);
            myButton.TabIndex = 1;
            myButton.Text = "myButton";
            myButton.UseVisualStyleBackColor = true;
            myButton.Click += new EventHandler(someMethod);
            Controls.Add(myButton);
        }
        private void someMethod(object o, EventArgs e)
        {
            MessageBox.Show("Hello!");
            Button b = (Button)o;
            MessageBox.Show(b.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            
            for(int i=0; i<count; i++)
            {
                Button myButton = new Button();
                myButton.Location = new Point(20+100*i, 100);
                myButton.Name = "myButton"+i;
                myButton.Size = new Size(100, 40);
                myButton.TabIndex = 1+i+1;
                myButton.Text = "myButton"+i;
                myButton.UseVisualStyleBackColor = true;
                myButton.Click += new EventHandler(someMethod);
                Controls.Add(myButton);
                buttons.Add(myButton);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].BackColor = Color.Yellow;
            }*/
            foreach(Button b in buttons)
            {
                b.BackColor= Color.Red;
            }
        }
    }
}
