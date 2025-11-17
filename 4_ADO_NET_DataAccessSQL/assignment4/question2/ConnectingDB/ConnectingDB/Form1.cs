using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace ConnectingDB
{
    public partial class LoginForm : Form
    {

        private readonly string _cs = ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill dropdown if not set in designer
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("admin");
                cmbRole.Items.Add("non admin");
            }
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text; // plaintext for assignment
            var role = (cmbRole.SelectedItem ?? "").ToString();

            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Enter username, password, and select role.");
                return;
            }

            try
            {
                using (var con = new SqlConnection(_cs))
                using (var cmd = new SqlCommand(
                    @"SELECT COUNT(*) 
                      FROM dbo.AppUsers 
                      WHERE Username = @u AND Password = @p AND RoleName = @r;", con))
                {
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);
                    cmd.Parameters.AddWithValue("@r", role);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        // Open the correct form
                        this.Hide();
                        Form next = role == "admin"
                            ? (Form)new AdminForm(user)
                            : new UserForm(user);

                        next.FormClosed += (s, args2) => this.Close();
                        next.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials or role.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        
    }
    }
}
