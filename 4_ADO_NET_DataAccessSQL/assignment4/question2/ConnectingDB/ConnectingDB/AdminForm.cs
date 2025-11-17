using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingDB
{
    public partial class AdminForm : Form
    {
        public AdminForm(string username)
        {
            InitializeComponent();
            Text = "Admin";

            var lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold),
                Text = $"Hello admin, {username}"
            };

            Controls.Add(lbl);
        }

        // ADD THIS (name must match what Designer is hooked to)
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // optional
        }

    }
}
