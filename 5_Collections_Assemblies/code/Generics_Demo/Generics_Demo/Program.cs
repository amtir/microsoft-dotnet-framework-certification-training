using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics_Demo
{

    class gen<T>
    {
        private T a;

        public gen(T a)
        {
            this.a = a;
        }
        public void getValue()
        {
            Console.WriteLine("The value is : " + a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gen<string> g = new gen<string>("Random String ...");
            g.getValue();

            gen<int> g1 = new gen<int>(123);
            g1.getValue();

            gen<double> g3 = new gen<double>(0.1234);
            g3.getValue();
            Console.ReadKey();
        }
    }
}
