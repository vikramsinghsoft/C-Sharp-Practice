using System;
using System.Collections;


namespace CollectionTest
{
    class StackExample
    {
        static void Main(string[] args)
        {
            //Creating a stack collection
            Stack s = new Stack();
            //Adding item to the stack using the push method
            s.Push(10);
            s.Push("hello");
            s.Push(3.14f);
            s.Push(true);
            s.Push(67.8);
            s.Push('A');
            //Printing the stack items using foreach loop
            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Removing annd returning an item from the stack
            //using the pop method
            Console.WriteLine(s.Pop());
            Console.WriteLine();
            //Printing item after removing the last added item
            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Returning the last item from the stack without removing it
            //by using the peek method
            Console.WriteLine(s.Peek());
            Console.WriteLine();
            //Printing the items after using the Peek method
            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.ReadKey();
        }

        /*
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            Console.ReadLine();
        } */
    }
}

