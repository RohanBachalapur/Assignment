using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionDemo
    {
        static int MyMethod1(int x,int y,int z)
        {
            int res = x * y * z;
            return res;

        }
      
        static void Main()
        {
           Console.WriteLine( MyMethod1(3,4,5));
            
        }
    }
}
