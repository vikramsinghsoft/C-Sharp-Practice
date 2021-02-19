using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Example1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
            Console.ReadLine();
        }
    }
}
