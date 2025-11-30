using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQXML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                // Load the XML file
                XElement doc = XElement.Load(Server.MapPath("employee.xml"));

                // Query employees with salary >= 20000
                var result = from n in doc.Descendants("employee")
                             where Convert.ToInt32(n.Element("salary").Value) >= 20000
                             select new
                             {
                                 Id = n.Element("empid").Value,
                                 Name = n.Element("ename").Value,
                                 Salary = n.Element("salary").Value,
                                 Gender = n.Element("gender").Value
                             };

                // Bind result to GridView
                GridView1.DataSource = result;
                GridView1.DataBind();
            }

        }
    }
}