using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cents;
            int quarters = 0, dimes = 0, nickels = 0, pennies = 0;

            cents = Convert.ToInt16(txtCents.Text);

            while (cents > 0)
            {
                if (cents >= 25)
                {
                    quarters++;
                    cents -= 25;
                }

                else if (cents >= 10)
                {
                    dimes++;
                    cents -= 10;
                }

                else if (cents >= 5)
                {
                    nickels++;
                    cents -= 5;
                }

                else if (cents >= 1)
                {
                    pennies++;
                    cents -= 1;
                }
                else
                {
                    MessageBox.Show("Error");
                }

                txtQuarters.Text = quarters.ToString("n0");
                txtDimes.Text = dimes.ToString("n0");
                txtNickels.Text = nickels.ToString("n0");              
                txtPennies.Text = pennies.ToString("n0");
                txtCents.Text = "";
            }

        }
    }
}
