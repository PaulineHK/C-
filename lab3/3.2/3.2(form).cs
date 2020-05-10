using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2
{
    public partial class Form1 : Form
    {
        string Str;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            textBox3.Text += "Сформируйте в текстовом поле TextBox строку согласно следующим правилам:\r\n" +
                   "– исходный текст состоит из строки, содержащей не более 200 символов;\r\n" +
                   "– в конце каждого предложения есть точка;\r\n" +
                   "– каждому слову, кроме первого, предшествует один пробел;\r\n" +
                   "– внутри слов пробелов нет;\r\n" +
                   "– знаки препинания, если они есть, пишутся сразу после слова.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Str = textBox1.Text;
            textBox3.Clear();
            bool check = true;
            if (Str == String.Empty)
            {
                check = false;
                textBox3.Text += Environment.NewLine + "Строка пуста";
            }
            else
            {
             /*
                if (Str.Length > 200)
                {
                    check = false;
                    textBox3.Text += Environment.NewLine + "Сообщение содержит больше 200 символов";
                }
            */
                if (Str[0] == ' ')
                {
                    check = false;
                    textBox3.Text += Environment.NewLine + "Перед первым словом не должно быть пробелов.";
                    if (!char.IsUpper(Str[1]))
                    {

                        textBox3.Text += Environment.NewLine + "Первое слово не с большой буквы";
                    }

                }
                else if (!char.IsUpper(Str[0]))
                {
                    check = false;
                    textBox3.Text += Environment.NewLine + "Первое слово не с большой буквы";
                }

                try
                {
                    for (int i = 0; i < Str.Length; i++)
                    {
                        if ((Str[i] == '.' || Str[i] == ',' || Str[i] == ':') && Str[i - 1] == ' ')
                        {//Проверка на пробел после знака 
                            check = false;
                            textBox3.Text += Environment.NewLine + 
                                "Лишний пробел между словом и знаком препинания";
                        }
                        if (Str[i] == '!' || Str[i] == '?' || Str[i] == ';')
                        { //Проверка на точки

                            check = false;
                            textBox3.Text += Environment.NewLine + 
                                "Любое предложение должно заканчиваться точкой";
                        }
                        if (Str[i] == '.' && i != Str.Trim().Length - 1 && Str[i + 1] != ' ')
                        {//Проверка на пробел после точки
                            check = false;
                            textBox3.Text += Environment.NewLine + 
                                "После точки не следует пробел";
                        }
                        else if (Str[i] == '.' && i != Str.Trim().Length - 1 && !char.IsUpper(Str[i + 2]))
                        {//Проверка на заглавную букву 
                            check = false;
                            textBox3.Text += Environment.NewLine + 
                                "Предложение не начинается с большой буквы";
                        }
                        if (Str[i] == ' ' && i != Str.Trim().Length - 1 && Str[i + 1] == ' ')
                        {//проверка на пробелы между словами
                            check = false;
                            textBox3.Text += Environment.NewLine + "Лишний пробел между словами";
                        }

                    }
                }
                catch (System.IndexOutOfRangeException) { }
            }
            if(!check)textBox3.Text += Environment.NewLine + "Сформируйте в текстовом поле TextBox " +
                "строку согласно следующим правилам:\r\n" +
                  "– исходный текст состоит из строки, содержащей не более 200 символов;\r\n" +
                  "– в конце каждого предложения есть точка;\r\n" +
                  "– каждому слову, кроме первого, предшествует один пробел;\r\n" +
                  "– внутри слов пробелов нет;\r\n" +
                  "– знаки препинания, если они есть, пишутся сразу после слова.";

            if (check)
            {
                textBox3.Text +="Вариант 2. Если длина строки L больше 15 символов, " +
                    "то удаляется подстрока в [ ] скобках.\r\nРазделить слова запятыми.";
            }
            button2.Enabled = true;
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            
            //textBox3.Clear();
            textBox2.Clear();           
            if (Str.Trim().Length > 15)
            {
                bool ok = false;
                for (int i = 0; i < Str.Length; i++)
                {
                    if (Str[i] == '[')
                    {
                        ok = true;

                        for (int j = i + 1; j < Str.Length; j++)
                        {
                            if (Str[j] == ']')
                            {
                                ok = false;
                                Str = Str.Remove(i + 1, j - i - 1);
                                break;
                            }
                        }
                        if (ok)
                        {
                            textBox3.Text += Environment.NewLine + "Скобка ] не была найдена";
                            break;
                        }
                        ok = true;
                    }

                }
                if (!ok) textBox3.Text += Environment.NewLine + "Скобка [ не была найдена";
            }
            else textBox3.Text += Environment.NewLine + "Длина строки меньше 15 символов.";
            for (int i = 0; i < Str.Trim().Length; i++)
            {
                if ((Str[i] == ' ') && (Str[i - 1] != '.' && Str[i - 1] != ',' && Str[i - 1] != ':'))
                {
                    Str = Str.Insert(i, ",");
                }
            }
            textBox2.Text += Environment.NewLine + Str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
