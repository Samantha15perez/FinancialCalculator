namespace References
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
            this.TheCalculatorSiteLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TheCalculatorSiteLabel
            // 
            this.TheCalculatorSiteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheCalculatorSiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TheCalculatorSiteLabel.Location = new System.Drawing.Point(72, 21);
            this.TheCalculatorSiteLabel.Name = "TheCalculatorSiteLabel";
            this.TheCalculatorSiteLabel.Size = new System.Drawing.Size(281, 30);
            this.TheCalculatorSiteLabel.TabIndex = 2;
            this.TheCalculatorSiteLabel.Text = "TheCalculatorSite.Com";
            this.TheCalculatorSiteLabel.Click += new System.EventHandler(this.TheCalculatorSiteLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::References.Properties.Resources.calculate_loan_costs_800x800;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(445, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 302);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::References.Properties.Resources.compound_interest_formula_diagram;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(410, 242);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TheCalculatorSiteLabel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Reference Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TheCalculatorSiteLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

