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
            
        }

        private void radioButtonSemiannually_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           try
            {
                int Compounded = 0;

                if (radioButtonDaily.Checked)
                {
                    Compounded = 365;
                }
                else if (radioButtonMonthly.Checked)
                {
                    Compounded = 12;
                }
                else if (radioButtonSemiannually.Checked)
                {
                    Compounded = 2;
                }
                else if (radioButtonAnnual.Checked)
                {
                    Compounded = 1;
                }

                double Principal = double.Parse(textBoxInitialInvestment.Text);
                double InterestRate = (double.Parse(textBoxInterestRate.Text)) / 100;
                double Time = (double.Parse(textBoxLengthOfTime.Text)) / 12;
                double Contribution = double.Parse(textBoxMonthlyContribution.Text) * 12;
                                
                double Amount = Math.Pow(Principal * (1 + (InterestRate / Compounded)), (Compounded * Time));
                double FINAL = (Amount + Contribution);




                ResultLabel.Text = FINAL.ToString();
            }
            catch 
            {
                MessageBox.Show("Something went wrong.");
                
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInterestRate_TextChanged(object sender, EventArgs e)
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
    }
}
