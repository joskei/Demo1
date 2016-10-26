using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LonelyIntegerV4._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an array of number separated by spaces: ");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Error! User did not enter a value.");
                Thread.Sleep(2000);
                return;
            }
            var ar = input.Split(' ');

            var res = ar.Aggregate(0, (current, item) => current ^ int.Parse(item));

            Console.WriteLine("Lonely Integer is : " + res);
            Console.ReadLine();
        }
    }
}
