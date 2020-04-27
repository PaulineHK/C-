using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2._1
{
    class Lab {

        int length = 0;
        double[] X;
        double[] Y;
        //bool ok = false;

        public void setXY() {
            Console.Write("Введите размерность массива: ");
            while (!Int32.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Неккоректный ввод!\nВведите размерность массива: ");
            }
            X = new double[length];
            Y = new double[length];
            double a, b, c;
            Console.Write("a= ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:\na= ");
            }
            Console.Write("b=");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:\nb= ");
            }
            Console.Write("c=");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:\nc= ");
            }
            Random r = new Random();
            double temp = c * Math.Pow(a - b, 3);
            int i;
            for (i = 0; i < length; i++) {
                X[i] = Math.Round(r.NextDouble(), 3);
                Y[i] = Math.Round(temp * Math.Pow(Math.E, X[i] * X[i]) + X[i]);
                if (double.IsNaN(Y[i])) {
                    Console.WriteLine("Не могу посчитать" + i + " элемент. Переведу его в ноль.");
                    Y[i] = 0;
                }
            }
        }
        public void Sort()
        {
            int n = 0;
            do
            {
                Console.WriteLine("1)По возрастанию\n2)По убыванию");
                Int32.TryParse(Console.ReadLine(), out n);
            } while (n != 1 && n != 2);
            double temp;
            bool NeedIteration = true;
            while (NeedIteration)
            {
                NeedIteration = false;
                for (int i = 1; i < length; i++)
                {
                    if (n == 1)
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
        public void changeSign() {

            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                Y[i] = Math.Abs(Y[i]);
                int r = rand.Next(2);
                if (r == 1)
                    Y[i] = Y[i] * (-1);
            }
            outY();
        }
        public void Task() {
            double answer = 0;
            for (int i = 0; i < length; i++) {
                if (Y[i] % 5 == 0) answer += Y[i];
            }
            Console.WriteLine("Сумма элементов, которые кратны 5: " + answer);
        }

        public void outX() {
            for (int i = 0; i < length; i++) {
                Console.Write(X[i] + " ");
            }
            Console.Write("\r\n");
        }
        public void outY(){
            for (int i = 0; i < length; i++) {
                Console.Write(Y[i] + " ");
            }
            Console.Write("\r\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lab lab = new Lab();
            string number = "0";
            bool ok = false;
            do
            {
                Console.WriteLine("1) Заполнение X и Y\n2) Изменение знака\n3) Сортировка\n4) Задание\n0 - Выход");
                number = Console.ReadLine();
                if (number == "1")
                {
                    lab.setXY();
                    lab.outX();
                    lab.outY();
                    ok = true;
                }
                else if (number == "2" && ok)
                {
                    lab.changeSign();
                }
                else if (ok && number == "3") 
                    lab.Sort();
                else if (ok && number == "4")
                    lab.Task();
                else if (number != "0")
                    Console.WriteLine("Сначала выберите пункт 1 для инициализации массивов");
            } while (number != "0");
        }
    }
}
