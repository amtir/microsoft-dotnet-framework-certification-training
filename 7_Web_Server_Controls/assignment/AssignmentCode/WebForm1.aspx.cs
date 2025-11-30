using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQuestion1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string ConnStr =>
            ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(
                @"INSERT INTO Worker (Name, Occupation, PhoneNumber, Location)
                  VALUES (@Name, @Occupation, @Phone, @Location)", con))
            {
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Occupation", txtOccupation.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                lblMessage.Text = rows > 0 ? "Inserted successfully." : "Nothing inserted.";
            }

            ClearInputs();

        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtOccupation.Text = "";
            txtPhone.Text = "";
            txtLocation.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(
                @"DELETE FROM Worker WHERE PhoneNumber=@Phone", con))
            {
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                lblMessage.Text = rows > 0 ? "Deleted successfully." : "No record found to delete.";
            }

            ClearInputs();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(
                @"UPDATE Worker
                  SET Name=@Name, Occupation=@Occupation, Location=@Location
                  WHERE PhoneNumber=@Phone", con))
            {
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Occupation", txtOccupation.Text.Trim());
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                lblMessage.Text = rows > 0 ? "Updated successfully." : "No record found to update.";
            }
        }
    }
}