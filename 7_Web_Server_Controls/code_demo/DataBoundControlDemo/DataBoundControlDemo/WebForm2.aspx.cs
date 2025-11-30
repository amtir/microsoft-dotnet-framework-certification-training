using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DataBoundControlDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDetailsView();
            }
        }

        private void BindDetailsView()
        {
            SqlConnection con = new SqlConnection(
@"Server=LAPTOP-85MTF1DV;Database=EmployeeDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand("select * from employee", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DetailsView1.DataSource = dt;
            DetailsView1.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            this.BindDetailsView();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}