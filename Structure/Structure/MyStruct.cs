using System;
namespace Structure
{
    struct MyStruct
    {
        int i;  //we can declare fields but can't be initialized at the time of declaration
        public void Show()
        {
            Console.WriteLine("Method in structure :" +i);
        }

        static void Main(string[] args)
        {
            MyStruct ms = new MyStruct();  //with 'new' keyword
            ms.i = 10;
            ms.Show();

            MyStruct m1;  //without 'new' keyword
            m1.i = 10;
            m1.Show();
            Console.ReadLine();
        }
    }
}