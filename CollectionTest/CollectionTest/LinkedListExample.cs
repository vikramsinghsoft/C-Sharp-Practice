using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class LinkedListExample
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Vikram Singh");
            names.AddLast("Ankit");
            names.AddLast("Dheeraj");
            names.AddLast("Diksha");
            names.AddFirst("Abhi");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
