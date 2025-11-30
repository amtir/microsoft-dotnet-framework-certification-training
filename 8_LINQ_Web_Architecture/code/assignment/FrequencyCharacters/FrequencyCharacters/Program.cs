using System;
using System.Linq;

namespace FrequencyCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nThe frequency of the characters are:");

            var result =
                from c in input
                group c by c into g
                select new
                {
                    Character = g.Key,
                    Count = g.Count()
                };

            foreach (var item in result)
            {
                Console.WriteLine($"Character {item.Character}: {item.Count} times");
            }

            Console.ReadLine();
        }
    }
}
