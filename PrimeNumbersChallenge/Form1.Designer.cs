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
            this.btnPrimes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeElapsed = new System.Windows.Forms.TextBox();
            this.txtNumberOfPrimes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPrimes
            // 
            this.lstPrimes.FormattingEnabled = true;
            this.lstPrimes.Location = new System.Drawing.Point(35, 53);
            this.lstPrimes.Name = "lstPrimes";
            this.lstPrimes.ScrollAlwaysVisible = true;
            this.lstPrimes.Size = new System.Drawing.Size(120, 459);
            this.lstPrimes.TabIndex = 3;
            // 
            // btnPrimes
            // 
            this.btnPrimes.Location = new System.Drawing.Point(35, 13);
            this.btnPrimes.Name = "btnPrimes";
            this.btnPrimes.Size = new System.Drawing.Size(120, 23);
            this.btnPrimes.TabIndex = 2;
            this.btnPrimes.Text = "Generate Primes";
            this.btnPrimes.UseVisualStyleBackColor = true;
            this.btnPrimes.Click += new System.EventHandler(this.btnPrimes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Elapsed:";
            // 
            // txtTimeElapsed
            // 
            this.txtTimeElapsed.Location = new System.Drawing.Point(214, 144);
            this.txtTimeElapsed.Name = "txtTimeElapsed";
            this.txtTimeElapsed.ReadOnly = true;
            this.txtTimeElapsed.Size = new System.Drawing.Size(200, 20);
            this.txtTimeElapsed.TabIndex = 4;
            // 
            // txtNumberOfPrimes
            // 
            this.txtNumberOfPrimes.Location = new System.Drawing.Point(214, 55);
            this.txtNumberOfPrimes.Name = "txtNumberOfPrimes";
            this.txtNumberOfPrimes.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfPrimes.TabIndex = 1;
            this.txtNumberOfPrimes.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Number to stop searching for primes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfPrimes);
            this.Controls.Add(this.txtTimeElapsed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrimes);
            this.Controls.Add(this.lstPrimes);
            this.Name = "Form1";
            this.Text = "Generate first 1000 Primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrimes;
        private System.Windows.Forms.Button btnPrimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeElapsed;
        private System.Windows.Forms.TextBox txtNumberOfPrimes;
        private System.Windows.Forms.Label label2;
    }
}

