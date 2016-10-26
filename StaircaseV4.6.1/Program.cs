using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaircaseV4._6._1
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
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
    }
}
