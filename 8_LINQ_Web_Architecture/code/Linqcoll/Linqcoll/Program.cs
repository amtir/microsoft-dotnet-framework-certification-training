using System;
using System.Collections.Generic;
using System.Linq;


namespace Linqcoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            
            // Linq Query 
            IEnumerable<int> numbers = from n in ls
                                       where n > 3
                                       select n;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
