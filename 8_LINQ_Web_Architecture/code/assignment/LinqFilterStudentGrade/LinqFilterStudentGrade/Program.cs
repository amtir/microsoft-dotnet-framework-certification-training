using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFilterStudentGrade
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int GradePoint { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "John",   Grade = 3, GradePoint = 850 },
                new Student { Id = 2, Name = "Emily",  Grade = 2, GradePoint = 760 },
                new Student { Id = 3, Name = "Harris", Grade = 1, GradePoint = 900 },
                new Student { Id = 4, Name = "Taylor", Grade = 1, GradePoint = 900 },
                new Student { Id = 5, Name = "Chris",  Grade = 3, GradePoint = 780 }
            };

            Console.Write("Which maximum grade point (1st, 2nd, 3rd, ...) you want to find : ");
            int userGrade = int.Parse(Console.ReadLine());

            var result = from s in students
                         where s.Grade == userGrade
                         select s;

            Console.WriteLine();
            foreach (var s in result)
            {
                Console.WriteLine($"Id : {s.Id},  Name : {s.Name},  achieved Grade Point : {s.GradePoint}");
            }

            Console.ReadLine();
        }
    }
}
