using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Сгенерированный массив:");
            Random r = new Random();
            int[,] array = new int[10, 10];
            for ( i = 0; i < 10; i++)
            {
                for ( j = 0; j < 10; j++)
                {
                    array[i, j] = r.Next(-10, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            long answer = 0;
            for (j = 0; j < 10; j++)
            {
                answer += array[1, j];
            }
            Console.WriteLine("Сумма второй строки: " + answer);
            answer = 1;
            for (i = 0; i < 10; i++) {
                answer *= array[i, 0];
            }
            Console.WriteLine("Произведение первого столбца: " + answer);
            Console.ReadKey();
        }
    }
}
