using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebApp
{
    public partial class MyAccount : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadBranches();
                LoadStudentData();
            }
        }


        void LoadBranches()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT BranchId, BranchName FROM Branch ORDER BY BranchName", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlBranch.DataSource = dt;
                ddlBranch.DataTextField = "BranchName";
                ddlBranch.DataValueField = "BranchId";
                ddlBranch.DataBind();
            }
        }

        void LoadStudentData()
        {
            int studentId = Convert.ToInt32(Session["UserId"]);

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT Name, BranchId, Mobile, Address, City, Pincode, Email
                  FROM Student WHERE StudentId = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", studentId);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        ddlBranch.SelectedValue = dr["BranchId"].ToString();
                        txtMobile.Text = dr["Mobile"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        txtCity.Text = dr["City"].ToString();
                        txtPincode.Text = dr["Pincode"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(Session["UserId"]);

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE Student
                  SET Name=@name, BranchId=@branch, Mobile=@mobile, Address=@addr,
                      City=@city, Pincode=@pin, Email=@mail
                  WHERE StudentId=@id", con))
            {
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@branch", ddlBranch.SelectedValue);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                cmd.Parameters.AddWithValue("@pin", txtPincode.Text.Trim());
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@id", studentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            lblProfileMsg.Text = "Profile updated successfully.";
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            lblPwdMsg.Text = "";

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                lblPwdMsg.Text = "New password and confirmation do not match.";
                return;
            }

            int studentId = Convert.ToInt32(Session["UserId"]);
            string oldPwd = txtOldPassword.Text.Trim();
            string newPwd = txtNewPassword.Text.Trim();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // 1) Check old password
                using (SqlCommand cmdCheck = new SqlCommand(
                    "SELECT COUNT(*) FROM Student WHERE StudentId=@id AND Password=@pwd", con))
                {
                    cmdCheck.Parameters.AddWithValue("@id", studentId);
                    cmdCheck.Parameters.AddWithValue("@pwd", oldPwd);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count == 0)
                    {
                        lblPwdMsg.Text = "Old password is incorrect.";
                        return;
                    }
                }

                // 2) Update password
                using (SqlCommand cmdUpd = new SqlCommand(
                    "UPDATE Student SET Password=@pwd WHERE StudentId=@id", con))
                {
                    cmdUpd.Parameters.AddWithValue("@pwd", newPwd);
                    cmdUpd.Parameters.AddWithValue("@id", studentId);
                    cmdUpd.ExecuteNonQuery();
                }
            }

            lblPwdMsg.Text = "Password changed successfully.";
            txtOldPassword.Text = txtNewPassword.Text = txtConfirmPassword.Text = "";
        }

    }
}