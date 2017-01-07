namespace Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Animals
    {
        private string name;
        private Gender gender;
        private int age;

        public Animals(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age; 
        }

        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public int Age {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                }
                this.age = value;
            }
        }
    }
}
