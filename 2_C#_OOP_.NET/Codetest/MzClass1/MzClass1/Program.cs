using System;

namespace MzClass1
{
    class cal
    {
        int sum;
        int a, b;
        public void set() {
            Console.WriteLine("Entere the Ineger 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entere the Ineger 2: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void get()
        {
            sum = a + b;
            Console.WriteLine("The Sum is : " + sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class ");
            cal c = new cal();
            c.set();
            c.get();
            Console.ReadLine();
        }
    }
}
