using System;

// Pre-define delegate
//Func= for return type 
//Action= for void typr 
//Predicate = for retturn bool type

namespace Delegates
{
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);


    class PredefineDelegate
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            // we can write anonymous method hear
            // like this
            //Func<int,float,double,double> d1 = (x,y,z)=>  x+y+z;   OR {return  x+y+z;};
            //double result = d1.Invoke(10, 12.5f, 20);
            //Console.WriteLine(result);

            Func<int,float,double,double> d1 = AddNums1;       
            double result = d1.Invoke(10, 12.5f, 20);
            Console.WriteLine(result);

            Action<int,float,double> d2 = AddNums2;
            d2.Invoke(10, 12.5f, 20);

            Predicate<string> d3 = CheckLength;
            bool b = d3.Invoke("Vikram");
            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
