using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compoundInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxMortgagePrinciple.Text = "";            
            textBoxNumberOfMonths.Text = "";
            textBoxMonthlyInterest.Text = "";
            ResultLabel.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            double DP = 0;
            
            try
            { //if the checkbox is checked, the number is treated as a percentage. if not, it's treated as it's literal value.
                if (checkBoxPercentage.Checked)
                {
                    DP = ((double.Parse(textBoxMortgagePrinciple.Text)) / 100) * double.Parse(textBoxDownPayment.Text);
                }
                else
                {
                    DP = double.Parse(textBoxDownPayment.Text);
                }

                
                // broken cause the math is wrong
                double MP = double.Parse(textBoxMortgagePrinciple.Text);
                //this takes the down payment off of the initial amount
                double LoanBase = MP - DP;
                //this turns the interest into a percentage
                double Interest = (double.Parse(textBoxMonthlyInterest.Text) / 100);
                double ProgramLength = double.Parse(textBoxNumberOfMonths.Text);
                /*
                double TotalInterest = (LoanBase * Interest);
                double PayWOInterest = (LoanBase / ProgramLength);
                double MonthlyPayment = (PayWOInterest / 12) + TotalInterest; */

                double Ip1 = Interest + 1;
                double Months = (ProgramLength * 12);
                double Exp = Math.Pow(Ip1, Months);
                double Expp1 = (Exp * Interest);
                double Expp1m1 = (Expp1 - 1);
                double Fraction = (Expp1 / Expp1m1);
                double FullEquation = (Fraction * MP);


                ResultLabel.Text = FullEquation.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void textBoxLengthOfTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonthlyContribution_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInitialInvestment_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPercentage_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
