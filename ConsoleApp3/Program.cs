using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
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
            int x = 1;
            while (x < 6)
            {
                Console.WriteLine("Привет");
                x++;
            }
        }
    }
}
