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



        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxMortgagePrinciple.Text = "";
            textBoxNumberOfMonths.Text = "";
            textBoxMonthlyInterest.Text = "";
            ResultLabel.Text = "";
            labelPayOffDate.Text = "";
            labelTotalPaid.Text = "";
            textBoxLoanStartDate.Text = "";
            textBoxDownPayment.Text = "";
            labelTotalInterest.Text = "";

            //this blanks the specified fields when the button is pressed. 
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
                DateTime StartDate = DateTime.Parse(textBoxLoanStartDate.Text); //start date of your loan
                
                

                double FullEquationMonthlyPayment = CompoundInterestCalculator.MortgageMonthly(Interest, ProgramLength, P, DP);
                string FullEquationPayOffDate = CompoundInterestCalculator.MortgagePayOffDate(StartDate, ProgramLength);
                double FullEquationTotalPayment = CompoundInterestCalculator.MortgageTotalPayment(Interest, ProgramLength, P, DP);
                double FullEquationInterestOnly = CompoundInterestCalculator.MortgageTotalInterest(Interest, ProgramLength, P, DP);
                //this runs the equations through the class and outputs the results to the proper boxes.
                ResultLabel.Text = FullEquationMonthlyPayment.ToString("c");
                labelTotalPaid.Text = FullEquationTotalPayment.ToString("c");
                labelPayOffDate.Text = FullEquationPayOffDate.ToString();
                labelTotalInterest.Text = FullEquationInterestOnly.ToString("c");
            }
            catch
            {
                MessageBox.Show("Please double-check your input. ");
            }
        }
               
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FinancialCalculator.Form1 form1 = new FinancialCalculator.Form1();
            //this allows the user to go between the two calculators
            form1.Show();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //this menu option closes the form.
            this.Close();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialCalculator.ReferenceSheet form1 = new FinancialCalculator.ReferenceSheet();
            //opens references
            form1.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {//this menu option opens the help menu for the Mortgage calculator.

            FinancialCalculator.HelpMortgageCalculator form1 = new FinancialCalculator.HelpMortgageCalculator();

            form1.Show();
        }
    }
}
