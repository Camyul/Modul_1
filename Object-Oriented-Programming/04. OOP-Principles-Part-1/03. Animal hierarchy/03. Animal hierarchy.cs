namespace Animal_hierarchy
{
    using System;
    using System.Threading;
    class AnimalHierarchy
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


            Frog[] zooFrogs = new Frog[]
            {
                new Frog("Kermit", Gender.Male, 29),
                new Frog("Bobo", Gender.Male, 4),
                new Frog("Fara", Gender.Female, 6)
            };

            Dog[] zooDogs = new Dog[]
            {
                new Dog("Lassie", Gender.Female, 14),
                new Dog("Sharo", Gender.Male, 8),
                new Dog("Jessie", Gender.Female, 5)
            };

            Cat[] zooCats = new Cat[]
            {
                new Cat("Pissana", Gender.Female, 7.5),
                new Tomcat("Mrucho", Gender.Male, 8.4),
                new Kitten("Suzie", Gender.Female, 3)
            };

            Console.WriteLine("Average age of Cats is: {0:F2}",Animals.AverageAge(zooCats));
            Console.WriteLine("Average age of Frogs is: {0:F2}",Animals.AverageAge(zooFrogs));
            Console.WriteLine("Average age of Dogs is: {0:F2}",Animals.AverageAge(zooDogs));
        }
    }
}
