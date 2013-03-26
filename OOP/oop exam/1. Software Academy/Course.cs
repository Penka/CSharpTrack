using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public List<string> topics { get; set; }

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            topics = new List<string>();
        }
        public Course(string name)
            : this(name, null)
        {
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}: Name={1};", this.GetType().Name, this.Name);
            if (this.Teacher != null)
            {
                result.AppendFormat(" Teacher={0};", this.Teacher);
            }
            if (this.topics.Count != 0)
            {
                result.AppendFormat(" Topics=[");
                for (int i = 0; i < topics.Count - 1; i++)
                {
                    result.AppendFormat("{0}, ", topics[i]);
                }
                result.AppendFormat("{0}];", topics[topics.Count - 1]);
            }
            var course = this as OffsiteCourse;
            if (course != null)
            {
                result.AppendFormat(" Town={0}", course.Town);
            }
            else
            {
                var newCourse = this as LocalCourse;
                result.AppendFormat(" Lab={0}", newCourse.Lab);

            }
            return result.ToString();
        }
    }
}