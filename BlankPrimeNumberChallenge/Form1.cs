using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlankPrimeNumberChallenge
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
            return null;
        }

        private List<int> GetNthPrime(int nth)
        {
            return null;
        }
    }
}
