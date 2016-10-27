using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimizeCode
{
    class Program
    {
        private const int Iterations = 10000;

        static void Main(string[] args)
        {
            var watch0 = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < Iterations; i++)
            {
                try
                {
                    //throw new ApplicationException();
                    var dividend = 10;
                    var divisor = 0;
                    var quotient = dividend/divisor;
                }
                catch (DivideByZeroException)
                {
                }
            }



            watch0.Stop();
            var millis = watch0.Elapsed.TotalMilliseconds;

            Console.WriteLine("Total time taken: {0}", millis);
            Console.WriteLine("Exceptions per millisecond: {0}", Iterations / millis);
            Console.ReadLine();
        }

        
    }
}
