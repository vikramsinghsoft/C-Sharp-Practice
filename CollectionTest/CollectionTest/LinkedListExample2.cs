using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class LinkedListExample2
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Vikram");
            names.AddLast("Ankit");
            names.AddLast("Abhi");
            names.AddLast("Irfan");

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Abhi");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
