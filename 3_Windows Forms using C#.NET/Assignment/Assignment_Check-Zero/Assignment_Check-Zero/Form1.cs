using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Check_Zero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumberCheck.Text, out double number))
            {
                if (number == 0)
                    lblZeroResult.Text = "The entered number IS ZERO.";
                else
                    lblZeroResult.Text = "The entered number is NOT zero.";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberCheck.SelectAll();
                txtNumberCheck.Focus();
            }
        }
    }
}
