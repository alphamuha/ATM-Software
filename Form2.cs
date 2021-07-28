using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Software
{
    public partial class Form2 : Form
    {

        int cashAvailability = 1000;
        int moneyLeft;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCashAvailability.Text = Convert.ToString(cashAvailability);
        }

        private void lblCashAvailability_Click(object sender, EventArgs e)
        {

        }

        private void btnPin1_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "1";
        }

        private void btnPin2_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "2";
        }

        private void btnPin3_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "3";
        }

        private void btnPin4_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "4";
        }

        private void btnPin5_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "5";
        }

        private void btnPin6_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "6";
        }

        private void btnPin7_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "7";
        }

        private void btnPin8_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "8";
        }

        private void btnPin9_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "9";
        }

        private void btnPin0_Click(object sender, EventArgs e)
        {
            txtBoxPin.Text += "0";
        }

        private void btnPinClearLast_Click(object sender, EventArgs e)
        {
            try
            {
                //kasnije izuciti ovaj line ispods
                txtBoxPin.Text = txtBoxPin.Text.Substring(0, txtBoxPin.Text.Length - 1);
            }

            catch
            {
                lblPogresanPin.Text += " ";
            }
        }

        private void btnPinClearAll_Click(object sender, EventArgs e)
        {
            txtBoxPin.Clear();
        }

        private void maxMoney()
        {
            

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            //dizadnje pOOra
            int convertMoney = Convert.ToInt32(txtBoxPin.Text);
            if (convertMoney > 1000)
            {
                lblPogresanPin.Text = "Maximum daily amount for withdrawal is 1000";
                txtBoxPin.Text = " ";
                
            }

            else
            {
                lblPogresanPin.Text = "Withdrawing money...";

                //Convert
                int converMoney = Convert.ToInt32(txtBoxPin.Text);
                moneyLeft = cashAvailability - converMoney;
                var moneyLeftString = Convert.ToString(moneyLeft);
                lblCashAvailability.Text = moneyLeftString;
            }
        }
    }
}
