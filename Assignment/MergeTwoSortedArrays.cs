using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class MergeTwoSortedArrays
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[6] { 73, 98, 76, 43, 68, 12 };

            int[] arr2 = new int[6] { 72,97, 75, 42, 67, 11};

            int[] merged = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
            }
            Console.WriteLine();
        }
    }
}
