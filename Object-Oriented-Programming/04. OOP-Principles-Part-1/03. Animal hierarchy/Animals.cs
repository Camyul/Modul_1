namespace Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Animals 
    {
        private double age;

        public Animals(string name, Gender gender, double age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age; 
        }

        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public double Age {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or zero!");
                }
                this.age = value;
            }
        }

       public static double AverageAge(Animals[] animalArr)
        {
            //double averageAge = 0;            //With Foreach loop
            //foreach (var animal in animalArr)
            //{
            //    averageAge += animal.Age;
            //}

            //return averageAge / animalArr.Length;


            IEnumerable<double> averageAge = from animal in animalArr   //With LINQ
                                //where animal.Age > 0
                                select animal.Age;

            return averageAge.Average();
        }
    }
}
