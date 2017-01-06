namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Student : Person, IComment
    {
        private long studentID;     //Field
        private List<string> textBlock = new List<string>(); //For IComment

        public Student(string first, string last, long num) : base(first, last) //Constructor
        {
            this.StudentID = num;
        }

        public long StudentID  //Property
        {
            get { return this.studentID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Student ID must be bigger of 0");
                }
                this.studentID = value;
            }
        }

        public void AddComent(string comment)  //For IComment
        {
            textBlock.Add(comment);
        }

        public override string ToString()  //Override method ToString()
        {
            return String.Format("{0} {1} StudentID: {2} Commentar for Student: {3}\n", this.FirstName, this.LastName, this.StudentID, string.Join("\n", textBlock));
        }
    }
}
