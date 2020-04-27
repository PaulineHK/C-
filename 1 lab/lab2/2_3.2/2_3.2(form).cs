using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer1 = 0;
            long answer2 = 1;
            Random r = new Random();    
                dataGridView1.ColumnCount = dataGridView1.RowCount = 10;
            
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)                        
                    dataGridView1[i, j].Value = r.Next(-10, 10);
            for (int i = 0; i < 10; i++)
            {               
                answer2 *= (int)dataGridView1[0, i].Value;              
                answer1 += (int)dataGridView1[i, 1].Value;
            }
            label1.Text = "Сумма второй строки: " + answer1;
            label2.Text = "Произведение первого столбца: " + answer2;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
