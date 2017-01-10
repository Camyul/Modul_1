namespace Range_Exceptions
{
    using System;
    public class Human
    {
        private int age;
        private DateTime birthDay;

        public Human(int age)
        {
            this.Age = age;
        }
        public Human(DateTime birthDay)
        {
            this.BirthDay = birthDay;
        }

        public DateTime BirthDay
        {
            get { return this.birthDay; }
            private set
            {
                DateTime min = DateTime.ParseExact("01-01-1980", "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime max = DateTime.ParseExact("31-12-2013", "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (value < min || value > max)
                {
                    throw new InvalidRangeException<DateTime>("Human is too old or too young", min, max);
                }
                this.birthDay = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number of Age", 0, 100);
                }
                this.age = value;
            }
        }
    }
}
