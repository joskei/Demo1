using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of number separated by spaces: ");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Error! User did not enter a value.");
                Thread.Sleep(2000);
                return;
            }
            var ar = input.Split(' ');

            var res = 0;
            for (var i = 0; i < ar.Length; i++) /* Variable size has the value of the size of the array*/
            {
                res = res ^ int.Parse(ar[i]);
            }

            Console.WriteLine("Lonely Integer is : " + res);
            Console.ReadLine();

        }
    }
}
