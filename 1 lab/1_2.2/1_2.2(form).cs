using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            label5.Visible = false;
            label6.Visible = false;
            button1.Enabled = false;
            radioButton1.CheckedChanged += new EventHandler(change);
            radioButton2.CheckedChanged += new EventHandler(change);
            radioButton3.CheckedChanged += new EventHandler(change);
            textBox1.TextChanged += new EventHandler(change);
            textBox2.TextChanged += new EventHandler(change);
           
            textBox4.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Enabled = true;
            double x, y, u;
            y = double.Parse(textBox2.Text);
            x = double.Parse(textBox1.Text);          
            textBox4.Text += "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            if (y == 0)
            {
                u = 0;
                textBox4.Text += Environment.NewLine + "Результат:";
                textBox4.Text += Environment.NewLine +"U = " + u.ToString();
            }
            else
            {
                if (radioButton1.Checked)
                    x = Math.Sinh(x);
                else if (radioButton2.Checked)
                    x = x * x;
                else
                    x = Math.Pow(Math.E, x);

                if (x == 0)
                    u = Math.Pow((x * x) + y, 3);
                else if (x / y < 0)
                    u = Math.Log10(Math.Abs(x / y)) + Math.Pow(x + y, 3);
                else
                    u = Math.Log10(x) + Math.Pow((x * x) + y, 3);

                textBox4.Text += Environment.NewLine + "Результат:";
                textBox4.Text += Environment.NewLine + "U = " + u.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a;

          
            if (!double.TryParse(textBox1.Text, out a))
            {
                textBox1.Clear();
                label5.Visible = false;
            }
            if (!double.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
                label6.Visible = false;
            }

            if (textBox4.TextLength > 0){
                textBox1.Clear();
                textBox2.Clear();
                //textBox4.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                textBox4.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
      
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
              
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(textBox1.Text, out  x) || textBox1.TextLength == 0)
            {
                label5.Visible = false;
            }
            
            else
            {
              
                label5.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double y;
            if (double.TryParse(textBox2.Text, out y) || textBox2.TextLength == 0)
            {
              
                label6.Visible = false;
            }
            else
            {
              
                label6.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();        
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button1.Enabled = false;
            textBox4.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
         
        }

        private void change(object sender, EventArgs e)
        {
            double x;

            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out x) &&
                (radioButton3.Checked || radioButton2.Checked || radioButton1.Checked))
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
    }
}
