using System;

namespace Delegates
{
    // defining the delegate
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);

    class Example
    {
        public void Add(int a, int b)  // non-static method
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)  // static method
        {
            return "Hello " + name;
        }

        static void Main(string[] args)
        {
            Example e = new Example();    // call method by using object of class
            e.Add(10, 20);
            string str = Example.SayHello("Vikram");
            Console.WriteLine(str);

            // Instantiating the delegate
            AddDelegate ad = new AddDelegate(e.Add);
            SayDelegate sd = new SayDelegate(SayHello);

            // call delegate
            ad(10, 20);                  // ad.Invoke(10,20);  another way by invoke method
            string name=sd("Vikram");   //sd.Invoke("Vikram");
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
