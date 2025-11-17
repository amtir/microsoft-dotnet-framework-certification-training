using System;

namespace Question2
{

    // Base class
    class Person
    {
        public string Name { get; set; }
    }

    // Derived class
    class Employee : Person
    {
        private static int _empCounter = 100; // auto-increment employee ID
        public int EmployeeId { get; private set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            EmployeeId = ++_empCounter;
            Name = name;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"{EmployeeId} {Name} {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Employee Name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter First Employee Salary: ");
            double salary1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Employee Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter Second Employee Salary: ");
            double salary2 = Convert.ToDouble(Console.ReadLine());

            // Create objects of Employee
            Employee emp1 = new Employee(name1, salary1);
            Employee emp2 = new Employee(name2, salary2);

            Console.WriteLine("Employee Details are:");
            emp1.Display();
            emp2.Display();

            Console.ReadLine();
        }
    }
}

