using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnPrimes_Click(object sender, EventArgs e)
        {
            var watch0 = System.Diagnostics.Stopwatch.StartNew();

            lstPrimes.DataSource = GetAllPrimes(int.Parse(txtNumberOfPrimes.Text));

            watch0.Stop();
            var millis = watch0.Elapsed.TotalMilliseconds;

            txtTimeElapsed.Text = @"Total time taken: " + millis + @"ms";
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
    }
}
