using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            do
            {
                f = 0;
                double x, y, u;
                Console.WriteLine("Введите:");
                Console.Write("x= ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Неккоректный ввод! Введите число:");
                    Console.Write("x= ");
                }
                Console.Write("y= ");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Неккоректный ввод! Введите число:");
                    Console.Write("y= ");
                }
                if (y == 0)
                    u = 0;
                else
                {
                    do
                    {
                        Console.WriteLine("Выберите функцию:");
                        Console.WriteLine("1) sh x");
                        Console.WriteLine("2) x^2");
                        Console.WriteLine("3) e^x");
                        f = Convert.ToInt32(Console.ReadLine());
                        if (f != 1 && f != 2 && f != 3)
                            Console.WriteLine("Неверный ввод:");
                    } while (f != 1 && f != 2 && f != 3);
                    if (f == 1)
                        f = Math.Sinh(x);
                    else if (f == 2)
                        f = x * x;
                    else f = Math.Pow(Math.E, x);

                    if (x == 0)
                        u = Math.Pow((f * f) + y, 3);
                    else if (x / y < 0)
                        u = Math.Log10(Math.Abs(f / y)) + Math.Pow(f + y, 3);
                    else
                        u = Math.Log10(f) + Math.Pow((f * f) + y, 3);
                }
                Console.WriteLine($"u= {u}");

                Console.WriteLine("Если хотите выйти нажмите Enter (либо введите 0)");
                double.TryParse(Console.ReadLine(), out f);
            } while (f != 0);
           // Console.ReadKey();
        }
    }
}
