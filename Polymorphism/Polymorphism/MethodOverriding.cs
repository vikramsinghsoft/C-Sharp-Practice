using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MethodOverriding
    {
        public virtual void Test()  // Overridable
        {
            Console.WriteLine("Parent's Test method is called ");
        }
    }

    class MethodOverridingTest : MethodOverriding
    {
        public override void Test()
        {
            Console.WriteLine("Child's Test method is called");
          //  base.Test();
        }

        static void Main()
        {
            MethodOverridingTest mot = new MethodOverridingTest();
            mot.Test();
            Console.ReadLine();
        }
    }
}
