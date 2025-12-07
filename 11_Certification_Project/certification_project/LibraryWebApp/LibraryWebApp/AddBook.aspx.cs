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
    public partial class AddBook : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDowns();
                BindGrid();
            }
        }

        void LoadDropDowns()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // publications
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PublicationId, PublicationName FROM Publication", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlPublication.DataSource = dt;
                    ddlPublication.DataTextField = "PublicationName";
                    ddlPublication.DataValueField = "PublicationId";
                    ddlPublication.DataBind();
                }

                // branches
                using (SqlDataAdapter da2 = new SqlDataAdapter(
                    "SELECT BranchId, BranchName FROM Branch", con))
                {
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    ddlBranch.DataSource = dt2;
                    ddlBranch.DataTextField = "BranchName";
                    ddlBranch.DataValueField = "BranchId";
                    ddlBranch.DataBind();
                }
            }
        }

        void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT b.BookId, b.BookName, b.Author, 
                         p.PublicationName, br.BranchName,
                         b.Price, b.Quantity
                  FROM Book b
                  JOIN Publication p ON b.PublicationId = p.PublicationId
                  JOIN Branch br ON b.BranchId = br.BranchId", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvBooks.DataSource = dt;
                gvBooks.DataBind();
            }
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            decimal price;
            int qty;

            if (!decimal.TryParse(txtPrice.Text, out price) ||
                !int.TryParse(txtQty.Text, out qty))
            {
                lblMsg.Text = "Invalid price or quantity.";
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Book
                  (BookName, Details, Author, PublicationId, BranchId, Price, Quantity)
                  VALUES (@name, @details, @auth, @pub, @branch, @price, @qty)", con))
            {
                cmd.Parameters.AddWithValue("@name", txtBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@details", txtDetails.Text.Trim());
                cmd.Parameters.AddWithValue("@auth", txtAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@pub", ddlPublication.SelectedValue);
                cmd.Parameters.AddWithValue("@branch", ddlBranch.SelectedValue);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", qty);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            lblMsg.Text = "Book added.";
            txtBookName.Text = txtDetails.Text = txtAuthor.Text =
                txtPrice.Text = txtQty.Text = "";

            BindGrid();
        }

    }
}