namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StudentsAndWorkers
    {
        static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student ("Sasho", "Roman", 9 ),
                new Student ("Rumen", "Enchev", 2 ),
                new Student ("Valio", "Toploto", 11 ),
                new Student ("Dilyan", "Kostov", 11 ),
                new Student ("Yordan", "Petrov", 10 ),
                new Student ("Ivaylo", "Ivanov", 7 ),
                new Student ("Ivan", "Berov", 10 ),
                new Student ("Stefan", "Soyanov", 7 ),
                new Student ("Filip", "Kirkorov", 9 ),
                new Student ("Hristina", "Yakimova", 8 )
            };
            var sortedStudents = listOfStudents.OrderBy(stud => stud.Grade);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
