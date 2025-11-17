using System;

namespace whileloop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop: ");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);

                i++;
            }
            Console.Read();
        }
    }
}
