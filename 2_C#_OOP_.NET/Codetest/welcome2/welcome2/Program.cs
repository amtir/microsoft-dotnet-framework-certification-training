using System;

namespace welcome2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enmter the User Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to the training!");
            Console.Read();
        }   
    }
}
