using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int? age;

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public Person(string name, int? age)
        {
            this.Age = age;
            this.Name = name;
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Person's name is {0}. ", this.Name);
            if (this.Age == null)
            {
                sb.Append("Person's age is unspecified. ");
            }
            else
            {
                sb.AppendFormat("Person's age is {0}. ", this.Age);
            }
            return sb.ToString();
        }
    }
}
