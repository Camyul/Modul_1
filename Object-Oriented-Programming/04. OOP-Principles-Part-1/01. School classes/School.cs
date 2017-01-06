namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class School 
    {
        private List<ClassOfStudents> schoolClasses = new List<ClassOfStudents>(); //Field

        

        public List<ClassOfStudents> SchoolClasses  //Property
        {
            get
            {
                return this.schoolClasses;
            }
            private set
            {
                this.schoolClasses = value;
            }
        }

        public void AddClass (ClassOfStudents newClass) //For IComment
        {
            this.schoolClasses.Add(newClass);
        }

        public override string ToString()  //Override ToString()
        {
            return String.Join("\n", this.SchoolClasses);
        }
    }
}
