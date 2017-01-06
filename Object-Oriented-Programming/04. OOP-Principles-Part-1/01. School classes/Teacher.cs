namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Teacher : Person, IComment
    {
        private List<Disciplines> teacherDisciplines = new List<Disciplines>();
        private List<string> textBlock = new List<string>(); //For IComment

        public Teacher(string first, string last, List<Disciplines> teacDiscip) : base(first, last) //Constructor
        {
            this.TeacherDisciplines = teacDiscip;
        }

        public List<Disciplines> TeacherDisciplines
        {
            get { return this.teacherDisciplines; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("Teacher need a Disciplines");
                }
                this.teacherDisciplines = value;
            }
        }

        public void AddComent(string comment) //For IComment
        {
            textBlock.Add(comment);
        }

        public override string ToString()  //Override method ToString()
        {
            return String.Format("{0} {1}\n{2}\n{3}\n", this.FirstName, this.LastName, string.Join("\n", this.teacherDisciplines), string.Join("\n", this.textBlock));
        }
    }
}
