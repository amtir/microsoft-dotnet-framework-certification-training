using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsApp4
{
    public partial class Form1 : Form
    {
        // Key = int, Value = string. Automatically sorted by key.
        private readonly SortedList<int, string> items = new SortedList<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInt.Text, out int key))
            {
                MessageBox.Show("Please enter a valid integer key.");
                txtInt.Focus();
                return;
            }

            string value = txtStr.Text?.Trim();
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Please enter a non-empty string value.");
                txtStr.Focus();
                return;
            }

            if (items.ContainsKey(key))
            {
                MessageBox.Show("That key already exists. Keys in SortedList must be unique.");
                return;
            }

            items.Add(key, value);
            txtInt.Clear();
            txtStr.Clear();
            txtInt.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var kv in items)
            {
                // e.g., "1 -> apple"
                listBox1.Items.Add($"{kv.Key} -> {kv.Value}");
            }

            if (items.Count == 0)
                listBox1.Items.Add("(no items)");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRemoveKey.Text, out int key))
            {
                MessageBox.Show("Enter a valid integer key to remove.");
                txtRemoveKey.Focus();
                return;
            }

            if (items.Remove(key))
            {
                MessageBox.Show("Item removed.");
                btnShow_Click(sender, e); // refresh view
            }
            else
            {
                MessageBox.Show("Key not found.");
            }

            txtRemoveKey.Clear();
    }
    }
}
