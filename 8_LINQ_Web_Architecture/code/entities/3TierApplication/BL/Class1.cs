using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Class1
    {
    }

        public class BLL { 
        
            DL ob1 = new DL();
            public void Inputuser(string name, string city, string email) 
            {
                ob1.insertData(name, city, email);
            }

            public object selectUser()
            {
                return ob1.selectData();
            }


        }
}
