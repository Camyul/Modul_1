namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Teacher : Person, IComment
    {
        private List<string> textBlock = new List<string>(); //For IComment

        public Teacher(string first, string last) : base(first, last) //Constructor
        {

        }

        public void AddComent(string comment) //For IComment
        {
            textBlock.Add(comment);
        }

        public override string ToString()  //Override method ToString()
        {
            return String.Format("{0} {1} {2}\n{3}", this.FirstName, this.LastName, this.StudentID, string.Join("\n", textBlock));
        }
    }
}
