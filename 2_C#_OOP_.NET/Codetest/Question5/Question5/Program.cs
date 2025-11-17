using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            DateTime yesterday = today.AddDays(-1);

            Console.WriteLine("Today's Date:");
            Console.WriteLine(today);

            Console.WriteLine("Tomorrow's Date:");
            Console.WriteLine(tomorrow);

            Console.WriteLine("Yesterday's Date:");
            Console.WriteLine(yesterday);

            Console.ReadLine();
        }
    }
}
