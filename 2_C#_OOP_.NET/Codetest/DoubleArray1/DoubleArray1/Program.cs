using System;

namespace DoubleArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double Array Example: ");
            int[,] a = new int[3, 2]
                {
                { 1,2}, { 3,4}, { 5,6}
                };

            Console.WriteLine(a[0, 0]);
            Console.WriteLine(a[0, 1]);
            Console.WriteLine(a[1, 0]);
            Console.WriteLine(a[1, 1]);
            Console.WriteLine(a[2, 0]);
            Console.WriteLine(a[2, 1]);
            Console.Read();
        }
    }
}
