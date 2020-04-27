using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xo, Xn, dX, a, b, c, y;
            Console.WriteLine("Введите:");
            Console.Write("Xo=");
            while (!double.TryParse(Console.ReadLine(), out Xo))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("Xo= ");
            }
            Console.Write("Xn=");
            while (!double.TryParse(Console.ReadLine(), out Xn))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("Xn= ");
            }
            Console.Write("dX=");
            while (!double.TryParse(Console.ReadLine(), out dX))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("dX= ");
            }
            Console.Write("a=");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("a= ");
            }
            Console.Write("b=");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("b= ");
            }
            Console.Write("c=");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("c= ");
            }
            Console.WriteLine("Результат:");
            double temp = c * Math.Pow(a - b, 3);
            do
            {
                y = temp * Math.Pow(Math.E, Xo * Xo) + Xo;
                if (double.IsNaN(y))
                {
                    Console.WriteLine("Больше нельзя посчитать: e^(x^2)");
                    break;
                }
                Console.WriteLine($"{Xo}    {y}");
                Xo += dX;
            } while ((Xo <= Xn && Xo > 0) || (Xo >= Xn && Xo < 0));
            Console.ReadKey();
        }
    }
}
