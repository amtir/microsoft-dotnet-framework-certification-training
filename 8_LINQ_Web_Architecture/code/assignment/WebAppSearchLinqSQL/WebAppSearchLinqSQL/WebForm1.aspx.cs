using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSearchLinqSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            txtName.Text = txtFather.Text = txtMother.Text = "";

            if (!int.TryParse(txtRollNo.Text.Trim(), out int rollNo))
            {
                lblStatus.Text = "Please enter a valid numeric Roll No.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string connString = ConfigurationManager
                .ConnectionStrings["StudentsConnectionString"].ConnectionString;

            using (var db = new DataClasses1DataContext(connString))
            {
                // LINQ to SQL query
                var student =
                    (from s in db.CollegeTables
                     where s.RollNo == rollNo
                     select s).SingleOrDefault();

                if (student == null)
                {
                    lblStatus.Text = "No record found.";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    txtName.Text = student.Name;
                    txtFather.Text = student.FathersName;
                    txtMother.Text = student.MothersName;

                    lblStatus.Text = "Record found successfully.";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}