using System;

namespace Cal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;
            while (true)
            {
                Console.WriteLine("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the operand: ");
            operand = Console.ReadLine();

            switch (operand)
            {
                case "-":
                        answer = num1 - num2;
                        Console.WriteLine(num1.ToString() + "-" + num2.ToString() + " = "
     + answer.ToString());
                        break;

                    case "+":
                        answer = num1 + num2;
                        Console.WriteLine(num1.ToString() + "+" + num2.ToString() + " = "
     + answer.ToString());
                        break;


                    case "/":
                        answer = num1 / num2;
                        Console.WriteLine(num1.ToString() + "/" + num2.ToString() + " = "
     + answer.ToString());
                        break;


                    case "*":
                        answer = num1 * num2;
                        Console.WriteLine(num1.ToString() + "*" + num2.ToString() + " = "
     + answer.ToString());
                        break;

                    }

                    Console.WriteLine("\n\n Do you want to Break (Y/N)");
                    status = Console.ReadKey();
                    if (status.Key == ConsoleKey.Y)
                    {
                        break;
                    }
                    Console.Clear();

                }

        }
    }
}
