using System;
using System.Net.NetworkInformation;

namespace Delegate1
{
    internal class Program
    {
        delegate int calculator(int n);

        public class dele
        {
            static int number = 100;
            public static int add(int n)
            {
                return number += n;
            }
            public static int subtract(int n) { return number -= n; }
            public static int multiply(int n) { return number *= n; }

            public static int getNumbers()
            {
                return number;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates ...");

            calculator c1 = new calculator(dele.add);
            calculator c2 = new calculator(dele.multiply);

            c1(20);
            Console.WriteLine("After c1 delegate, number is :" + dele.getNumbers());
            c2(3);
            Console.WriteLine("After c2 delegate, number is :" + dele.getNumbers());


        }
    }
}
