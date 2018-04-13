using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace References
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TheCalculatorSiteLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.wikihow.com/Calculate-Mortgage-Payments");
        } //clicking the label will bring you to a reference page defining compound interest in detail

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php");
        }//clicking the picture will find more basic information about the formula

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.wikihow.com/Calculate-Mortgage-Payments");
        }//clicking this show you how to step through the mortgage formula

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.thecalculatorsite.com/articles/finance/what-is-compound-interest.php");
        }//clicking this will explain more about the subject of compound interest

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.bankrate.com/calculators/mortgages/mortgage-calculator.aspx#testid=10413875559_control");
        } //clicking this will send you to bankrate's calculator tool to double check against the formula for monthly mortgage

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.investor.gov/additional-resources/free-financial-planning-tools/compound-interest-calculator");
        } //clicking this will send you to bankrate's calculator tool to double check against the formula for compound interest.


        private void desc1_Click(object sender, EventArgs e)
        {
            //this label contains an explanation to how the references for compound interest were used. 
        }

        private void desc2_Click(object sender, EventArgs e)
        {
            //this label contains an explanation to how the references for the mortgage calculation were used. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
