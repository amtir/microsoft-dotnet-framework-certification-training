using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtb_name.Text  +  "! Welcome to Windows Application!", "Edureka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rb_male.Checked)
            {
                MessageBox.Show("Male");
                Console.WriteLine("Male");
            }
            else if (rb_female.Checked)
            {
                MessageBox.Show("Female");
                Console.WriteLine("Female");
            }
            else if (rb_trans.Checked)
            {
                MessageBox.Show("Trans");
                Console.WriteLine("Trans");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
