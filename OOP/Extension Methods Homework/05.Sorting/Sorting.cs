using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov"));
            students.Add(new Student("Peter", "Ivanov"));
            students.Add(new Student("Ivan", "Petrov"));
            students.Add(new Student("Peter", "Petrov"));
            students.Add(new Student("A", "B"));
            students.Add(new Student("B", "A"));

            //OrderBy and ThenBy
            Console.WriteLine("Sorted using OrderBy and ThenBy");
            var sorted = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var item in sorted)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //using LINQ

            Console.WriteLine("Sorted with LINQ");
            var sortedWithLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select new Student(student.FirstName, student.LastName);
            foreach (Student student in sortedWithLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
