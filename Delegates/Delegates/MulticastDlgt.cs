using System;

namespace Delegates
{
    public delegate void Math(int x, int y);

    class MulticastDlgt
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Add :" + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub :" + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Mul :" + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("Div :" + (x / y));
        }

        static void Main(string[] args)
        {
            MulticastDlgt md = new MulticastDlgt();

            Math m = md.Add;
            m += md.Sub;
            m += md.Mul;
            m += md.Div;

            m.Invoke(10, 10);
            Console.ReadLine();
        }
    }
}
