using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Idict_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary d = new Dictionary<int, object>();
            d.Add(1, "Sam");
            d.Add(2, "John");
            d.Add(3, "Smith");

            Console.WriteLine(d[1]);
            Console.WriteLine(d[2]);
            Console.WriteLine(d[3]);
        }
    }
}
