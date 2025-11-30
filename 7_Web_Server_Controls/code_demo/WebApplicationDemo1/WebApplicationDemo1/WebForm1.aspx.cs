using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDemo1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "Plesae select a city";
            Panel1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder choices = new StringBuilder();
            if (CheckBox1.Checked)
                choices.Append(CheckBox1.Text);
            if (CheckBox2.Checked)
                choices.Append(", " + CheckBox2.Text);
            if (CheckBox3.Checked)
                choices.Append(", " + CheckBox3.Text);

            Response.Write("Your selections: " + choices.ToString());

            if (RadioButton1.Checked)
                Label1.Text = "Welcome " + TextBox2.Text + " " + RadioButton1.Text;//DateTime.Now.ToString();
            else
                Label1.Text = "Welcome " + TextBox2.Text + " " + RadioButton2.Text;//DateTime.Now.ToString();

            Literal1.Text = DateTime.Now.ToString();

            if (DropDownList1.SelectedValue == "")
                Label2.Text = "Plesae select a city";
            else
                Label2.Text = "You oprion is: " + DropDownList1.SelectedItem;

            Label3.Text = RadioButtonList1.SelectedItem.ToString();
            Label4.Text = RadioButtonList1.SelectedValue.ToString();


            foreach(ListItem li in CheckBoxList1.Items)
                if (li.Selected)
                {
                    Response.Write("<br>---------");
                    Response.Write ("Text :" + li.Text + ", ");
                    Response.Write("Value :" + li.Value + ", ");
                    Response.Write("Index :" + CheckBoxList1.Items.IndexOf(li));
                    Response.Write("---------<br>");

                }

            string msg = ""; 
            foreach(ListItem li in ListBox1.Items)
            {
                if(li.Selected == true)
                {
                    msg += "<br> " + li.Text + " is selected.";
                }

            }
            Label5.Text = msg;

            if (FileUpload1.HasFile )
            {
                FileUpload1.SaveAs(@"D:\NET\7_Web_Server_Controls\Web_Server_Controls_2\" + FileUpload1.FileName) ;             
                
                Label7.Text = "File Uploaded : " + FileUpload1.FileName; 
                }
            else
            {
                Label7.Text = "File NOT Uploaded : " + FileUpload1.FileName;
            }

        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedIndex == 0)
            {
                Panel1.Visible = true;
            }
        }
    }
}