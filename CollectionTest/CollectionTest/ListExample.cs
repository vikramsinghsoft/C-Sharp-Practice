using System;
using System.Collections.Generic;


namespace CollectionTest
{
    class ListExample
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new List<string>();
            names.Add("Vikram Singh");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        /*
         // example using collection initializer

        public static void Main(string[] args)
        {
            // Create a list of strings using collection initializer  
            var names = new List<string>() { "Vikram Singh", "Vimal", "Ratan", "Love" };

            // Iterate through the list.  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        */
    }
}
