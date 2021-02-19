using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    // Age must be greater than 18

    class CustomException : Exception
    {
        public CustomException(String message)
       : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new CustomException("Sorry, Age must be greater than 18");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (CustomException e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");

            Console.ReadLine();
        }
    }
}
