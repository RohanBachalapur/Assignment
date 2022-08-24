using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArryDemo
    {
        public static  void Main()
        {
            string[] names = new string[5];
            names[0] = "Rohan";
            names[1] = "Rahul";
            names[2] = "Dhanush";
            names[3] = "Shishir";
            names[4] = "Vinay";
            Console.WriteLine(names.Count());
            foreach (string name in names)
                Console.WriteLine(name.ToUpper());
            Array.Reverse(names);
            foreach (string name in names)
                Console.WriteLine(name.ToUpper());
            Array.Sort(names);


            if (names.Contains("mm"))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
