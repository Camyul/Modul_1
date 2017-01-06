namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ClassOfStudents
    {
        private int year;
        private char identifier;  //Fields

        public ClassOfStudents(int year, char ident) //Constructor
        {
            this.Year = year;
            this.Identifier = ident;
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            private set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("year can't be negativ or biggest of 13");
                }
                this.year = value;
            }
        }
        public char Identifier
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

        public override string ToString()  //Override ToString()
        {
            return String.Format("I am a class: {0}-{1}\n", this.Year, this.Identifier);
        }
    }
}
