using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string fruits = "";

            if (chkApple.Checked) fruits += "APPLE ";
            if (chkBanana.Checked) fruits += "BANANA ";
            if (chkMango.Checked) fruits += "MANGO ";
            if (chkKiwi.Checked) fruits += "KIWI ";

            if (string.IsNullOrWhiteSpace(fruits))
                MessageBox.Show("You did not select any fruits.");
            else
                MessageBox.Show("I like " + fruits.Trim());
        }
    }
}
