using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum Days
    {
        // Monday,Tuesday,Wednesday,Thursday,Friday,Saturday  //index start from 0

        Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6  //index start from 1 if we want

    }
    class EnumTest
    {
        static void Main(string[] args)
        {
            // Days d = 0;
            // Days d = (Days)1; // if we want print after 0 index
            // Days d = Days.Saturday;  // another way
            // Days d =Days.Friday;
            // Console.WriteLine((int)d);  // integer representation
            //  Console.WriteLine(d);

            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i+" : "+(Days)i);
            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
