using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment4
    {
        public static void Main()
        {
            string myStr;
            int i, len, word_count;
            Console.WriteLine("Enter the String");
            myStr = Console.ReadLine();
            // find length
            len = myStr.Length;
            
            Console.Write($"The Length is {len}");
        }
    }
}

