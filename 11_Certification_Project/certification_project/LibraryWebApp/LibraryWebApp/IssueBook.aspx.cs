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
    public partial class IssueBook : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
                LoadFilterStudents();
                LoadPublications();
                LoadBooks();
                BindIssuedGrid();
            }
        }

        protected void ddlFilterStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindIssuedGrid();
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

        void LoadFilterStudents()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT StudentId, Name FROM Student ORDER BY Name", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlFilterStudent.DataSource = dt;
                ddlFilterStudent.DataTextField = "Name";
                ddlFilterStudent.DataValueField = "StudentId";
                ddlFilterStudent.DataBind();
                ddlFilterStudent.Items.Insert(0, new System.Web.UI.WebControls.ListItem("All Students", "0"));
            }
        }


        void LoadPublications()
        {
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT PublicationId, PublicationName FROM Publication ORDER BY PublicationName", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlPublication.DataSource = dt;
                ddlPublication.DataTextField = "PublicationName";
                ddlPublication.DataValueField = "PublicationId";
                ddlPublication.DataBind();
            }
        }

        void LoadBooks()
        {
            if (ddlPublication.Items.Count == 0) return;

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT BookId, BookName FROM Book WHERE PublicationId=@pid ORDER BY BookName", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@pid", ddlPublication.SelectedValue);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlBook.DataSource = dt;
                ddlBook.DataTextField = "BookName";
                ddlBook.DataValueField = "BookId";
                ddlBook.DataBind();
            }
        }

        protected void ddlPublication_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        void BindIssuedGrid()
        {
            string sql = @"
        SELECT i.IssueId,
               s.Name AS Student,
               b.BookName,
               i.IssueDate,
               i.DueDate,
               i.ReturnDate
        FROM IssueBook i
        JOIN Student s ON i.StudentId = s.StudentId
        JOIN Book b ON i.BookId = b.BookId
        WHERE i.ReturnDate IS NULL";

            if (ddlFilterStudent.SelectedValue != "0")
                sql += " AND i.StudentId = @sid";

            sql += " ORDER BY i.IssueDate DESC";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                if (ddlFilterStudent.SelectedValue != "0")
                    da.SelectCommand.Parameters.AddWithValue("@sid", ddlFilterStudent.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gvIssued.DataSource = dt;
                gvIssued.DataBind();
            }
        }


        protected void btnIssue_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            int studentId = int.Parse(ddlStudent.SelectedValue);
            int bookId = int.Parse(ddlBook.SelectedValue);

            int days = 14;
            int.TryParse(txtDays.Text, out days);
            DateTime issueDate = DateTime.Today;
            DateTime dueDate = issueDate.AddDays(days);

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // check quantity
                int qty = 0;
                using (SqlCommand cmdQty = new SqlCommand(
                    "SELECT Quantity FROM Book WHERE BookId=@id", con))
                {
                    cmdQty.Parameters.AddWithValue("@id", bookId);
                    object q = cmdQty.ExecuteScalar();
                    if (q != null) qty = Convert.ToInt32(q);
                }

                if (qty <= 0)
                {
                    lblMsg.Text = "No copies available for this book.";
                    return;
                }

                // insert into IssueBook
                using (SqlCommand cmdIns = new SqlCommand(
                    @"INSERT INTO IssueBook (StudentId, BookId, IssueDate, DueDate)
                      VALUES (@sid, @bid, @idate, @ddate)", con))
                {
                    cmdIns.Parameters.AddWithValue("@sid", studentId);
                    cmdIns.Parameters.AddWithValue("@bid", bookId);
                    cmdIns.Parameters.AddWithValue("@idate", issueDate);
                    cmdIns.Parameters.AddWithValue("@ddate", dueDate);
                    cmdIns.ExecuteNonQuery();
                }

                // decrease quantity
                using (SqlCommand cmdUpd = new SqlCommand(
                    "UPDATE Book SET Quantity = Quantity - 1 WHERE BookId=@id", con))
                {
                    cmdUpd.Parameters.AddWithValue("@id", bookId);
                    cmdUpd.ExecuteNonQuery();
                }
            }

            lblMsg.Text = "Book issued successfully.";
            BindIssuedGrid();
        }

    }
}