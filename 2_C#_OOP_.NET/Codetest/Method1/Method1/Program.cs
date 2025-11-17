using System;

namespace Method1
{

    class Employee
    {
        public int Eid;
        public string Ename;
        public double salary;

        public void set()
        {
            Console.WriteLine("Enter the Employee ID: ");
            Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Neme: ");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void get()
        {
            Console.WriteLine("The Employee Id is : " + Eid);
            Console.WriteLine("The Employee Name is : " + Ename);
            Console.WriteLine("The Employee Salary is : " + salary);
        }
        }

        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function :");

            Employee e = new Employee();
            e.set();
            e.get();
            Console.ReadKey();
        }
    }
}
