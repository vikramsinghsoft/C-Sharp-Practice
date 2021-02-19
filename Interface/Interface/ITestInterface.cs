using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ITestInterface1
    {
        void Add(int x, int y);
    }

    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int x, int y);
    }

    class ImplementationClass : ITestInterface2  //ITestInterface
    {
        public void Add(int x, int y)   
        {
            Console.WriteLine(x + y);
        }

        public void Sub(int x,int y)  
        {
            Console.WriteLine(x - y);
        }

        static void Main()
        {
            ImplementationClass ic = new ImplementationClass();
            ic.Sub(10, 5);
            ic.Add(10, 20);
            Console.ReadLine();
        }
    }
}
