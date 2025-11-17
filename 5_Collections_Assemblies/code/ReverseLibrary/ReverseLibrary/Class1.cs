using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLibrary
{
    public class ReverseClass
    {
        // Method to reverse an integer number
        public int ReverseNumber(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }
            return rev;
        }

        // Optional: Reverse a string (for textbox2)
        public string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
