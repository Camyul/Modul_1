namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student : Human
    {
        private int grade;      //Field

        public Student(string first, string last, int grade) : base(first, last)    //Constructor
        {
            this.grade = grade;
        }

        public int Grade                //Property
        {
            get { return this.grade; }
            set
            {
                if (value <= 0 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("Grade can't be negativ or bigger of 13");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return String.Format("First Name: {0}\tLast Name: {1}\tGrade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
