using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class JaggedTest
    {
        public static void Main()
        {
            int[][] arr = new int[5][]{
        new int[] { 11, 21, 56, 78 },
        new int[] { 2, 5, 6, 7, 98, 5 },
        new int[] { 2, 5,8 },
        new int[] { 2, 5, 6, 7, 98, 5 },
        new int[] { 2, 5,8 }
        };

            // Traverse array elements  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
