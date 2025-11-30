using System;
using System.Linq;

namespace SquareNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 9, 2, 8, 6, 5 };

            var result =
                from n in numbers
                let sq = n * n
                where sq > 20
                select new
                {
                    Number = n,
                    SqrNo = sq
                };

            foreach (var item in result)
            {
                Console.WriteLine($"{{ Number = {item.Number}, SqrNo = {item.SqrNo} }}");
            }

            Console.ReadLine();
        }
    }
}
