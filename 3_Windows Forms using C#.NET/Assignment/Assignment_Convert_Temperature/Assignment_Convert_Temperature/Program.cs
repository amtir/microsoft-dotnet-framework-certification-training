using System;

namespace Assignment_Convert_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
while (running)
            {
                Console.WriteLine("\n=== Assignment 1 Menu ===");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Generate Fibonacci Series");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertTemperature();
                        break;

                    case "2":
                        GenerateFibonacci();
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }

                Console.WriteLine("\n---------------------------------\n");
            }

            Console.ReadKey();
        }
            
        

        // Question 1
        static void ConvertTemperature()
        {
            Console.Write("Enter Celsius Temperature: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Fahrenheit Temperature is : {fahrenheit:F1}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        // Question 2
        static void GenerateFibonacci()
        {
            Console.Write("Enter number of terms for Fibonacci Series: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int first = 0, second = 1;

                Console.Write("Fibonacci Series: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(first + " ");
                    int next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}