namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class SchoolSystem
    {
        static void Main()
        {
            School lubenKaravelov = new School();
            ClassOfStudents desetiB = new ClassOfStudents(10, 'B');
            ClassOfStudents edinaistiG = new ClassOfStudents(11, 'G');
            Student pesho = new Student("Pesho", "Peshov", 2233);
            Student gosho = new Student("Gosho", "Goshov", 3344);
            lubenKaravelov.AddClass(desetiB);
            lubenKaravelov.AddClass(edinaistiG);
            Console.WriteLine(lubenKaravelov);
            Console.WriteLine(gosho);
        }
    }
}
