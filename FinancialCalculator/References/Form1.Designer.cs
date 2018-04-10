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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TheCalculatorSiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::References.Properties.Resources.compound_interest_formula_diagram;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 218);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 424);
            this.Controls.Add(this.TheCalculatorSiteLabel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Reference Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TheCalculatorSiteLabel;
    }
}

