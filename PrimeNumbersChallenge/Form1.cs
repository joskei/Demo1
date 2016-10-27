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
            var approximateNthCount = Convert.ToInt32(Math.Round(nth * Math.Log(nth) * Math.Log(nth)));
            var maxSquareRoot = Math.Sqrt(approximateNthCount);
            var eliminated = new System.Collections.BitArray(approximateNthCount + 1);
            var num = int.Parse(txtNumberOfPrimes.Text);

            vals.Add(2);
            var iter = 1;

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

        
    }
}
