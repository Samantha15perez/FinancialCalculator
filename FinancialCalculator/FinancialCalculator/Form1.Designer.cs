namespace FinancialCalculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxInitialInvestment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxMonthlyContribution = new System.Windows.Forms.TextBox();
            this.textBoxLengthOfTime = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonAnnual = new System.Windows.Forms.RadioButton();
            this.radioButtonSemiannually = new System.Windows.Forms.RadioButton();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQuarterly = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2,
            this.referencesToolStripMenuItem,
            this.exitToolStripMenuItem3});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.calculatorToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem2.Text = "Mortgage Calculator";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.exitToolStripMenuItem3_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.referencesToolStripMenuItem.Text = "References";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
            // 
            // textBoxInitialInvestment
            // 
            this.textBoxInitialInvestment.Location = new System.Drawing.Point(11, 47);
            this.textBoxInitialInvestment.Name = "textBoxInitialInvestment";
            this.textBoxInitialInvestment.Size = new System.Drawing.Size(106, 20);
            this.textBoxInitialInvestment.TabIndex = 2;
            this.textBoxInitialInvestment.TextChanged += new System.EventHandler(this.textBoxInitialInvestment_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initial Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Monthly Contribution";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBoxMonthlyContribution
            // 
            this.textBoxMonthlyContribution.Location = new System.Drawing.Point(11, 87);
            this.textBoxMonthlyContribution.Name = "textBoxMonthlyContribution";
            this.textBoxMonthlyContribution.Size = new System.Drawing.Size(106, 20);
            this.textBoxMonthlyContribution.TabIndex = 2;
            this.textBoxMonthlyContribution.TextChanged += new System.EventHandler(this.textBoxMonthlyContribution_TextChanged);
            // 
            // textBoxLengthOfTime
            // 
            this.textBoxLengthOfTime.Location = new System.Drawing.Point(11, 127);
            this.textBoxLengthOfTime.Name = "textBoxLengthOfTime";
            this.textBoxLengthOfTime.Size = new System.Drawing.Size(106, 20);
            this.textBoxLengthOfTime.TabIndex = 2;
            this.textBoxLengthOfTime.TextChanged += new System.EventHandler(this.textBoxLengthOfTime_TextChanged);
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Location = new System.Drawing.Point(11, 171);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(106, 20);
            this.textBoxInterestRate.TabIndex = 2;
            this.textBoxInterestRate.TextChanged += new System.EventHandler(this.textBoxInterestRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length of time (Years)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest Rate (%)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Compounded When?";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ResultLabel.Location = new System.Drawing.Point(143, 60);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(108, 20);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(143, 184);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(102, 45);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(143, 255);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 45);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Future Value";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioButtonAnnual
            // 
            this.radioButtonAnnual.AutoSize = true;
            this.radioButtonAnnual.Location = new System.Drawing.Point(7, 16);
            this.radioButtonAnnual.Name = "radioButtonAnnual";
            this.radioButtonAnnual.Size = new System.Drawing.Size(65, 17);
            this.radioButtonAnnual.TabIndex = 4;
            this.radioButtonAnnual.TabStop = true;
            this.radioButtonAnnual.Text = "Annually";
            this.radioButtonAnnual.UseVisualStyleBackColor = true;
            this.radioButtonAnnual.CheckedChanged += new System.EventHandler(this.radioButtonAnnual_CheckedChanged);
            // 
            // radioButtonSemiannually
            // 
            this.radioButtonSemiannually.AutoSize = true;
            this.radioButtonSemiannually.Location = new System.Drawing.Point(7, 39);
            this.radioButtonSemiannually.Name = "radioButtonSemiannually";
            this.radioButtonSemiannually.Size = new System.Drawing.Size(87, 17);
            this.radioButtonSemiannually.TabIndex = 5;
            this.radioButtonSemiannually.TabStop = true;
            this.radioButtonSemiannually.Text = "Semiannually";
            this.radioButtonSemiannually.UseVisualStyleBackColor = true;
            this.radioButtonSemiannually.CheckedChanged += new System.EventHandler(this.radioButtonSemiannually_CheckedChanged);
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(7, 109);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDaily.TabIndex = 6;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(7, 86);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMonthly.TabIndex = 6;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuarterly);
            this.groupBox1.Controls.Add(this.radioButtonMonthly);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButtonDaily);
            this.groupBox1.Controls.Add(this.radioButtonSemiannually);
            this.groupBox1.Controls.Add(this.radioButtonAnnual);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonQuarterly
            // 
            this.radioButtonQuarterly.AutoSize = true;
            this.radioButtonQuarterly.Location = new System.Drawing.Point(7, 62);
            this.radioButtonQuarterly.Name = "radioButtonQuarterly";
            this.radioButtonQuarterly.Size = new System.Drawing.Size(67, 17);
            this.radioButtonQuarterly.TabIndex = 7;
            this.radioButtonQuarterly.TabStop = true;
            this.radioButtonQuarterly.Text = "Quarterly";
            this.radioButtonQuarterly.UseVisualStyleBackColor = true;
            this.radioButtonQuarterly.CheckedChanged += new System.EventHandler(this.radioButtonQuarterly_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(143, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 8;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Interest Earned";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.YellowGreen;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(143, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 8;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Yearly Additions";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 339);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInterestRate);
            this.Controls.Add(this.textBoxLengthOfTime);
            this.Controls.Add(this.textBoxMonthlyContribution);
            this.Controls.Add(this.textBoxInitialInvestment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Compound Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxInitialInvestment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox textBoxMonthlyContribution;
        private System.Windows.Forms.TextBox textBoxLengthOfTime;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonAnnual;
        private System.Windows.Forms.RadioButton radioButtonSemiannually;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonQuarterly;
    }
}

