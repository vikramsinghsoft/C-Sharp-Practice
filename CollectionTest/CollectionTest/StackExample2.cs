using System;
using System.Collections;


namespace CollectionTest
{
    class StackExample2
    {
        static void Main(string[] args)
        {
            //Creating a stack collection
            Stack s = new Stack();
            //Adding item to the stack using the push method
            s.Push(20);
            s.Push("hi");
            s.Push(3.14f);
            s.Push(true);
            s.Push(12.3);
            s.Push('P');
            //Printing the stack items using foreach loop
            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Using Count property to get the number of items
            //present in the collection
            Console.WriteLine($"No of Elements in the Collection : {s.Count}");
            Console.WriteLine();

            //Using the Contains method to check whether an item is present or not
            Console.WriteLine($"Is the value hi present in the collection : {s.Contains("hi")}");
            Console.WriteLine();

            //Removing all the items from the collection using Clear() method
            s.Clear();
            Console.WriteLine($"No of Elements in the Collection after Clear() method : {s.Count}");

            Console.ReadKey();
        }
    }
}
