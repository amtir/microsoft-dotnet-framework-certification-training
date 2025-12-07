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
    public partial class MyReport : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        void BindGrid()
        {
            if (Session["UserId"] == null)   // safety
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            int studentId = Convert.ToInt32(Session["UserId"]);

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT b.BookName, b.Author,
                         i.IssueDate, i.DueDate, i.ReturnDate, i.Penalty
                  FROM IssueBook i
                  JOIN Book b ON i.BookId = b.BookId
                  WHERE i.StudentId = @sid
                  ORDER BY i.IssueDate DESC", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@sid", studentId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvMyReport.DataSource = dt;
                gvMyReport.DataBind();
            }
        }

    }
}