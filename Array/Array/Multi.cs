﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Multi
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
            int a = 0;
            //printing the values of 2d array using foreach loop
            //It will print the default values as we are not assigning
            //any values to the array
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //assigning values to the array by using nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a += 5;
                    arr[i, j] = a;
                }
            }
            //printing the values of array by using nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.ReadKey();
        }

        // assigning values at time of declaration

        /*
                 static void Main(string[] args)
        {
            //Assigning the array elements at the time of declaration
            int[,] arr = {{11,12,13,14},
                          {21,22,23,24},
                          {31,32,33,34}};
            //printing values of array using for each loop
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //printing the values of array using nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
        */
    }
}
