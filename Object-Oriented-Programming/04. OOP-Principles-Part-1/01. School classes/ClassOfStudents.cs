namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ClassOfStudents : IComment
    {
        private int year;
        private char identifier;                            //Fields
        private List<string> textBlock = new List<string>(); //For Icomment
        private List<Teacher> teachersList = new List<Teacher>();
        private List<Student> studentList = new List<Student>();

        public ClassOfStudents(int year, char ident, List<Teacher> teachers, List<Student> students) //Constructor
        {
            this.Year = year;
            this.Identifier = ident;
            this.TeachersList = teachers;
            this.StudentList = students;
        }

        public List<Student> StudentList //Property
        {
            get { return this.studentList; }
            private set
            {
                this.studentList = value;
            }
        }
        public List<Teacher> TeachersList  //Property
        {
            get { return this.teachersList; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("Need at least one teacher");
                }
                this.teachersList = value;
            }
        }

        public int Year         //Property
        {
            get
            {
                return this.year;
            }
            private set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("year can't be negativ or bigger of 13");
                }
                this.year = value;
            }
        }
        public char Identifier          //Property
        {
            get
            {
                return this.identifier;
            }
            private set
            {
                if ((int)(value) < 65 || (int)value > 90)
                {
                    throw new ArgumentOutOfRangeException("Identifier must be with Capital Letter");
                }
                this.identifier = value;
            }
        }

        

        public void AddComent(string comment) //Icomment
        {
            textBlock.Add(comment);
        }

        public override string ToString()  //Override ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("\nI am a class: {0}-{1}\nTeachers:\n\n", this.Year, this.Identifier));
            result.Append(String.Join("", TeachersList));
            result.Append(String.Format("\nStudents:\n"));
            result.Append(String.Join("", studentList));
            result.Append("Commentars for Class: " + String.Join("\n", textBlock));
            
            return result.ToString();
        }
    }
}
