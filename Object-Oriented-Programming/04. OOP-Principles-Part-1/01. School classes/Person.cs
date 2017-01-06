namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Person
    {
        private string firstName;
        private string lastName;  //Fields

        public Person(string first, string last)  //Constructor
        {
            this.FirstName = first;
            this.LastName = last;
        }


        public string FirstName         //Property
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be null or empti");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be null or empti");
                }
                this.lastName = value;
            }
        }

        //public override string ToString()  //Override method ToString()
        //{
        //    return String.Format("{0} {1}", this.FirstName, this.LastName);
        //}
    }
}
