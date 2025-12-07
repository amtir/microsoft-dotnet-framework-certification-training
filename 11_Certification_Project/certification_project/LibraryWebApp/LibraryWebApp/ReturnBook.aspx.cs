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
    public partial class ReturnBook : System.Web.UI.Page
    {

        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        const decimal PenaltyPerDay = 5m;   // adjust per your needs
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
                BindIssuedGrid();
            }
        }


        void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT StudentId, Name FROM Student ORDER BY Name", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlStudent.DataSource = dt;
                ddlStudent.DataTextField = "Name";
                ddlStudent.DataValueField = "StudentId";
                ddlStudent.DataBind();
            }
        }

        void BindIssuedGrid()
        {
            if (ddlStudent.Items.Count == 0) return;

            int studentId = int.Parse(ddlStudent.SelectedValue);

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT i.IssueId, b.BookName, i.IssueDate, i.DueDate
                  FROM IssueBook i
                  JOIN Book b ON i.BookId = b.BookId
                  WHERE i.StudentId = @sid AND i.ReturnDate IS NULL
                  ORDER BY i.IssueDate", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@sid", studentId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvIssued.DataSource = dt;
                gvIssued.DataBind();
            }
        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindIssuedGrid();
        }

        protected void gvIssued_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ReturnBook")
            {
                int issueId = int.Parse(e.CommandArgument.ToString());
                ReturnIssuedBook(issueId);
                BindIssuedGrid();
            }
        }

        void ReturnIssuedBook(int issueId)
        {
            lblMsg.Text = "";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                int bookId = 0;
                DateTime dueDate = DateTime.Today;

                // get bookId & dueDate
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT BookId, DueDate FROM IssueBook WHERE IssueId=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", issueId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bookId = Convert.ToInt32(dr["BookId"]);
                            dueDate = Convert.ToDateTime(dr["DueDate"]);
                        }
                        else
                        {
                            lblMsg.Text = "Issue record not found.";
                            return;
                        }
                    }
                }

                DateTime returnDate = DateTime.Today;
                //DateTime returnDate = dueDate.AddDays(3);
                decimal penalty = 0;

                if (returnDate > dueDate)
                {
                    int daysLate = (returnDate - dueDate).Days;
                    penalty = daysLate * PenaltyPerDay;
                }

                // update IssueBook
                using (SqlCommand cmdUpd = new SqlCommand(
                    @"UPDATE IssueBook 
                      SET ReturnDate=@rdate, Penalty=@penalty 
                      WHERE IssueId=@id", con))
                {
                    cmdUpd.Parameters.AddWithValue("@rdate", returnDate);
                    cmdUpd.Parameters.AddWithValue("@penalty", penalty);
                    cmdUpd.Parameters.AddWithValue("@id", issueId);
                    cmdUpd.ExecuteNonQuery();
                }

                // increase book quantity
                using (SqlCommand cmdBook = new SqlCommand(
                    "UPDATE Book SET Quantity = Quantity + 1 WHERE BookId=@bid", con))
                {
                    cmdBook.Parameters.AddWithValue("@bid", bookId);
                    cmdBook.ExecuteNonQuery();
                }

                lblMsg.Text = penalty > 0
                    ? $"Book returned. Penalty: {penalty:C}."
                    : "Book returned. No penalty.";
            }
        }


    }
}