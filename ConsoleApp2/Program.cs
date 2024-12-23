
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
        /*public static void Func()
        {
            int x = 1;
            int n = Input("Введите число n=");
            while (x <= n) 
            {
                Console.WriteLine(x);
                x++;
            }
        }*/

        /*public static void Func()
        {
            int x = 1;
            int n = Input("Введите число n=");
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= n);
        }*/

        public static void Func()
        {
            int n = Input("Введите число n=");
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine(x);
            }
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}