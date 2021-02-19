using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class HashSetExample
    {
        public static void Main(string[] args)
        {
            // Create a set of strings  
            var names = new HashSet<string>();
            names.Add("Vikram");
            names.Add("Dheeraj");
            names.Add("Diksha");
            names.Add("Lucky");
            names.Add("Vinay");//will not be added  

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }


        /*
         
        // Let's see another example of generic HashSet<T> class that stores elements using Collection initializer.

          public static void Main(string[] args)  
         {  
        // Create a set of strings  
        var names = new HashSet<string>(){"Vikram", "Diksha", "Dheeraj", "Lucky"};  
          
        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
       }  
         */
    }
}
