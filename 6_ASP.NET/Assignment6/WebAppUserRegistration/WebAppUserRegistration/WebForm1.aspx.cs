using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppUserRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                lblResult.CssClass = "msg-err";
                lblResult.Text = "Please fix the highlighted errors.";
                return;
            }

            try
            {
                // 1) Build salt + hash
                var salt = new byte[16];
                using (var rng = RandomNumberGenerator.Create())
                    rng.GetBytes(salt);

                var pwdBytes = Encoding.UTF8.GetBytes(txtPassword.Text);
                var toHash = salt.Concat(pwdBytes).ToArray();      // salt + password
                byte[] hash;
                using (var sha = SHA256.Create())
                    hash = sha.ComputeHash(toHash);

                // 2) Insert
                var cs = ConfigurationManager.ConnectionStrings["AppDb"].ConnectionString;

                using (var con = new SqlConnection(cs))
                using (var cmd = new SqlCommand(@"
INSERT dbo.Users
(FirstName, LastName, Mobile, Gender, [Address], UserName, PasswordSalt, PasswordHash)
VALUES (@fn, @ln, @mob, @gen, @addr, @un, @salt, @hash);
", con))
                {
                    cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@mob", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@gen", ddlGender.SelectedValue);
                    cmd.Parameters.AddWithValue("@addr", (object)txtAddress.Text.Trim() ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@un", txtUserName.Text.Trim());
                    cmd.Parameters.Add("@salt", SqlDbType.VarBinary, 16).Value = salt;
                    cmd.Parameters.Add("@hash", SqlDbType.VarBinary, 32).Value = hash;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // 3) Success UI
                ClearForm();
                lblResult.CssClass = "msg-ok";
                lblResult.Text = "✅ User registered successfully.";
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601) // unique key violation
            {
                lblResult.CssClass = "msg-err";
                lblResult.Text = "This user name already exists. Choose another.";
            }
            catch (Exception ex)
            {
                lblResult.CssClass = "msg-err";
                lblResult.Text = "Registration failed: " + ex.Message;
            }
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            ddlGender.SelectedIndex = 0;
            txtAddress.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}