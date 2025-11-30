using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBoundControlDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFormView();
            }
        }

        private void BindFormView()
        {
            SqlConnection con = new SqlConnection(
@"Server=LAPTOP-85MTF1DV;Database=EmployeeDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand("select * from employee", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            FormView1.DataSource = dt;
            FormView1.DataBind();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            this.BindFormView();
        }
    }
}