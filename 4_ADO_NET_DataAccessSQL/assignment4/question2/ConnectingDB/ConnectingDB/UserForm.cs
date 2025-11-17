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
    public partial class UserForm : Form
    {
        public UserForm(string username)
        {
            InitializeComponent();
            Text = "User";

            var lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold),
                Text = $"Hello user, {username}"
            };

            Controls.Add(lbl);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // optional
        }

    }
}
