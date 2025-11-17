using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_Square_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double num))
            {
                double square = num * num;
                txtResult.Text = square.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.SelectAll();
                txtNumber.Focus();
            }
        }
        }
}
