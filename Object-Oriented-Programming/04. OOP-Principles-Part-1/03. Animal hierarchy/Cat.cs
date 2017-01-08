namespace Animal_hierarchy
{
    using System;
    public class Cat : Animals, ISound
    {
        public Cat(string name, Gender gender, double age) : base(name, gender, age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Meww.....Meww");
        }
    }
}
