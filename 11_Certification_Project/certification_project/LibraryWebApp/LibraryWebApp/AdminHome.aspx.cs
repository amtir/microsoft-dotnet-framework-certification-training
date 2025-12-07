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
    public partial class AdminHome : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblAdminName.Text = Session["UserName"] as string;
                LoadCounts();
            }
        }


        private void LoadCounts()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                lblBranchCount.Text = GetCount(con, "SELECT COUNT(*) FROM Branch").ToString();
                lblPubCount.Text = GetCount(con, "SELECT COUNT(*) FROM Publication").ToString();
                lblBookCount.Text = GetCount(con, "SELECT COUNT(*) FROM Book").ToString();
                lblStudentCount.Text = GetCount(con, "SELECT COUNT(*) FROM Student").ToString();

                // active issued books = those not yet returned
                lblIssuedCount.Text = GetCount(con,
                    "SELECT COUNT(*) FROM IssueBook WHERE ReturnDate IS NULL").ToString();

                lblOverdueCount.Text = GetCount(con,
    "SELECT COUNT(*) FROM IssueBook WHERE ReturnDate IS NULL AND DueDate < GETDATE()").ToString();

            }
        }

        private int GetCount(SqlConnection con, string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                return (int)cmd.ExecuteScalar();
            }
        }

    }
}