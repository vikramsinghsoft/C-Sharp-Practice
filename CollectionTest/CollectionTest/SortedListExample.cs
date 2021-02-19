using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest
{
    class SortedListExample
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "Vikram");
            names.Add("4", "Ankit");
            names.Add("5", "Abhi");
            names.Add("3", "Diksha");
            names.Add("2", "Lucky");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
