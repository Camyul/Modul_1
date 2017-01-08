namespace Animal_hierarchy
{
    using System;
    public class Dog : Animals, ISound
    {
        public Dog(string name, Gender gender, double age) : base(name, gender, age) //Constructor
        {

        }

        public void Sound()
        {
            Console.WriteLine("Bauuu.......Bauuu");
        }
    }
}
