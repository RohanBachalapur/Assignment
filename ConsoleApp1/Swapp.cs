using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swapp
    {
        public static void swap(ref string a, ref string b)
        {
            string t = a;
            a = b;
            b = t;
        }
        public static void Main()
        {
            Console.WriteLine("Enter 1st word");
            string a = Console.ReadLine();
            Console.WriteLine("Enter 2nd word");
            string b = Console.ReadLine();
            Console.WriteLine($"Before swaping a={a},b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"After swapping a={a},b={b}");
        }
    }
}
