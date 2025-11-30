using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DAL
{
    public class Class1
    {
    }

    public class DL
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=LAPTOP-85MTF1DV;
      Initial Catalog=Employees;
      Integrated Security=True;
      TrustServerCertificate=True");


        public void insertData(string name, string city, string email)
        {
            SqlDataAdapter sda = new SqlDataAdapter("insert into user101 values('"+name+"','"+city+"','"+email+"')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }

        public object selectData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from user101", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

    }
}
