using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortByAge
{
    class SortByAge
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 12));
            students.Add(new Student("Peter", "Ivanov", 24));
            students.Add(new Student("Ivan", "Petrov", 20));
            students.Add(new Student("Peter", "Petrov", 10));
            students.Add(new Student("A", "B", 30));
            students.Add(new Student("B", "A", 22));

            var selection =
                from student in students
                where student.Age <= 24 && student.Age >= 18
                orderby student.Age
                select new Student(student.FirstName, student.LastName, student.Age);
                

            foreach (var item in selection)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Age);
            }
        }
    }
}
