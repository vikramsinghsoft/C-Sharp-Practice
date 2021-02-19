using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class SortedSetExample
    {
        public static void Main(string[] args)
        {
            // Create a set of strings  
            var names = new SortedSet<string>();
            names.Add("Vikram");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        /*
        // Let's see another example of generic SortedSet<T> class that stores elements using Collection initializer.

        public static void Main(string[] args)
        {
            // Create a set of strings  
            var names = new SortedSet<string>() { "Vikram", "Ankit", "Peter", "Irfan" };

            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        */
    }
}
