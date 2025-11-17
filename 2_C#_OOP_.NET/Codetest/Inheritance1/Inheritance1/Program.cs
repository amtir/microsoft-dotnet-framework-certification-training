using System;

namespace Inheritance1
{
    class Number
    {
        protected int num1;
        public Number(int num1 = 0) { 
            this.num1 = num1;
        }

        public void GetNumber() { 
            Console.WriteLine("Number1 = " + num1);
        }

    }

    class Numbers : Number
    {
        private int num2;
        public Numbers(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void GetNumbers()
        {
            Console.WriteLine("Number1 = " + num1);
            Console.WriteLine("Number2 = " + num2);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance ");
            Number n1 = new Number(100);
            n1.GetNumber();

            Numbers n2 = new Numbers(10, 20);
            n2.GetNumber();

            n2.GetNumbers();
            Console.ReadKey();
        }
    }
}
