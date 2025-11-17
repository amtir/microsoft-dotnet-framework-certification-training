using System;

namespace ForEachLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Each Loop: ");
            string[] nams = { "slade", "shado", "laure", "sarah", "diggle" };
            foreach (string s in nams) {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
