using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch
            {
                Console.Write("Error occurred.");
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
            Console.ReadLine();
        }
    }
}
