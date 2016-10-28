namespace PrimeNumbersChallenge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPrimes = new System.Windows.Forms.ListBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtTimeElapsed = new System.Windows.Forms.TextBox();
            this.txtNumberOfPrimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOfItems = new System.Windows.Forms.TextBox();
            this.btnGenerateBelow = new System.Windows.Forms.Button();
            this.btnNthPrime = new System.Windows.Forms.Button();
            this.txtNthNumber = new System.Windows.Forms.TextBox();
            this.btnTimerToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrimes
            // 
            this.lstPrimes.FormattingEnabled = true;
            this.lstPrimes.Location = new System.Drawing.Point(35, 53);
            this.lstPrimes.Name = "lstPrimes";
            this.lstPrimes.ScrollAlwaysVisible = true;
            this.lstPrimes.Size = new System.Drawing.Size(120, 173);
            this.lstPrimes.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(379, 98);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(74, 13);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Time Elapsed:";
            // 
            // txtTimeElapsed
            // 
            this.txtTimeElapsed.Location = new System.Drawing.Point(322, 114);
            this.txtTimeElapsed.Name = "txtTimeElapsed";
            this.txtTimeElapsed.ReadOnly = true;
            this.txtTimeElapsed.Size = new System.Drawing.Size(200, 20);
            this.txtTimeElapsed.TabIndex = 4;
            // 
            // txtNumberOfPrimes
            // 
            this.txtNumberOfPrimes.Location = new System.Drawing.Point(214, 42);
            this.txtNumberOfPrimes.Name = "txtNumberOfPrimes";
            this.txtNumberOfPrimes.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfPrimes.TabIndex = 1;
            this.txtNumberOfPrimes.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of items returned:";
            // 
            // txtNumOfItems
            // 
            this.txtNumOfItems.Location = new System.Drawing.Point(313, 206);
            this.txtNumOfItems.Name = "txtNumOfItems";
            this.txtNumOfItems.ReadOnly = true;
            this.txtNumOfItems.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfItems.TabIndex = 8;
            // 
            // btnGenerateBelow
            // 
            this.btnGenerateBelow.Location = new System.Drawing.Point(214, 13);
            this.btnGenerateBelow.Name = "btnGenerateBelow";
            this.btnGenerateBelow.Size = new System.Drawing.Size(128, 23);
            this.btnGenerateBelow.TabIndex = 9;
            this.btnGenerateBelow.Text = "Generate Primes below number";
            this.btnGenerateBelow.UseVisualStyleBackColor = true;
            this.btnGenerateBelow.Click += new System.EventHandler(this.btnGenerateBelow_Click);
            // 
            // btnNthPrime
            // 
            this.btnNthPrime.Location = new System.Drawing.Point(471, 12);
            this.btnNthPrime.Name = "btnNthPrime";
            this.btnNthPrime.Size = new System.Drawing.Size(128, 23);
            this.btnNthPrime.TabIndex = 10;
            this.btnNthPrime.Text = "Generate Nth Prime";
            this.btnNthPrime.UseVisualStyleBackColor = true;
            this.btnNthPrime.Click += new System.EventHandler(this.btnNthPrime_Click);
            // 
            // txtNthNumber
            // 
            this.txtNthNumber.Location = new System.Drawing.Point(471, 42);
            this.txtNthNumber.Name = "txtNthNumber";
            this.txtNthNumber.Size = new System.Drawing.Size(128, 20);
            this.txtNthNumber.TabIndex = 11;
            this.txtNthNumber.Text = "10000";
            // 
            // btnTimerToggle
            // 
            this.btnTimerToggle.Location = new System.Drawing.Point(368, 140);
            this.btnTimerToggle.Name = "btnTimerToggle";
            this.btnTimerToggle.Size = new System.Drawing.Size(94, 23);
            this.btnTimerToggle.TabIndex = 12;
            this.btnTimerToggle.Text = "Toggle Timer";
            this.btnTimerToggle.UseVisualStyleBackColor = true;
            this.btnTimerToggle.Click += new System.EventHandler(this.btnTimerToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 265);
            this.Controls.Add(this.btnTimerToggle);
            this.Controls.Add(this.txtNthNumber);
            this.Controls.Add(this.btnNthPrime);
            this.Controls.Add(this.btnGenerateBelow);
            this.Controls.Add(this.txtNumOfItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfPrimes);
            this.Controls.Add(this.txtTimeElapsed);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lstPrimes);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generate first 1000 Primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrimes;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtTimeElapsed;
        private System.Windows.Forms.TextBox txtNumberOfPrimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOfItems;
        private System.Windows.Forms.Button btnGenerateBelow;
        private System.Windows.Forms.Button btnNthPrime;
        private System.Windows.Forms.TextBox txtNthNumber;
        private System.Windows.Forms.Button btnTimerToggle;
    }
}

