using System;

namespace Question1
{
    // Class Author
    class Author
    {
        public string Name { get; set; }
        public Author(string name)
        {
            Name = name;
        }
    }

    // Class Work
    class Work
    {
        public string Title { get; set; }
        public Work(string title)
        {
            Title = title;
        }
    }

    // Driver class (as per requirement)
    class Driver
    {
        static void Main(string[] args)
        {
            // Input Author Name
            Console.Write("Enter Author Name: ");
            string authorName = Console.ReadLine();

            Author a1 = new Author(authorName);
            Work w1 = new Work("book1");

            Console.WriteLine("Comparing Author name from Author class__________________");
            Console.WriteLine($"Is {a1.Name} Author? : {a1 is Author}");

            Console.WriteLine("Comparing book1 from Author class__________________");
            Console.WriteLine($"Is {w1.Title} belongs to class Author? : {w1 is Author}");

            Console.WriteLine("Taking the author name as null__________________");
            Author a2 = null;
            Console.WriteLine($"Is {authorName} Author? : {a2 is Author}");

            Console.ReadLine();
        }
    }
}
