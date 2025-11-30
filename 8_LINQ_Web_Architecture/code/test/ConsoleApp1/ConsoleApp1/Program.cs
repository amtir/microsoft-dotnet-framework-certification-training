using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            var posNums = from n in nums
                          where n > 0
                          select n;
            int len = posNums.Count();
            Console.WriteLine(len);
            Console.ReadLine();

        }
    }
}
