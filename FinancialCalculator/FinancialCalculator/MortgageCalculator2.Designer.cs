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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPayOffDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLoanStartDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalInterest = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxPercentage
            // 
            this.checkBoxPercentage.AutoSize = true;
            this.checkBoxPercentage.Location = new System.Drawing.Point(31, 113);
            this.checkBoxPercentage.Name = "checkBoxPercentage";
            this.checkBoxPercentage.Size = new System.Drawing.Size(63, 17);
            this.checkBoxPercentage.TabIndex = 37;
            this.checkBoxPercentage.Text = "Percent";
            this.checkBoxPercentage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Monthly Payment:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(232, 209);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(67, 45);
            this.buttonReset.TabIndex = 34;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(150, 209);
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
            this.ResultLabel.Location = new System.Drawing.Point(175, 46);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(106, 20);
            this.ResultLabel.TabIndex = 33;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Program Length (Years)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Interest Rate (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Down Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mortgage Principle";
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
            this.textBoxDownPayment.Location = new System.Drawing.Point(12, 87);
            this.textBoxDownPayment.Name = "textBoxDownPayment";
            this.textBoxDownPayment.Size = new System.Drawing.Size(106, 20);
            this.textBoxDownPayment.TabIndex = 27;
            // 
            // textBoxMonthlyInterest
            // 
            this.textBoxMonthlyInterest.Location = new System.Drawing.Point(12, 146);
            this.textBoxMonthlyInterest.Name = "textBoxMonthlyInterest";
            this.textBoxMonthlyInterest.Size = new System.Drawing.Size(106, 20);
            this.textBoxMonthlyInterest.TabIndex = 26;
            // 
            // textBoxMortgagePrinciple
            // 
            this.textBoxMortgagePrinciple.Location = new System.Drawing.Point(12, 46);
            this.textBoxMortgagePrinciple.Name = "textBoxMortgagePrinciple";
            this.textBoxMortgagePrinciple.Size = new System.Drawing.Size(106, 20);
            this.textBoxMortgagePrinciple.TabIndex = 28;
            // 
            // labelTotalPaid
            // 
            this.labelTotalPaid.BackColor = System.Drawing.Color.YellowGreen;
            this.labelTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTotalPaid.Location = new System.Drawing.Point(175, 129);
            this.labelTotalPaid.Name = "labelTotalPaid";
            this.labelTotalPaid.Size = new System.Drawing.Size(106, 20);
            this.labelTotalPaid.TabIndex = 33;
            this.labelTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Amount Paid:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2,
            this.referencesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem3});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.calculatorToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem2.Text = "Compound Interest Calculator";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.referencesToolStripMenuItem.Text = "References";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.exitToolStripMenuItem3_Click);
            // 
            // labelPayOffDate
            // 
            this.labelPayOffDate.BackColor = System.Drawing.Color.YellowGreen;
            this.labelPayOffDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPayOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPayOffDate.Location = new System.Drawing.Point(175, 168);
            this.labelPayOffDate.Name = "labelPayOffDate";
            this.labelPayOffDate.Size = new System.Drawing.Size(106, 20);
            this.labelPayOffDate.TabIndex = 33;
            this.labelPayOffDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Pay-off Date:";
            // 
            // textBoxLoanStartDate
            // 
            this.textBoxLoanStartDate.Location = new System.Drawing.Point(12, 234);
            this.textBoxLoanStartDate.Name = "textBoxLoanStartDate";
            this.textBoxLoanStartDate.Size = new System.Drawing.Size(106, 20);
            this.textBoxLoanStartDate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Loan start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label9.Location = new System.Drawing.Point(14, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 9);
            this.label9.TabIndex = 29;
            this.label9.Text = "(MM/DD/YYYY)";
            // 
            // labelTotalInterest
            // 
            this.labelTotalInterest.BackColor = System.Drawing.Color.YellowGreen;
            this.labelTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTotalInterest.Location = new System.Drawing.Point(175, 87);
            this.labelTotalInterest.Name = "labelTotalInterest";
            this.labelTotalInterest.Size = new System.Drawing.Size(106, 20);
            this.labelTotalInterest.TabIndex = 33;
            this.labelTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Interest:";
            // 
            // MortgageCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 281);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBoxPercentage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelPayOffDate);
            this.Controls.Add(this.labelTotalInterest);
            this.Controls.Add(this.labelTotalPaid);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLoanStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfMonths);
            this.Controls.Add(this.textBoxDownPayment);
            this.Controls.Add(this.textBoxMonthlyInterest);
            this.Controls.Add(this.textBoxMortgagePrinciple);
            this.Name = "MortgageCalculator2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MortgageCalculator";
            this.Load += new System.EventHandler(this.MortgageCalculator2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.Label labelPayOffDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLoanStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalInterest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}