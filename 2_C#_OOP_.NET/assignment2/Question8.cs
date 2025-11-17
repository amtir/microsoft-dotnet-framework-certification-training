using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int score = 0;
            string choice;

            do
            {
                int num1 = rnd.Next(1, 11);
                int num2 = rnd.Next(1, 11);

                Console.WriteLine($"What's {num1} times {num2}?");
                int answer;

                // Input validation
                while (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Please enter a valid integer!");
                }

                if (answer == num1 * num2)
                {
                    Console.WriteLine("That's the correct answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong answer! The correct answer was {num1 * num2}");
                }

                Console.WriteLine($"Your score: {score}");

                Console.Write("\nDo you want another question? (y/n): ");
                choice = Console.ReadLine()?.ToLower();

            } while (choice == "y" || choice == "yes");

            Console.WriteLine($"\nFinal Score: {score}");
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}
