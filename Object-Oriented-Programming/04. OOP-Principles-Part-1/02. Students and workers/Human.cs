namespace Students_and_workers
{
    using System;
    public abstract class Human
    {
        private string firstName;
        private string lastName;        //Fields

        public Human(string first, string last)     //Constructor
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName     //Property
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be least 1 letter");
                }
                this.firstName = value;
            }
        }
        public string LastName           //Property
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be least 1 letter");
                }
                this.lastName = value;
            }
        }
    }
}
