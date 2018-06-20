using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Del(int x, int y)
        {
            try
            {
                int result = x / y;
            }
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Деление на ноль!");
            //}
            // Данный блок будет всегда выполняться
            finally
            {
                Console.WriteLine("Конец программы");
            }
        }


        static void Main(string[] args)
        {
            Del(5, 5);

            Console.ReadLine();
            Console.WriteLine("Ok ");
            Console.ReadLine();
        }
    }
}
