using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.TextChanged += new EventHandler(change);
            textBox2.TextChanged += new EventHandler(change);
            textBox3.TextChanged += new EventHandler(change);
        }

        private void change(object sender, EventArgs e)
        {

            double x;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out x) && double.TryParse(textBox3.Text, out x))
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double x, y, z, u;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);

            u = Math.Pow(8 + Math.Abs(x - y) * Math.Abs(x - y) + 1, 1.0 / 3) 
                / (x * x + y * y + 2) - Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Tan(z) * Math.Tan(z) + 1, x);

            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            textBox4.Text += Environment.NewLine + "Результат: U = " + u.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;
           
            if (!double.TryParse(textBox1.Text, out a))
            {
                textBox1.Clear();
                label4.Visible = false;
            }
            if (!double.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
                label5.Visible = false;
            }
            if (!double.TryParse(textBox3.Text, out a))
            {
                textBox3.Clear();
                label6.Visible = false;
            }
            if (textBox4.TextLength > 0) {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double x;
            
            if (double.TryParse(textBox1.Text, out x) || textBox1.TextLength == 0)
            {
                label4.Visible = false;
            }                      
            else
            {              
                label4.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double y;
            if (double.TryParse(textBox2.Text, out y) || textBox2.TextLength == 0)
            {               
                label5.Visible = false;
            }         
            else
            {               
                label5.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double z;
            if (double.TryParse(textBox3.Text, out z) || textBox3.TextLength==0)
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
 
        }

        private void label5_Click(object sender, EventArgs e)
        {
     
        }

        private void label6_Click(object sender, EventArgs e)
        {
    
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
