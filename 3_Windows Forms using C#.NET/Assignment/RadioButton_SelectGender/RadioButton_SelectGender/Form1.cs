using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RadioButton_SelectGender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (rbMale.Checked)
            {
                MessageBox.Show("Welcome Mr. " + name, "Greeting");
            }
            else if (rbFemale.Checked)
            {
                MessageBox.Show("Welcome Ms. " + name, "Greeting");
            }
            else
            {
                MessageBox.Show("Please select your gender.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
