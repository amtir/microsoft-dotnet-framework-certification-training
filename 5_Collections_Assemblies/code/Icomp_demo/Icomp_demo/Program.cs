using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Icomp_demo
{

    class Employee : IComparable <Employee>
    {
        public int salary {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public int CompareTo(Employee other)
        {
            if(this.salary == other.salary) 
                return this.name.CompareTo(other.name);   
            
            return other.salary.CompareTo(this.salary);
        }

        public override string ToString()
        {
            return this.salary.ToString() + ", " + this.name;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Employee> l = new List<Employee>();
            l.Add(new Employee() { name = "Steve", salary = 10000 } );
            l.Add(new Employee() { name = "John", salary = 5000 });
            l.Add(new Employee() { name = "Sam", salary = 50000 });
            l.Add(new Employee() { name = "Smith", salary = 8000 });
            l.Sort();

            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
