using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Display_Days_Months
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // clear previous items
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            listBox1.Items.AddRange(days);
        }

        private void btnMonths_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // clear previous items
            string[] months =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
            listBox1.Items.AddRange(months);
        }
    }
}
