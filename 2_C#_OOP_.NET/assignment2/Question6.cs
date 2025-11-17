using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of steps to print: ");
            int steps = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= steps; i++)
            {
                // print two rows for each step
                for (int row = 1; row <= 2; row++)
                {
                    for (int star = 1; star <= i; star++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
