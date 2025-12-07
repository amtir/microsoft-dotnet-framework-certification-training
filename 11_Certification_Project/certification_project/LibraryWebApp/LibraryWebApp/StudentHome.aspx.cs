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
    public partial class StudentHome : System.Web.UI.Page
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
                lblStudentName.Text = Session["UserName"] as string;
                LoadSummary();
            }
        }

        private void LoadSummary()
        {
            int studentId = Convert.ToInt32(Session["UserId"]);

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // books currently issued (no return date)
                lblActiveLoans.Text = GetInt(con,
                    "SELECT COUNT(*) FROM IssueBook WHERE StudentId=@sid AND ReturnDate IS NULL",
                    studentId).ToString();

                // total books ever borrowed
                lblTotalLoans.Text = GetInt(con,
                    "SELECT COUNT(*) FROM IssueBook WHERE StudentId=@sid",
                    studentId).ToString();

                // total penalty (sum)
                decimal totalPenalty = GetDecimal(con,
                    "SELECT ISNULL(SUM(Penalty),0) FROM IssueBook WHERE StudentId=@sid",
                    studentId);

                lblTotalPenalty.Text = totalPenalty.ToString("C");
            }
        }

        private int GetInt(SqlConnection con, string sql, int studentId)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private decimal GetDecimal(SqlConnection con, string sql, int studentId)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

    }
}