using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorialCalculator : Form
    {
        public frmFactorialCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number = 1;
            number = Convert.ToDouble(txtNumber.Text);

            for (int count = Convert.ToInt32(number - 1); count > 0; count--)
            {
                number *= count;
            }

            txtNumber.Text = "";
            txtFactorial.Text = number.ToString("n0");
        }
    }
}
