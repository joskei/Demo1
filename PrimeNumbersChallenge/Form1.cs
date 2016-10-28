using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeNumbersChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateBelow_Click(object sender, EventArgs e)
        {
            var watch0 = System.Diagnostics.Stopwatch.StartNew();

            lstPrimes.DataSource = GetAllPrimes(int.Parse(txtNumberOfPrimes.Text));

            watch0.Stop();
            var millis = watch0.Elapsed.TotalMilliseconds;

            txtTimeElapsed.Text = @"Total time taken: " + millis + @"ms";
            txtNumOfItems.Text = lstPrimes.Items.Count.ToString();
        }

        private void btnNthPrime_Click(object sender, EventArgs e)
        {
            var watch0 = System.Diagnostics.Stopwatch.StartNew();

            lstPrimes.DataSource = GetNthPrime(int.Parse(txtNthNumber.Text));

            watch0.Stop();
            var millis = watch0.Elapsed.TotalMilliseconds;

            txtTimeElapsed.Text = @"Total time taken: " + millis + @"ms";
            txtNumOfItems.Text = lstPrimes.Items.Count.ToString();

            lblNthPrime.Text = lstPrimes.Items[int.Parse(txtNthNumber.Text) - 1].ToString();
        }

        private List<int> GetAllPrimes(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new System.Collections.BitArray(max + 1);

            vals.Add(2);

            for (var i = 3; i <= max; i += 2)
            {
                if (eliminated[i]) continue;
                if (i < maxSquareRoot)
                {
                    for (var j = i * i; j <= max; j += 2 * i)
                        eliminated[j] = true;
                }
                vals.Add(i);
            }
            return vals;
        }

        private List<int> GetNthPrime(int nth)
        {
            var vals = new List<int>(nth);
            //Math.Round(nth * Math.Log(nth) * Math.Log(nth))
            //https://primes.utm.edu/nthprime/index.php
            var nthPrimeEstimateEnd = nth * (Math.Log(nth) + (Math.Log(Math.Log(nth))));
            var approximateNthCount = Convert.ToInt32(Math.Round(nthPrimeEstimateEnd));

            //MessageBox.Show(approximateNthCount.ToString());

            var maxSquareRoot = Math.Sqrt(approximateNthCount);
            var eliminated = new BitArray(approximateNthCount + 1);
            //var num = int.Parse(txtNumberOfPrimes.Text);

            vals.Add(2);
            var iter = 1;

            //https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
            //Steps:
            //1. Create a list of consecutive integers from 2 through n: (2, 3, 4, ..., n).
            //2. Initially, let p equal 2, the smallest prime number.
            //3. Enumerate the multiples of p by counting to n from 2p in increments of p, and mark them in the 
            //   list (these will be 2p, 3p, 4p, ... ; the p itself should not be marked).
            //   This means that all value that are multiples of 2 will be marked and eliminated
            //4. Find the first number greater than p in the list that is not marked. If there was no such number, 
            //   stop. Otherwise, let p now equal this new number (which is the next prime), and repeat from step 3.
            //5. When the algorithm terminates, the numbers remaining not marked in the list are all the primes below n.

            for (var i = 3; i <= approximateNthCount; i += 2)
            {
                if (eliminated[i]) continue;
                if (i < maxSquareRoot)
                {
                    for (var j = i * i; j <= approximateNthCount; j += 2 * i)
                        eliminated[j] = true;
                }
                vals.Add(i);
                iter += 1;

                if (iter == nth)
                {
                    break;
                }
            }
            return vals;
        }

        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            lblTimer.Visible = !lblTimer.Visible;
            txtTimeElapsed.Visible = !txtTimeElapsed.Visible;
        }
    }
}
