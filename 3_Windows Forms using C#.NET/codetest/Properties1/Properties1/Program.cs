using System;

namespace Properties1
{

    public class Employee
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value + " welcome to the edureka session"; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Properties ...");
            Employee e = new Employee();
            e.Name = "Jeni";
            Console.WriteLine("Employee Name : " + e.Name);
            Console.Read();
        }
    }
}
