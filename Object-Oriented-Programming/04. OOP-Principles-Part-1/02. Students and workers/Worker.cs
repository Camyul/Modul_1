namespace Students_and_workers
{
    using System;
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;        //Fields

        public Worker(string first, string last, int weekSalary, int hoursPerDay) : base(first, last) //Constructor
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = hoursPerDay;
        }

        public int WeekSalary               //Property
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0 || value > 300)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negativ or bigger of the Boss Salary");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay               //Property
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Hours cannot be negativ or bigger from 12");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()                //Method - calculated money earned per hour
        {
            return ((WeekSalary / 5.0) / WorkHoursPerDay);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}\tPerHour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
