using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    public partial class Form1 : Form
    {
        // Generic HashSets
        HashSet<int> intSet = new HashSet<int>();
        HashSet<string> stringSet = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddInt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIntInput.Text, out int number))
            {
                if (intSet.Add(number))
                {
                    MessageBox.Show("Integer added successfully!");
                }
                else
                {
                    MessageBox.Show("Duplicate value. HashSet only stores unique items!");
                }
                txtIntInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnShowInt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int n in intSet)
            {
                listBox1.Items.Add(n);
            }
        }

        private void btnContainsInt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIntCheck.Text, out int checkVal))
            {
                if (intSet.Contains(checkVal))
                    MessageBox.Show("Integer FOUND in HashSet.");
                else
                    MessageBox.Show("Integer NOT FOUND.");
            }
            else
            {
                MessageBox.Show("Please enter a valid integer to check.");
            }
        }

        private void btnAddString_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStrInput.Text))
            {
                if (stringSet.Add(txtStrInput.Text))
                {
                    MessageBox.Show("String added successfully!");
                }
                else
                {
                    MessageBox.Show("Duplicate string. HashSet only stores unique items!");
                }
                txtStrInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a string value.");
            }
        }

        private void btnShowString_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in stringSet)
            {
                listBox1.Items.Add(s);
            }
        }

        private void btnContainsStr_Click(object sender, EventArgs e)
        {
            string check = txtStrCheck.Text.Trim();

            if (string.IsNullOrEmpty(check))
            {
                MessageBox.Show("Please enter a string to check.");
                return;
            }

            if (stringSet.Contains(check))
                MessageBox.Show("String FOUND in HashSet.");
            else
                MessageBox.Show("String NOT FOUND.");
        }
    }
}
