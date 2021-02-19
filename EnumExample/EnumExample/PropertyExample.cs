using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum DaysName
    {
        Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6  //index start from 1 if we want
    }

    class PropertyExample
    {
        public static DaysName MeetingDate { get; set; } = DaysName.Monday;


        static void Main(string[] args)
        {
            Console.WriteLine(MeetingDate);
            // i want reshcadule meeting date
            MeetingDate = DaysName.Tuesday;
            Console.WriteLine(MeetingDate);
            Console.ReadLine();
        }
    }
}