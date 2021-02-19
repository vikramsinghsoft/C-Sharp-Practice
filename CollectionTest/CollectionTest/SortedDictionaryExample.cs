using System;
using System.Collections.Generic;


namespace CollectionTest
{
    class SortedDictionaryExample
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
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
