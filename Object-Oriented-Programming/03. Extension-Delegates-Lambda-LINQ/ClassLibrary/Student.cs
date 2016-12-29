namespace ClassLibrary
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
        private string facNum;
        private string telefon;
        private string eMail;
        private int groupNumber;
        private List<int> mark = new List<int>();


        public Student(string firstName, string lastName, string facNum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNum = facNum;
        }

        public Student(string firstName, string lastName, string facNum, string tel, string email, int groupNum) : this(firstName, lastName, facNum)
        {
            this.Telefon = tel;
            this.EMail = email;
            this.GroupNum = groupNum;

        }
        public List<int> Mark {
            get {return this.mark; }
            private set {this.mark = value; }
        }  // List of Marks
        public int GroupNum {
            get { return this.groupNumber; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Group Number must by from 1 to 9");
                }
                this.groupNumber = value;
            }
        }
        public string EMail {
            get { return this.eMail; }
            set
            {
                if (value.IndexOf('@') == -1)
                {
                    throw new ArgumentException("Invalid e-mail address");
                }
                this.eMail = value;
            }
        }
        public string Telefon {
            get {return this.telefon; }
            set
            {
                if (value.Length < 8 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid number");
                }
                this.telefon = value;
            }
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
        public string FacNum
        {
            get { return this.facNum; }
            set
            {
                if (value.Length < 8 && value.Length > 8)
                {
                    throw new ArgumentException("Student f.Number must be exactly 8 digits");
                }
                this.facNum = value;
            }
        }

        public void AddMark(int mark)
        {
            this.Mark.Add(mark);
        }

        public static int IndexOf(string strStudent, string param)
        {
            int abvStudent = -1;
            if (strStudent.IndexOf(param) >= 0)
            {
                abvStudent = strStudent.IndexOf(param);
            }
         
                return abvStudent;
            
        }

        
        public override string ToString()
        {
            StringBuilder stud = new StringBuilder();
            stud.Append(this.FirstName);
            stud.Append("\t");
            stud.Append(this.LastName);
            stud.Append("\t");
            stud.Append(this.FacNum);
            stud.Append("\t");
            stud.Append(this.Telefon);
            stud.Append("\t");
            stud.Append(this.EMail);
            stud.Append("\t");
            stud.Append(this.GroupNum);

            return stud.ToString();
        }
    }
}
