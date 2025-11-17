using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number (Table to be calculated): ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table of {num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            Console.ReadLine();
        }
    }
}
