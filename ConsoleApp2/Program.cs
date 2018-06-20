using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("file.txt");
            try
            {
                throw new DivideByZeroException();
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                file.WriteLine("Error");
                file.Close();
            }
            Console.ReadKey();
        }
    }
}
