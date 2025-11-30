using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DataBoundControlDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=laptop-85mtf1dv\\;Initial Catalog=EmployeeDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


            SqlConnection con = new SqlConnection(
    @"Server=LAPTOP-85MTF1DV;Database=EmployeeDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


            SqlCommand cmd = new SqlCommand("select * from employee", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}