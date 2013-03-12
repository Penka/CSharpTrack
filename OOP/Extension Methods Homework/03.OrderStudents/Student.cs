namespace _03.OrderStudents
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}