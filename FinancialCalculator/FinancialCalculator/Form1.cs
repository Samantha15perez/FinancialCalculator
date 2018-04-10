using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Compounded = 1;

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void mortgageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MortgageCalculator.Form1 form1 = new MortgageCalculator.Form1();
            //this allows the user to go between the two calculators
            form1.Show();
            
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //the exit menu closes the initial window
            this.Close();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            References.Form1 form1 = new References.Form1();

            form1.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInitialInvestment.Text = "";
            textBoxInterestRate.Text = "";
            textBoxLengthOfTime.Text = "";
            textBoxMonthlyContribution.Text = "";
            ResultLabel.Text = "";

        }

        private void radioButtonAnnual_CheckedChanged(object sender, EventArgs e)
        {
            int Compounded = 1;
        }

        private void radioButtonSemiannually_CheckedChanged(object sender, EventArgs e)
        {
            int Compounded = 2;
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            int Compounded = 12;
        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            int Compounded = 365;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           try
            {
                
                double Principal = Int32.Parse(textBoxInitialInvestment.Text);
                double InterestRate = (Int32.Parse(textBoxInterestRate.Text)) / 10;
                double Time = (Int32.Parse(textBoxLengthOfTime.Text)) / 12;
                double MathExpAmt = (Compounded * Time);
                double intComp = (InterestRate / Compounded);
                double EqP1 = (Principal * (1 + intComp));

                double Amount = Math.Pow(EqP1, MathExpAmt);

               

                ResultLabel.Text = Amount.ToString();
            }
            catch
            {
                MessageBox.Show("Numbers Only Please!");
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
