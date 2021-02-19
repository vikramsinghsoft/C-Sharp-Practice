using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ConstructorOverloading
    {
        int i;
        bool b;

        public ConstructorOverloading()
        {
            Console.WriteLine(" This is first constructor !!");
        }
        public ConstructorOverloading(int i)
        {
            this.i = i;
            Console.WriteLine(" This is secondt constructor !!");
        }
        public ConstructorOverloading(bool b)
        {
            this.b = b;
            Console.WriteLine(" This is third constructor !!");
        }
        public ConstructorOverloading(int i,bool b)
        {
            this.i = i;
            this.b = b;
            Console.WriteLine(" This is fourth constructor !!");
        }
        public ConstructorOverloading(int i,int j)
        {
            Console.WriteLine(" This is 5th constructor !! {0}", (i+j));
        }

        public void Display()
        {
            Console.WriteLine("Value of i is :{0} and b is :{1}", i, b);
        }

        static void Main(string[] args)
        {
            ConstructorOverloading c1 = new ConstructorOverloading();
            c1.Display();
            ConstructorOverloading c2 = new ConstructorOverloading(10);
            c2.Display();
            ConstructorOverloading c3 = new ConstructorOverloading(true);
            c3.Display();
            ConstructorOverloading c4 = new ConstructorOverloading(10,true);
            c4.Display();

            ConstructorOverloading c5 = new ConstructorOverloading(10,10);


            Console.ReadLine();
        }
    }
}
