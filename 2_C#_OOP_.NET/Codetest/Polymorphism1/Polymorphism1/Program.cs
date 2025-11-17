using System;

namespace Polymorphism1
{
    class One
    {
        public void display()
        {
            Console.WriteLine("Empty method");
        }
        public void display(int a)
        {
            Console.WriteLine("Integer : " + a);
        }

        public void display(double a)
        {
            Console.WriteLine("Double : " + a);
        }

        public void display(string a)
        {
            Console.WriteLine("String : " + a);
        }

        public void display(int a, int b)
        {
            Console.WriteLine("Multiplied value : " + a*b);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polimorphism ...");
            One o = new One();
            o.display();
            o.display(123);
            o.display("John");
            o.display(123, 456);
            o.display(9.876);

            Console.ReadKey();

        }
    }
}
