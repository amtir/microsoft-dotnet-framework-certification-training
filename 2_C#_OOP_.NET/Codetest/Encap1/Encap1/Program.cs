using System;

namespace Encap1
{
    class Student { 
        public string id { get; set; }
        public string mailid { get; set; }
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation ...");
            Student ob1 = new Student();
            ob1.id = "1001";
            ob1.mailid = "JohnJames@gmail.com";
            ob1.name = "James John";
            
            Console.WriteLine("Details : " + ob1.id + ", " + ob1.name + ", " + ob1.mailid);
        }
    }
}
