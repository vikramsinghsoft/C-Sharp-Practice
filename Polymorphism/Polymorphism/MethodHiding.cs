using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MethodHiding
    {
        public virtual void Test1()  //overridable
        {
            Console.WriteLine("Method Test1 from parent class.");
        }
        public void Test2()  //normal
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
    }

    class MethodHidingTest : MethodHiding
    {
        public override void Test1()  //overriden
            // it's not pure child class member
        {
            Console.WriteLine("Method Test1 from child class.");
        }

        public new void Test2()  //Hiding/Shadowing 
            // it's pure child class method
        {
            Console.WriteLine("Method Test2 from child class.");
        }

        public void ParentTest1()  //call parent class method by base keyword under child class
        {
            base.Test1();   //we can't use base keyword under static block
        }
       


        static void Main(string[] args)
        {
            MethodHidingTest mht = new MethodHidingTest();
            mht.Test1();
            mht.Test2();
            mht.ParentTest1();

            // whats diff bw overriding and hiding/shadowing

            MethodHiding mh = mht;
            mh.Test1();  // Invoke child classes method
            mh.Test2();  // Invoke parent classes method

            //   parent's reference can't access pure child class member
            Console.ReadLine();
        }
    }
}
