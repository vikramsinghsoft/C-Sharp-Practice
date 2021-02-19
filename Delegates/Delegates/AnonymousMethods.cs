using System;

namespace Delegates
{
    public delegate string GreetingsDelegate(string name);

    class AnonymousMethods
    {

        static void Main(string[] args)
        {
            GreetingsDelegate gd = delegate (string name)
             {
                 return "Hello " + name + " a very good morning !";
 
             };


            string s=gd("Vikram");  // gd.Invoke("Vikram");   
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
