namespace Animal_hierarchy
{
    using System;
    public class Frog : Animals, ISound
    {
        public Frog(string name, Gender gender, double age) : base(name, gender, age)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Croaaak.....Croaaak");
        }
    }
}
