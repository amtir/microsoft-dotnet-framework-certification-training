using System;

namespace SingleArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Array Example: Cars");
            string[] cars = { "BMW", "Benz", "Hunday", "Ford" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.Read();
        }
    }
}
