namespace FinancialCalculator
{
    partial class MortgageCalculator2
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
            this.checkBoxPercentage = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfMonths = new System.Windows.Forms.TextBox();
            this.textBoxDownPayment = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyInterest = new System.Windows.Forms.TextBox();
            this.textBoxMortgagePrinciple = new System.Windows.Forms.TextBox();
            this.labelTotalPaid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxPercentage
            // 
            this.checkBoxPercentage.AutoSize = true;
            this.checkBoxPercentage.Location = new System.Drawing.Point(31, 104);
            this.checkBoxPercentage.Name = "checkBoxPercentage";
            this.checkBoxPercentage.Size = new System.Drawing.Size(63, 17);
            this.checkBoxPercentage.TabIndex = 37;
            this.checkBoxPercentage.Text = "Percent";
            this.checkBoxPercentage.UseVisualStyleBackColor = true;
            this.checkBoxPercentage.CheckedChanged += new System.EventHandler(this.checkBoxPercentage_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Monthly Payment:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(240, 117);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(67, 45);
            this.buttonReset.TabIndex = 34;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(158, 117);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(67, 45);
            this.buttonCalculate.TabIndex = 35;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ResultLabel.Location = new System.Drawing.Point(181, 37);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(106, 20);
            this.ResultLabel.TabIndex = 33;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Program Length";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Interest Rate (%)";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Down Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mortgage Principle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumberOfMonths
            // 
            this.textBoxNumberOfMonths.Location = new System.Drawing.Point(12, 186);
            this.textBoxNumberOfMonths.Name = "textBoxNumberOfMonths";
            this.textBoxNumberOfMonths.Size = new System.Drawing.Size(106, 20);
            this.textBoxNumberOfMonths.TabIndex = 25;
            this.textBoxNumberOfMonths.TextChanged += new System.EventHandler(this.textBoxNumberOfMonths_TextChanged);
            // 
            // textBoxDownPayment
            // 
            this.textBoxDownPayment.Location = new System.Drawing.Point(12, 78);
            this.textBoxDownPayment.Name = "textBoxDownPayment";
            this.textBoxDownPayment.Size = new System.Drawing.Size(106, 20);
            this.textBoxDownPayment.TabIndex = 27;
            this.textBoxDownPayment.TextChanged += new System.EventHandler(this.textBoxDownPayment_TextChanged);
            // 
            // textBoxMonthlyInterest
            // 
            this.textBoxMonthlyInterest.Location = new System.Drawing.Point(12, 146);
            this.textBoxMonthlyInterest.Name = "textBoxMonthlyInterest";
            this.textBoxMonthlyInterest.Size = new System.Drawing.Size(106, 20);
            this.textBoxMonthlyInterest.TabIndex = 26;
            this.textBoxMonthlyInterest.TextChanged += new System.EventHandler(this.textBoxMonthlyInterest_TextChanged);
            // 
            // textBoxMortgagePrinciple
            // 
            this.textBoxMortgagePrinciple.Location = new System.Drawing.Point(12, 37);
            this.textBoxMortgagePrinciple.Name = "textBoxMortgagePrinciple";
            this.textBoxMortgagePrinciple.Size = new System.Drawing.Size(106, 20);
            this.textBoxMortgagePrinciple.TabIndex = 28;
            this.textBoxMortgagePrinciple.TextChanged += new System.EventHandler(this.textBoxMortgagePrinciple_TextChanged);
            // 
            // labelTotalPaid
            // 
            this.labelTotalPaid.BackColor = System.Drawing.Color.YellowGreen;
            this.labelTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTotalPaid.Location = new System.Drawing.Point(181, 78);
            this.labelTotalPaid.Name = "labelTotalPaid";
            this.labelTotalPaid.Size = new System.Drawing.Size(106, 20);
            this.labelTotalPaid.TabIndex = 33;
            this.labelTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotalPaid.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Amount Paid:";
            this.label5.Click += new System.EventHandler(this.label6_Click);
            // 
            // MortgageCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 216);
            this.Controls.Add(this.checkBoxPercentage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTotalPaid);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfMonths);
            this.Controls.Add(this.textBoxDownPayment);
            this.Controls.Add(this.textBoxMonthlyInterest);
            this.Controls.Add(this.textBoxMortgagePrinciple);
            this.Name = "MortgageCalculator2";
            this.Text = "MortgageCalculator2";
            this.Load += new System.EventHandler(this.MortgageCalculator2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfMonths;
        private System.Windows.Forms.TextBox textBoxDownPayment;
        private System.Windows.Forms.TextBox textBoxMonthlyInterest;
        private System.Windows.Forms.TextBox textBoxMortgagePrinciple;
        private System.Windows.Forms.Label labelTotalPaid;
        private System.Windows.Forms.Label label5;
    }
}