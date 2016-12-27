namespace First_before_last_Age_Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student()
        {

        }
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("The name must be at least one symbol long");
                }
                this.firstName = value;

            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("The name must be at least one symbol long");
                }
                this.lastName = value;

            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 && value > 150)
                {
                    throw new ArgumentException("Student age must be between 0 and 150");
                }
                this.age = value;
            }
        }

    }
}
