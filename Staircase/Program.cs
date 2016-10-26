using System;
using System.Collections.Generic;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            StairCase(4);
            Console.ReadLine();
        }

        public static void StairCase(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                var a = new string(' ', n - i) + new string('#', i);
                Console.WriteLine(a);
            }
        }
    }
}
