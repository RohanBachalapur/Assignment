using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MinAndMax
    {
        public static void Main()
        {
            int[] arr = { 455, 837, 9882, 175, 987, 867 };
            int i, max, min, n;
            // size of the array
            n = arr.Length;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum number = {0}\n", max);
            Console.Write("Minimum number = {0}\n", min);
        }
    }
}
