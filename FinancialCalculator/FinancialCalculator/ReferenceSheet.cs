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
    public partial class ReferenceSheet : Form
    {
        public ReferenceSheet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.wikihow.com/Calculate-Mortgage-Payments");
            //opens reference page
        }

        private void desc1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.investor.gov/additional-resources/free-financial-planning-tools/compound-interest-calculator");
            //opens reference page
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void desc2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.bankrate.com/calculators/mortgages/mortgage-calculator.aspx#testid=10413875559_control");
            //opens reference page
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.wikihow.com/Calculate-Mortgage-Payments");
            //opens reference page
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.wikihow.com/Calculate-Mortgage-Payments");
            //opens reference page
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php");
            //opens reference page
        }
    }
}
