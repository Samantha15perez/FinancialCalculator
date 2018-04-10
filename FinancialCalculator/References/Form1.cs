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
            System.Diagnostics.Process.Start(@"https://www.thecalculatorsite.com/articles/finance/what-is-compound-interest.php");
        } //clicking the label will bring you to a reference page defining compound interest in detail

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php");
        }//clicking the picture will find more basic information about the formula
    }
}
