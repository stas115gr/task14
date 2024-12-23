using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
        public static void Func()
        {
            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine($"X={x}");
            }
        }

        /*public static void Func()
        {
            int x = 1;
            do
            {
                Console.WriteLine($"X={x}");
                x++;
            }
            while (x <= 10);
        }*/

        /*public static void Func()
        {
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine($"X={x}");
                x++;
            }*/
    }
}


