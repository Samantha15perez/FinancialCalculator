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
    public partial class MortgageCalculator2 : Form
    {
        public MortgageCalculator2()
        {
            InitializeComponent();
        }

        private void MortgageCalculator2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
                

                double FullEquationMonthlyPayment = CompoundInterestCalculator.MortgageMonthly(Interest, ProgramLength, P, DP);
                double FullEquationTotalPaid = CompoundInterestCalculator.MortgageTotalPaid(Interest, ProgramLength, P, DP);


                ResultLabel.Text = FullEquationMonthlyPayment.ToString("c");
                labelTotalPaid.Text = FullEquationTotalPaid.ToString("c");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPercentage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberOfMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDownPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonthlyInterest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMortgagePrinciple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
