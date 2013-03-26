using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        public string Name { get; set; }
        public List<ICourse> courses { get; set; }

        public Teacher(string name)
        {
            this.courses = new List<ICourse>();
            this.Name = name;
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Teacher: Name={0};", this.Name);
            if (this.courses.Count > 0)
            {
                //Console.WriteLine();
                //Console.WriteLine("countttt               " + this.courses.Count);
                //Console.WriteLine();
                result.Append(" Courses=[");
                for (int i = 0; i < this.courses.Count - 1; i++)
                {
                    result.AppendFormat("{0}, ", this.courses[i].Name);
                }
                result.AppendFormat("{0}]", this.courses[courses.Count - 1].Name);
            }
            return result.ToString();
        }
    }
}