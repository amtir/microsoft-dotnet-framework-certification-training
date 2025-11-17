using System;
using System.Collections;

namespace Stack_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("India");
            s.Push("UK");
            s.Push("US");
            s.Push("NL");
            s.Push("Berlin");

            Console.WriteLine("The Countries are: ");
            foreach (var i in s) {

                Console.WriteLine(i + " ");
            }

            s.Pop();
            s.Pop();
            s.Push("FR");
            Console.WriteLine("......");
            foreach (var i in s)
            {

                Console.WriteLine(i + " ");
            }

            Console.ReadLine();
        }
    }
}
