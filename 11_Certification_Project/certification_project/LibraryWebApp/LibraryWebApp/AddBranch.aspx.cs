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
    public partial class AddBranch : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Branch", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvBranch.DataSource = dt;
                gvBranch.DataBind();
            }
        }

        protected void btnAddBranch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBranchName.Text))
            {
                lblMsg.Text = "Please enter a branch name.";
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Branch(BranchName) VALUES(@name)", con))
            {
                cmd.Parameters.AddWithValue("@name", txtBranchName.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
            }

            txtBranchName.Text = "";
            lblMsg.Text = "Branch added.";
            BindGrid();
        }

        protected void gvBranch_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvBranch.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gvBranch_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvBranch.EditIndex = -1;
            BindGrid();
        }

        protected void gvBranch_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int id = (int)gvBranch.DataKeys[e.RowIndex].Value;
            string name = ((System.Web.UI.WebControls.TextBox)
                gvBranch.Rows[e.RowIndex].Cells[1].Controls[0]).Text;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Branch SET BranchName=@name WHERE BranchId=@id", con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            gvBranch.EditIndex = -1;
            BindGrid();
        }

        protected void gvBranch_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = (int)gvBranch.DataKeys[e.RowIndex].Value;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM Branch WHERE BranchId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            BindGrid();
        }


    }
}