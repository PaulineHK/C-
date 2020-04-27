using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2._1
{
    public partial class Form1 : Form
    {
        double[] X;
        double[] Y;
        int length = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label10.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.TextChanged += new EventHandler(change);
            textBox2.TextChanged += new EventHandler(change);
            textBox3.TextChanged += new EventHandler(change);
            textBox4.TextChanged += new EventHandler(change);
            
            radioButton1.CheckedChanged += new EventHandler(change);
            radioButton2.CheckedChanged += new EventHandler(change);
            listBox1.TextChanged += new EventHandler(change);
        }
        private void change(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double a) && double.TryParse(textBox3.Text, out double b) &&
                double.TryParse(textBox4.Text, out double c) && Int32.TryParse(textBox1.Text, out length))
                button1.Enabled = true;
            else
            {
                button1.Enabled = false;
            }

            if ((radioButton1.Checked || radioButton2.Checked)&& listBox1.Items.Count!=0)
                button3.Enabled = true;
            else button3.Enabled = false;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button4.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            length = Int32.Parse(textBox1.Text);
            X = new double[length];
            Y = new double[length];
            double a = double.Parse(textBox2.Text);
            double b = double.Parse(textBox3.Text);
            double c = double.Parse(textBox4.Text);
            Random r = new Random();
            double temp = c * Math.Pow(a - b, 3);           
            for (int i = 0; i < length; i++)
            {
                
                X[i] = Math.Round(r.NextDouble(), 3);
                Y[i] = Math.Round(temp * Math.Pow(Math.E, X[i] * X[i]) + X[i]);
                if (double.IsNaN(Y[i]))
                {
                    
                }
                else
                    listBox2.Items.Add(Y[i]);
                listBox1.Items.Add(X[i]);
            }
        } //заполнение
        private void button2_Click(object sender, EventArgs e)
        {           
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                Y[i] = Math.Abs(Y[i]);
                int r = rand.Next(2);
                if (r == 1)
                    Y[i] = Y[i] * (-1);
                //listBox2.Items[i] = Y[i];
            }
            
            outY();
        } //Знак
        private void button3_Click(object sender, EventArgs e) //Сортировка
        {
            double temp;
            bool NeedIteration = true;
            while (NeedIteration)
            {
                NeedIteration = false;
                for (int i = 1; i < length; i++)
                {
                    if (radioButton1.Checked)
                    {
                        if (Y[i - 1] > Y[i])
                        {
                            temp = Y[i];
                            Y[i] = Y[i - 1];
                            Y[i - 1] = temp;
                            NeedIteration = true;
                        }
                    }
                    else
                    {
                        if (Y[i - 1] < Y[i])
                        {
                            temp = Y[i];
                            Y[i] = Y[i - 1];
                            Y[i - 1] = temp;
                            NeedIteration = true;
                        }
                    }
                }
            }
            outY();
        }
        private void button4_Click(object sender, EventArgs e) //Задание
        {
            double answer = 0;
            for (int i = 0; i < length; i++) {
                if (Y[i] % 5 == 0)
                    answer += Y[i];
            }
            label10.Text = "Сумма элементов,\nкоторые кратны 5: " + answer;
            label10.Visible = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (Int32.TryParse(textBox1.Text, out int n) || textBox1.TextLength == 0)
                label8.Visible = false;
            else label8.Visible = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double a) || textBox2.TextLength == 0)
                label5.Visible = false;
            else label5.Visible = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double a) || textBox3.TextLength == 0)
                label6.Visible = false;
            else label6.Visible = true;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double a) || textBox4.TextLength == 0)
                label7.Visible = false;
            else label7.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void outY() {
            for (int i = 0; i < length; i++) {
                listBox2.Items[i] = Y[i];
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
