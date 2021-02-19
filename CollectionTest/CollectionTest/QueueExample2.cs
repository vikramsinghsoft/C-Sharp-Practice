using System;
using System.Collections;

namespace CollectionTest
{
    class QueueExample2
    {
        static void Main(string[] args)
        {
            //Creating a queue collection
            Queue q = new Queue();
            //Adding item to the qieue using the Enqueue method
            q.Enqueue(10);
            q.Enqueue("hi");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            q.Enqueue(67.8);
            q.Enqueue('A');
            //Printing the queue items using foreach loop
            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Using Count property to get the number of items
            //present in the queue collection
            Console.WriteLine($"No of Elements Present in the Collection : {q.Count}");
            Console.WriteLine();

            //Using the Contains method to check whether an item is present or not
            Console.WriteLine($"Is the value hi present in the collection : {q.Contains("hi")}");
            Console.WriteLine();

            //Removing all the items from the collection using Clear() method
            q.Clear();
            Console.WriteLine($"No of Elements in the Collection after Clear() method : {q.Count}");
            Console.ReadKey();
        }
    }
}
