using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Software
{
    public partial class Form1 : Form
    {

        string PIN = "12345";
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGo.Enabled = true;
        }

        public void btnGo_Click(object sender, EventArgs e)
        {
            if(txtBoxPin.Text == PIN)
            {
                //new Form2().Show();
                //this.Hide();



                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            
            else if (String.IsNullOrEmpty(txtBoxPin.Text))
            {
                lblPogresanPin.Text = " ";
                lblPogresanPin.Text += "Niste unijelid PIN!";
            }

            else
            {
                lblPogresanPin.Text = " ";
                lblPogresanPin.Text += "Unijeli ste pogresan pin!";
                txtBoxPin.Clear();
            }
        }

        private void openNewForm()
        {
            Application.Run(new Form2());
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
            txtBoxPin.Text += "0";        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxPin.Clear();
        }
    }
}
