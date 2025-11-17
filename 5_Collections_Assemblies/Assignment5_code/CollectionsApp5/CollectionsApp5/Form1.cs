using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReverseLibrary;  // Import your assembly

namespace CollectionsApp5
{
    public partial class Form1 : Form
    {
        ReverseClass obj = new ReverseClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                int reversed = obj.ReverseNumber(number);
                MessageBox.Show("Reversed number: " + reversed);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer number.");
            }

        }

        private void btnReverseString_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                string reversedStr = obj.ReverseString(input);
                MessageBox.Show("Reversed string: " + reversedStr);
            }
            else
            {
                MessageBox.Show("Please enter a string.");
            }
        }
    }
}
