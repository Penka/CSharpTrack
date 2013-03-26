using System;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;
        public string Lab
        {
            get
            { return this.lab; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.lab = value;
            }
        }

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }
    }
}