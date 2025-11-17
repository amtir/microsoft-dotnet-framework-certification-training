using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum side of Triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minimum side of Triangle: ");
            int side2 = Convert.ToInt32(Console.ReadLine());

            int maxEdge = side1 + side2 - 1;
            int minEdge = Math.Abs(side1 - side2) + 1;

            Console.WriteLine($"Maximum edge = {maxEdge}");
            Console.WriteLine($"Minimum edge = {minEdge}");

            Console.ReadLine();
        }
    }
}
