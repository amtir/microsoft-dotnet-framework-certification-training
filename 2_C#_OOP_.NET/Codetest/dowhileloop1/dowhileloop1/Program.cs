using System;
using System.Net.Http.Headers;

namespace dowhileloop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While Loop: ");
            int i=1, n=5, product;
            do
            {
                product = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
            }while (i <= 10);
            Console.ReadKey();
            
        }
    }
}
