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
            label7.Text = "";
            label9.Text = "";

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
                //conditional variables are declared here to make the if statements function properly
                double c = 0;
                double r = double.Parse(textBoxMonthlyContribution.Text);
                double R = 0;
                //certain variables are different depending on what button is selected
                if (radioButtonDaily.Checked)
                {
                    c = 365; R = ((r * 12) / 365);
                    
                }
                else if (radioButtonMonthly.Checked)
                {
                    c = 12; R = r;
                    
                }
                else if (radioButtonQuarterly.Checked)
                {
                    c = 4; R = (r * 3);
                }
                else if (radioButtonSemiannually.Checked)
                {
                    c = 2; R = (r * 6);
                    
                }
                else if (radioButtonAnnual.Checked)
                {
                    c = 1; R = (r * 12);
                    
                }                        

                double P = double.Parse(textBoxInitialInvestment.Text);
                double i = (double.Parse(textBoxInterestRate.Text)) / 100;                
                double n = double.Parse(textBoxLengthOfTime.Text);

                

                
                double NxC = (n * c);
                double IdC = (i / c);
                double IdC1 = (1 + IdC);
                double EQP1 = Math.Pow(IdC1, NxC);
                double EQSide1 = (P * EQP1);
                double EQP2 = (EQP1 - 1);
                double EQP3 = (R * EQP2);
                double EQSide2 = (EQP3 / IdC);
              

                double FV = (EQSide1 + EQSide2);
                // double YA = ((FV - P) / n);
                // double IE = (((i * P) * 12) * n);

                double IE = ((i * P) * n);
                double YA = (r * 12);
                




                




                ResultLabel.Text = FV.ToString("c");
                label7.Text = IE.ToString("c");
                label9.Text = YA.ToString("c");
            }
            catch 
            {
                MessageBox.Show("Something went wrong.");
                
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonQuarterly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
