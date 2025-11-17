using System;

namespace ConsoleApp4
{
    abstract class A
    {
        public int i;
        public abstract void display();
    }
    class B : A
    {
        public int j;
        public int sum;
        public override void display()
        {
            sum = i + j;
            Console.WriteLine(+i + "\n" + +j);
            Console.WriteLine("sum is:" + sum);
        }
    }

    enum per
    {
        a,
        b,
        c,
        d,
    }

    internal class Program
    {
        static void Main(string[] args)
        {


        per.a = 10;
        Console.WriteLine(per.b);

            A obj = new B();
            obj.i = 2;
            B obj1 = new B();
            obj1.j = 10;
            obj.display();
            Console.ReadLine();
        }
    }
}
