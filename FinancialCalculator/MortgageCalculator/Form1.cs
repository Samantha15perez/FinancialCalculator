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

                
                
                                                          
                double Interest = ((double.Parse(textBoxMonthlyInterest.Text) / 100) / 12);//this turns the interest into a percentage
                double ProgramLength = double.Parse(textBoxNumberOfMonths.Text); // how many years the program lasts
                double P = double.Parse(textBoxMortgagePrinciple.Text); //how much you have to pay
                double n = (ProgramLength * 12); //number of payments
                double M = (P - DP);

                double R1 = (Interest + 1);
                double R1n = Math.Pow(R1, n);
                double Numerator = (Interest * R1n);
                double Denominator = (R1n - 1);
                double Fraction = (Numerator / Denominator);
                double FullEquation = (M * Fraction);

                


                ResultLabel.Text = FullEquation.ToString("c");
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
