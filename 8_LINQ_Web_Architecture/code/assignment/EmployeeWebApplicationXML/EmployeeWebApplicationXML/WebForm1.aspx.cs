using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EmployeeWebApplicationXML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Load the XML file
                XElement doc = XElement.Load(Server.MapPath("Employees.xml"));

                var data =
                    from emp in doc.Descendants("employee")
                    select new
                    {
                        EmpId = (int)emp.Element("empid"),
                        EmpName = (string)emp.Element("empname"),
                        Salary = (int)emp.Element("salary"),
                        Gender = (string)emp.Element("gender")
                    };

                GridView1.DataSource = data.ToList();
                GridView1.DataBind();
            }
        }
    }
}