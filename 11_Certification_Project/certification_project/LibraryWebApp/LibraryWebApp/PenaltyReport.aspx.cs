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
    public partial class PenaltyReport : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadBranches();
                LoadStudents();
                BindGrid();
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

                ddlBranch.Items.Insert(0, new System.Web.UI.WebControls.ListItem("All Branches", "0"));
            }
        }

        void LoadStudents()
        {
            string sql = @"SELECT StudentId, Name 
                           FROM Student";

            if (ddlBranch.SelectedValue != "0")
                sql += " WHERE BranchId = @bid";

            sql += " ORDER BY Name";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                if (ddlBranch.SelectedValue != "0")
                    da.SelectCommand.Parameters.AddWithValue("@bid", ddlBranch.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlStudent.DataSource = dt;
                ddlStudent.DataTextField = "Name";
                ddlStudent.DataValueField = "StudentId";
                ddlStudent.DataBind();

                ddlStudent.Items.Insert(0, new System.Web.UI.WebControls.ListItem("All Students", "0"));
            }
        }

        protected void ddlBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
            BindGrid();
        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            string sql = @"
                SELECT s.Name AS StudentName,
                       b.BookName,
                       i.IssueDate,
                       i.DueDate,
                       i.ReturnDate,
                       i.Penalty
                FROM IssueBook i
                JOIN Student s ON i.StudentId = s.StudentId
                JOIN Book b    ON i.BookId = b.BookId
                WHERE i.Penalty > 0";

            if (ddlBranch.SelectedValue != "0")
                sql += " AND s.BranchId = @bid";

            if (ddlStudent.SelectedValue != "0")
                sql += " AND s.StudentId = @sid";

            sql += " ORDER BY s.Name, i.IssueDate DESC";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                if (ddlBranch.SelectedValue != "0")
                    da.SelectCommand.Parameters.AddWithValue("@bid", ddlBranch.SelectedValue);

                if (ddlStudent.SelectedValue != "0")
                    da.SelectCommand.Parameters.AddWithValue("@sid", ddlStudent.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPenalty.DataSource = dt;
                gvPenalty.DataBind();
            }
        }

    }
}