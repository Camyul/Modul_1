

namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Person
    {
        private string firstName;
        private string lastName;  //Fields

        public Person(string first, string last)  //Constructor
        {

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
    }
}
