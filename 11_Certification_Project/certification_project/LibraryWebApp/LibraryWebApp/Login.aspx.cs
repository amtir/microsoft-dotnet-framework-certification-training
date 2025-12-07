using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                lblMessage.Text = "Please enter email and password.";
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // 1) Check AdminUser
                string queryAdmin = "SELECT AdminId, Name FROM AdminUser " +
                                    "WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(queryAdmin, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // store session info
                            Session["Role"] = "Admin";
                            Session["UserId"] = dr["AdminId"];
                            Session["UserName"] = dr["Name"];

                            Response.Redirect("~/AdminHome.aspx");
                            return;
                        }
                    }
                }

                // 2) Check Student
                string queryStudent = "SELECT StudentId, Name FROM Student " +
                                      "WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(queryStudent, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Session["Role"] = "Student";
                            Session["UserId"] = dr["StudentId"];
                            Session["UserName"] = dr["Name"];

                            Response.Redirect("~/StudentHome.aspx");
                            return;
                        }
                    }
                }
            }

            // if we reach here, login failed
            lblMessage.Text = "Invalid email or password.";

        }
    }
}