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
    public partial class AddPublication : System.Web.UI.Page
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
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Publication", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPub.DataSource = dt;
                gvPub.DataBind();
            }
        }

        protected void btnAddPub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPubName.Text))
            {
                lblMsg.Text = "Please enter a publication name.";
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Publication(PublicationName) VALUES(@name)", con))
            {
                cmd.Parameters.AddWithValue("@name", txtPubName.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
            }

            txtPubName.Text = "";
            lblMsg.Text = "Publication added.";
            BindGrid();
        }

        protected void gvPub_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvPub.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gvPub_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvPub.EditIndex = -1;
            BindGrid();
        }

        protected void gvPub_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int id = (int)gvPub.DataKeys[e.RowIndex].Value;
            string name = ((System.Web.UI.WebControls.TextBox)
                gvPub.Rows[e.RowIndex].Cells[1].Controls[0]).Text;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Publication SET PublicationName=@name WHERE PublicationId=@id", con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            gvPub.EditIndex = -1;
            BindGrid();
        }

        protected void gvPub_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = (int)gvPub.DataKeys[e.RowIndex].Value;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM Publication WHERE PublicationId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            BindGrid();
        }


    }
}