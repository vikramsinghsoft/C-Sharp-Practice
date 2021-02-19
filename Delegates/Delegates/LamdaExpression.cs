using System;

namespace Delegates
{
    public delegate string WishDelegate(string name);

    class LamdaExpression
    {
        static void Main(string[] args)
        {
            WishDelegate wd = ( name) =>  //no need delegate keyword and type 
            {
                return "Hello " + name + " a very good morning !";
            };

            string str=wd.Invoke("Ankit");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
