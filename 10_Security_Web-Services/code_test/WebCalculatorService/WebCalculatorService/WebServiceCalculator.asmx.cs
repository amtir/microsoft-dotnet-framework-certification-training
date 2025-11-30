using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebCalculatorService
{
    /// <summary>
    /// Summary description for WebServiceCalculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCalculator : System.Web.Services.WebService
    {
        [WebMethod]
        public double Add(double x, double y)
        {
            return x + y;
        }

        [WebMethod]
        public double Subtract(double x, double y)
        {
            return x - y;
        }

        [WebMethod]
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        [WebMethod]
        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return x / y;
        }

    }
}
