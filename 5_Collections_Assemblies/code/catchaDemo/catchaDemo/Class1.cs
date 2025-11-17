using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catchaDemo
{
    public class Class1
    {
        int number = 0;
        public int rand()
        {
            Random r = new Random();
            number = r.Next(100,1000);
            return number;
        }

    }
}
