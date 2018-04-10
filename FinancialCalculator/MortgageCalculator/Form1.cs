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
            try
            {
                string MonthlyPayment = "13";

                ResultLabel.Text = MonthlyPayment.ToString();
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
    }
}
