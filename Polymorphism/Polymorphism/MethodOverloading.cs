using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MethodOverloading
    {
        public void Test()
        {
            Console.WriteLine(" 1st Method");
        }
        public void Test(int i)
        {
            Console.WriteLine(" 2nd Method");
        }
        public void Test(string s)
        {
            Console.WriteLine(" 3rd Method");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine(" 4th Method");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine(" 5th Method");
        }

        static void Main()
        {
            MethodOverloading md = new MethodOverloading();
            md.Test();
            md.Test(10);
            md.Test("Vikram");
            md.Test(10,"Vikram");
            md.Test("Vikram",10);
            Console.ReadLine();
        }
    }
}
