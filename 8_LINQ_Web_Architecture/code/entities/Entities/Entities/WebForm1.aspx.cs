using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entities
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindgridData();
            }
        }

        private void bindgridData()
        {
            using (var db = new EmployeesEntities())   // 👈 your EF context
            {
                var result =
                    from emp in db.employees        // 👈 your table: employee.cs
                    select new
                    {
                        Name = emp.name,
                        Occupation = emp.occupation,
                        WorkingDate = emp.working_date,
                        WorkingHours = emp.working_hours,
                        Salary = emp.salary
                    };

                GridView1.DataSource = result.ToList();
                GridView1.DataBind();
            }
        }


    }
}