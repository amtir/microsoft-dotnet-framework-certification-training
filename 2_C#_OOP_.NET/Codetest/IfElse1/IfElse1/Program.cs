using System;

namespace IfElse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Or Odd Number? ");

            int num ;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine(num + "  is a even number.");
            }
            else
            {
                Console.WriteLine(num + " is an odd number.");
            }
            Console.Read();
        }
    }
}
