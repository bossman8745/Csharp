using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frmIncomeTaxCalculator : Form
    {
        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double income, tax = 0;

            income = Convert.ToDouble(txtIncome.Text);

            if (income <= 9225)
            {
                tax = income * 0.10;
            }

            else if (income > 9225 && income <= 37450)
            {
                tax = 922.5;
                income -= 9225;
                tax += income * 0.15;
            }

            else if (income > 37450 && income <= 90750)
            {
                tax = 5156.25;
                income -= 37450;
                tax += income * 1.25;
            }

            else if (income > 90750 && income <= 189300)
            {
                tax = 18481.25;
                income -= 90750;
                tax += income * 1.28;
            }

            else if (income > 189300 && income <= 411500)
            {
                tax = 46075.25;
                income -= 189300;
                tax += income * 1.33;
            }

            else if (income > 411500 && income <= 413200)
            {
                tax = 119401.25;
                income -= 411500;
                tax += income * 1.35;
            }

            else if (income > 413200)
            {
                tax = 119996.25;
                income -= 413200;
                tax += income * 1.396;
            }

            else
            {
                MessageBox.Show("Error");
            }

            txtIncome.Text = "";
            txtTax.Text = tax.ToString("c");

        }
    }
}
