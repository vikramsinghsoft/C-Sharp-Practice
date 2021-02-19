using System;
using System.Collections;


namespace CollectionTest
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            //Creating a queue collection
            Queue q = new Queue();

            //Adding item to the queue using the Enqueue method
            q.Enqueue(10);
            q.Enqueue("hello");
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

            //Removing and returning an item from the queue
            //using the Dequeue method
            Console.WriteLine(q.Dequeue());
            Console.WriteLine();
            //Printing item after removing the first added item
            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Returning the first item from the queue without removing it
            //by using the peek method
            Console.WriteLine(q.Peek());
            Console.WriteLine();

            //Printing the items after using the Peek method
            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.ReadKey();
        }
    }
}
