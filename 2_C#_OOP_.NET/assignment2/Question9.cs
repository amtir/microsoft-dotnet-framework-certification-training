using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            int length = input.Length;

            Console.WriteLine($"Length of the string is : {length}");
            Console.ReadLine();
        }
    }
}
