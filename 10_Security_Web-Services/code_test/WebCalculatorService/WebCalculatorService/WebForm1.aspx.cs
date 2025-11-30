using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebCalculatorService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtFirst.Text);
            double b = double.Parse(txtSecond.Text);

            // create proxy object
            CalculatorClient.WebServiceCalculator ws = new CalculatorClient.WebServiceCalculator();

            double result = 0;

            switch (ddlOperation.SelectedValue)
            {
                case "Add":
                    result = ws.Add(a, b);
                    break;

                case "Subtract":
                    result = ws.Subtract(a, b);
                    break;

                case "Multiply":
                    result = ws.Multiply(a, b);
                    break;

                case "Divide":
                    result = ws.Divide(a, b);   // will throw if b == 0
                    break;
            }

            lblResult.Text = result.ToString();

        }
    }
}