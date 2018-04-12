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
             
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FinancialCalculator.MortgageCalculator2 form1 = new FinancialCalculator.MortgageCalculator2();
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           try
            {
                //conditional variables are declared here to make the if statements function properly
                double c = 0;
                double r = double.Parse(textBoxMonthlyContribution.Text);
                double R = 0;
                //Each radio button changes the value of the variables needed.
                //c is how many times a year you would compound
                //R is how many months are within the period you specify for compounding. 
                if (radioButtonDaily.Checked)
                {
                    c = 365; 
                    
                }
                else if (radioButtonMonthly.Checked)
                {
                    c = 12;
                    
                }
                else if (radioButtonQuarterly.Checked)
                {
                    c = 4; 
                }
                else if (radioButtonSemiannually.Checked)
                {
                    c = 2; 
                    
                }
                else if (radioButtonAnnual.Checked)
                {
                    c = 1; 
                    
                }                        
            //these simple variables are the input for Principle, interest, and time. 
            //interest is divided by 100 in order to convert the percentage to a decimal. 
                double P = double.Parse(textBoxInitialInvestment.Text);
                double i = (double.Parse(textBoxInterestRate.Text)) / 100;                
                double n = double.Parse(textBoxLengthOfTime.Text);



                double convertedFV = CompoundInterestCalculator.CompoundInterestFV(P, i, n, c, r);
                double convertedIE = CompoundInterestCalculator.CompoundInterestIE(P, i, n, c, r);
                double convertedYA = CompoundInterestCalculator.CompoundInterestYA(P, i, n, c, r);






                //this outputs all values to the proper labels, as money. 

                ResultLabel.Text = convertedFV.ToString("c");
                label7.Text = convertedIE.ToString("c");
                label9.Text = convertedYA.ToString("c");
            }
            catch (Exception ex)
            {
                throw(ex);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
