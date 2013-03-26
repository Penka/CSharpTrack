using System;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public class CourseFactory : ICourseFactory
    {
        List<ITeacher> teachers;
        List<ICourse> courses;
        public CourseFactory()
        {
            this.teachers = new List<ITeacher>();
            this.courses = new List<ICourse>();
        }
        public ITeacher CreateTeacher(string name)
        {
            Teacher teacher = new Teacher(name);
            this.teachers.Add(teacher);
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse course = new LocalCourse(name, teacher, lab);
            this.courses.Add(course);
            return course;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse course = new OffsiteCourse(name, teacher, town);
            this.courses.Add(course);
            return course;
        }
    }
}