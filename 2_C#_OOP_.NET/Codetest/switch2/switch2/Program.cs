using System;

namespace switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day in a week ? ");
            int day = 4;
            Console.WriteLine("Enter he number between 1 to 7:  ");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.Read();

            }
    }
}
