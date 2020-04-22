using System;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, u;
            Console.WriteLine("Введите:");
            Console.Write("x= ");
            while (!double.TryParse(Console.ReadLine(), out x)) {
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("x= ");
            }
            Console.Write("y= ");
            while (!double.TryParse(Console.ReadLine(), out y)){
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("y= ");
            }
            Console.Write("z= ");
            while (!double.TryParse(Console.ReadLine(), out z)) { 
                Console.WriteLine("Неккоректный ввод! Введите число:");
                Console.Write("z= ");
            }
           
            u = (Math.Pow(8 + Math.Abs(x - y) * Math.Abs(x - y) + 1, 1.0 / 3) / (x * x + y * y + 2)) 
                - Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Tan(z) * Math.Tan(z) + 1, x);
            
            Console.WriteLine("u= {0}", u);
            Console.ReadKey();
        }
    }
}
