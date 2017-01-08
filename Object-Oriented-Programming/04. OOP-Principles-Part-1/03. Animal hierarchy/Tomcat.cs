namespace Animal_hierarchy
{
    using System;
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, Gender gender, double age) : base(name, gender, age)
        {
            if (gender != Gender.Male)
            {
                throw new ArgumentOutOfRangeException("Gender must be: Male");
            }
        }
    }
}
