using System;
using System.Threading;

class ThreadTest
{
    static void Test1()
    {
        for (int i = 1; i<= 10; i++)
        {
            Console.WriteLine("Test1: " + i);
        }
    }

    static void Test2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Test2: " + i);
        }
    }

    static void Test3()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Test3: " + i);
        }
    }
    static void Main()
    {
        Thread T1 = new Thread(Test1);
        Thread T2 = new Thread(Test2);
        Thread T3 = new Thread(Test3);

        T1.Start(); T2.Start(); T3.Start();
        Console.ReadLine();
    }
}