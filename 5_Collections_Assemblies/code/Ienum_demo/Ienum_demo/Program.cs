using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ienum_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> l = new List<string>();
            l.Add("A");
            l.Add("B");
            l.Add("AC");
            l.Add("D");
            l.Add("AE");
            l.Add("F");
            
            IEnumerable names = from n in l where (n.StartsWith("A")) select n;
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
