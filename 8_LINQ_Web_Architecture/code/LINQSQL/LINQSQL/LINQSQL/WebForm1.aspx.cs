using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create DataContext (auto-generated from .dbml file)
            string conn = System.Configuration.ConfigurationManager
    .ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;

            DataClasses1DataContext DB = new DataClasses1DataContext(conn);

            // LINQ Query
            var result = from n in DB.Employees
                         select n;

            // Bind to GridView
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
    }
}