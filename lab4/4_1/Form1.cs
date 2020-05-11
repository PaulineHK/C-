using System;
using System.Windows.Forms;

namespace _4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lA.Visible = false;
            lB.Visible = false;
            lC.Visible = false;
            lXmax.Visible = false;
            lXmin.Visible = false;
            lStep.Visible = false;
            button1.Enabled = false;
            boxA.TextChanged += new EventHandler(change);
            boxB.TextChanged += new EventHandler(change);
            boxC.TextChanged += new EventHandler(change);
            boxXmax.TextChanged += new EventHandler(change);
            boxXmin.TextChanged += new EventHandler(change);
            boxStep.TextChanged += new EventHandler(change);
        }
        private void change(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(boxA.Text, out x) && double.TryParse(boxB.Text, out x)
                && double.TryParse(boxC.Text, out x) && double.TryParse(boxXmax.Text, out x)
                && double.TryParse(boxXmin.Text, out x) && double.TryParse(boxStep.Text, out x))
                button1.Enabled = true;
            else button1.Enabled = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(boxXmin.Text);
            double Xmax = double.Parse(boxXmax.Text);
            double Step = double.Parse(boxStep.Text);
            double a = double.Parse(boxA.Text);
            double b = double.Parse(boxB.Text);
            double c = double.Parse(boxC.Text);
            // Вычисление количества точек графика
            int count = (int)Math.Ceiling(Math.Abs((Xmax - Xmin) / Step)) + 1;
            // Массив значений X - общий для обоих графиков
            double[] x = new double[count];
            // Два массива Y - по одному для каждого графика
            double[] y = new double[count];
            double temp= c * Math.Pow(a - b, 3);
            // Вычисление координат точек для графиков функции

            for (int i = 0; i < count; i++) {

                x[i] = Xmin + Step * i;
                y[i] = Math.Round(temp * Math.Pow(Math.E, x[i] * x[i]) + x[i], 3);
                if (y[i] > 10000)
                {
                    y[i] = 10001;
                }
            }       
           
            // Настройка оси абсцисс графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 4000;
            // Вычисление шага сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Добавление вычисленных значений в графики
            chart1.Series[0].Points.DataBindXY(x, y);
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(boxXmax.Text, out double x))
                lXmax.Visible = false;
            else lXmax.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(boxA.Text, out double x))
                lA.Visible = false;
            else lA.Visible = true;
        }

        private void boxXmin_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(boxXmin.Text, out double x))
                lXmin.Visible = false;
            else lXmin.Visible = true;
        }

        private void boxStep_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(boxStep.Text, out double x))
                lStep.Visible = false;
            else lStep.Visible = true;
        }

        private void boxB_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(boxB.Text, out double x))
                lB.Visible = false;
            else lB.Visible = true;
        }

        private void boxC_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(boxC.Text, out double x))
                lC.Visible = false;
            else lC.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
