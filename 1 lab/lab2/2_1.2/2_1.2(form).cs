using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.TextChanged += new EventHandler(change);
            textBox3.TextChanged += new EventHandler(change);
            textBox4.TextChanged += new EventHandler(change);
            textBox5.TextChanged += new EventHandler(change);
            textBox6.TextChanged += new EventHandler(change);
            textBox7.TextChanged += new EventHandler(change);
        }

        private void change(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(textBox2.Text, out x) && double.TryParse(textBox3.Text, out x)
                && double.TryParse(textBox4.Text, out x) && double.TryParse(textBox5.Text, out x)
                && double.TryParse(textBox6.Text, out x) && double.TryParse(textBox7.Text, out x))
                button1.Enabled = true;
            else button1.Enabled = false;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xo, Xn, dX, a, b, c, y;
            textBox1.Clear();
            textBox1.Enabled = true;
            Xo = double.Parse(textBox2.Text);
            Xn = double.Parse(textBox3.Text);
            dX = double.Parse(textBox4.Text);
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            c = double.Parse(textBox7.Text);
            double temp = c * Math.Pow(a - b, 3);
            do
            {
                y = temp * Math.Pow(Math.E, Xo * Xo) + Xo;
                if (double.IsNaN(y)) {
                    textBox1.Text += Environment.NewLine + "Больше нельзя посчитать: e^(x^2)";
                    break;
                }
                textBox1.Text += Environment.NewLine + $"{Xo}       {y} ";
                Xo += dX;
            } while ((Xo <= Xn && Xo > 0) || (Xo >= Xn && Xo < 0));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox2.TextLength == 0 || double.TryParse(textBox2.Text, out x))
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox3.TextLength == 0 || double.TryParse(textBox3.Text, out x) )
                label7.Visible = false;
            else
                label7.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox4.TextLength == 0 || double.TryParse(textBox4.Text, out x))
                label8.Visible = false;
            else
                label8.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox5.TextLength == 0 || double.TryParse(textBox5.Text, out x))
                label9.Visible = false;
            else
                label9.Visible = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox6.TextLength == 0 || double.TryParse(textBox6.Text, out x))
                label10.Visible = false;
            else
                label10.Visible = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (textBox7.TextLength == 0 || double.TryParse(textBox7.Text, out x))
                label11.Visible = false;
            else
                label11.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;

            if (!double.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
               
            }
            if (!double.TryParse(textBox3.Text, out a))
            {
                textBox3.Clear();
              
            }
            if (!double.TryParse(textBox4.Text, out a))
            {
                textBox4.Clear();
               
            }
            if (!double.TryParse(textBox5.Text, out a))
            {
                textBox5.Clear();
               
            }
            if (!double.TryParse(textBox6.Text, out a))
            {
                textBox6.Clear();
             
            }
            if (!double.TryParse(textBox7.Text, out a))
            {
                textBox7.Clear();
              
            }
            if (textBox1.TextLength > 0)
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                //textBox1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Clear();
        }
    }
}
