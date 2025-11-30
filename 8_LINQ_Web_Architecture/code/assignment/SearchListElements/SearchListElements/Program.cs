using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchListElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string>();
            Students.Add("Amrit");
            Students.Add("Sumit");
            Students.Add("Atul");
            Students.Add("Shaurya");
            Students.Add("Amogh");

            // Classic LINQ syntax
            var result =
                from s in Students
                where s.StartsWith("A", StringComparison.OrdinalIgnoreCase)
                select s;

            Console.WriteLine("Student Names start with 'A':");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
