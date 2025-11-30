using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> languages = new List<string>
            {
                "Indonesian", "Korean", "Japanese", "English", "German", "Hindi"
            };

            var sortedList = from lang in languages
                             orderby lang
                             select lang;

            // Print type of sortedList
            Console.WriteLine("Type of sortedList: " + sortedList.GetType());

            Console.WriteLine("Sorted Strings are:");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
