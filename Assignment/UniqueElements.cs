using System;
namespace ConsoleApp2
{
    class UniqueElements
    {
        public static void Main()


        {
            int[] items = { 991, 998, 1335, 2312, 2337, 1335, 992, 2312,993, 996 };
            int n = items.Length;

            Console.WriteLine("Unique array elements are: ");

            for (int i = 0; i < n; i++)
            {
                bool Same = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        Same = true;
                        break;
                    }
                }

                if (!Same)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
}
