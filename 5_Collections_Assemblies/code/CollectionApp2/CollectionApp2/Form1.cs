using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CollectionApp2
{
    public partial class Form1 : Form
    {
        // Create an ArrayList instance
        ArrayList myArrayList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                myArrayList.Add(textBox1.Text);
                textBox1.Clear();
                MessageBox.Show("Item added to ArrayList!");
            }
            else
            {
                MessageBox.Show("Please enter an item.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in myArrayList)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
