using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_Number_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a value.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            // Reverse string (works for text or numbers)
            string reversed = new string(input.Reverse().ToArray());

            txtResult.Text = reversed;
        }
    }
}
