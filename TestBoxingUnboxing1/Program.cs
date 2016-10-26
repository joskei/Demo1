using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBoxingUnboxing1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeatTime = 1000000000;

            //Test for Boxing
            var watch0 = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < repeatTime; i++)
            {
                BoxingTest();                
            }

            watch0.Stop();
            Console.WriteLine("Time taken with Boxing: {0}ms", watch0.Elapsed.TotalMilliseconds);

            //Test for UnBoxing
            var watch1 = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < repeatTime; i++)
            {
                UnBoxingTest();
            }

            watch1.Stop();
            Console.WriteLine("Time taken with UnBoxing: {0}ms", watch1.Elapsed.TotalMilliseconds);

            //Test for NO Boxing or Unboxing
            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < repeatTime; i++)
            {
                NoBoxUnbox();
            }

            watch2.Stop();
            Console.WriteLine("Time taken without Boxing or unboxing: {0}ms", watch2.Elapsed.TotalMilliseconds);


            /********************************************************************************************************/
            /********************************************************************************************************/


            var repeatTimeConcat = 50000;
            //Test for Concatenation of String
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            var a = "";
            for (var i = 0; i < repeatTimeConcat; i++)
            {
                a = a + i;
            }
            var b = a;

            watch3.Stop();
            Console.WriteLine("Time taken with concatenation using +: {0}ms", watch3.Elapsed.TotalMilliseconds);
            
            //Test for Concatenation of String using StringBuilder
            var watch4 = System.Diagnostics.Stopwatch.StartNew();
            var sb = new StringBuilder();
            for (var i = 0; i < repeatTimeConcat; i++)
            {
                sb.Append(i);
            }
            var bb = sb.ToString();

            watch4.Stop();
            Console.WriteLine("Time taken with concatenation using StringBuilder: {0}ms", watch4.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }

        private static void BoxingTest()
        {
            const int z = 312;

            object j = z;
        }

        private static void UnBoxingTest()
        {
            object j = 555;
            var z = j;
        }

        private static void NoBoxUnbox()
        {
            const int z = 312;
            var y = z;
        }

        
    }
}
