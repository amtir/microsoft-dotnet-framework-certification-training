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

namespace CollectionApp1
{
    public partial class Form1 : Form
    {
        // Create a Queue collection
        Queue myQueue = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                myQueue.Enqueue(textBox1.Text);
                textBox1.Clear();
                MessageBox.Show("Item added to Queue!");
            }
            else
            {
                MessageBox.Show("Please enter an item.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in myQueue)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnDeqeue_Click(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
            {
                var removed = myQueue.Dequeue();
                MessageBox.Show("Removed: " + removed);
            }
            else
            {
                MessageBox.Show("Queue is empty!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myQueue.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Queue cleared!");
        }
    }
}
