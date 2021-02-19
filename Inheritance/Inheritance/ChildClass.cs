using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass : ParentClass
    {
        public ChildClass() //constructor
        {
            Console.WriteLine("Child class Constructor ");
        }
        public void Test3()
        {
            Console.WriteLine("Test 3 method");
        }
        static void Main()
        {
            ChildClass cc = new ChildClass();
            cc.Test1(); cc.Test2(); cc.Test3();
            Console.ReadLine();
        }
    }
}
