namespace Animal_hierarchy
{
    using System;
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, Gender gender, double age) : base(name, gender, age)
        {
            if (gender != Gender.Female)
            {
                throw new ArgumentOutOfRangeException("Gender must be: Female");
            }
        }
    }
}
