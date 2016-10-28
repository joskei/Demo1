using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Consider an array of  integers, A = [a0,a1,a2,…,an-1] , where all but one of the integers occur in pairs. 
             In other words, every element in A occurs exactly twice except for one unique element.

                Sample Input: 4 5 6 5 6 3 4
                Sample Output: 3

             */
            Console.Write("Please enter an array of number separated by spaces: ");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Error! User did not enter a value.");
                Thread.Sleep(2000);
                return;
            }
            var ar = input.Split(' ');

            var res = 0;

            var tmpAr = new List<int>();
            //Convert to List<int>
            foreach (var item  in ar)
            {
                tmpAr.Add(int.Parse(item));
            }

            //Code Here

            //foreach (var item in ar)
            //{
            //    res = res ^ int.Parse(item);
            //}

            tmpAr.ForEach(a => res = res ^ a);

            Console.WriteLine("Lonely Integer is : " + res);
            Console.ReadLine();

        }
    }
}
