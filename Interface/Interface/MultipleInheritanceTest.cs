using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Interface1
    {
        void Test(int x, int y);
    }
    interface Interface2
    {
        void Test(int x, int y);
    }
    class MultipleInheritanceTest : Interface1 , Interface2
    {
         void Interface1.Test(int x, int y)
        {
            Console.WriteLine("Declare in Interface1 and implemented in class: "+(x + y));
        }

        void Interface2.Test(int x, int y)
        {
            Console.WriteLine("Declare in Interface2 and implemented in class: " + (x - y));
        }

        //public void Test(int x,int y)
        //{
        //    Console.WriteLine(x - y);
        //}
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            

            Interface1 i1 = obj;  i1.Test(5, 5);

            Interface2 i2 = obj;  i2.Test(10, 5);
            Console.ReadLine();
        }
    }
}
