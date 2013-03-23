using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student : ICloneable, IComparable<Student>
    {
        /* 
         * Override the standard methods, inherited by  
         * System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
*/
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string phone;
        private string email;
        private int course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string ssn, 
            string permanentAddress, string phone, string email, int course, University university, 
            Faculty faculty, Speciality speciality)
        {
            this.Faculty = faculty;
            this.University = university;
            this.Speciality = speciality;
            this.Course = course;
            this.Email = email;
            this.Phone = phone;
            this.PermanentAddress = permanentAddress;
            this.SSN = ssn;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.FirstName = firstName;
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Speciality Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                this.speciality = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.course = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                this.permanentAddress = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student student = obj as Student;
            if (student.FirstName != this.FirstName || student.LastName != this.LastName ||
                student.MiddleName != this.MiddleName || student.SSN != this.SSN)
            {
                return false;
            }
            return true;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ course;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student's name is : {0} {1} {2}. ", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendFormat("Student's SSN is : {0}. ", this.SSN);
            sb.AppendFormat("Student's phone is : {0}. ", this.Phone);
            sb.AppendFormat("Student's email is : {0}. ", this.PermanentAddress);
            sb.AppendFormat("Student is in : {0} course, speciality {1}, faculty {2}, university {3}. ",
                this.Course, this.Speciality, this.Faculty, this.University);
            return sb.ToString();
        }

        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            //Using Equals() - both are equals if they have same name and ssn
            return a.Equals(b);
        }
        
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.Phone, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            return 0;
        }

    }
}
