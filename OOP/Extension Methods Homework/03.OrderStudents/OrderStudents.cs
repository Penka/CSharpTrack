using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OrderStudents
{
    class OrderStudents
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

            var linqSelection =
               from student in students
               where student.FirstName.CompareTo(student.LastName) < 0
               select new { FirstName = student.FirstName, LastName = student.LastName };

            foreach (var item in linqSelection)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
