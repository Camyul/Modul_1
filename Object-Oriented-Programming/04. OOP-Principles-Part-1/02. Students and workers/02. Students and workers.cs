namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentsAndWorkers
    {
        static void Main()
        {
            var listOfStudents = new List<Student>      //Create List of Students
            {
                new Student ("Sasho", "Roman", 9 ),
                new Student ("Rumen", "Enchev", 2 ),
                new Student ("Valio", "Toploto", 11 ),
                new Student ("Dilyan", "Kostov", 11 ),
                new Student ("Yordan", "Petrov", 10 ),
                new Student ("Ivaylo", "Ivanov", 7 ),
                new Student ("Ivan", "Berov", 10 ),
                new Student ("Stefan", "Soyanov", 7 ),
                new Student ("Filip", "Kirov", 9 ),
                new Student ("Tina", "Yankova", 8 )
            };
            var sortedStudents = listOfStudents.OrderBy(stud => stud.Grade);    //Sort List of Students
            Console.WriteLine("List of 10 students and sort them by grade in ascending order\n");
            foreach (var student in sortedStudents)     //Print List of Students
            {
                Console.WriteLine(student);
            }

            Console.Write(new string('-',80));
            Console.WriteLine("List of 10 workers and sort them by money per hour in descending order.\n");
            var listOfWorkers = new List<Worker>
            {
                new Worker("Dian", "Vacov", 200, 8),
                new Worker("Evlogi", "Hristov", 260, 7),
                new Worker("Todor", "Totev", 299, 12),
                new Worker("Nedko", "Vacov", 222, 8),
                new Worker("Nedelko", "Vacov", 234, 5),
                new Worker("Veliko", "Nenov", 266, 11),
                new Worker("Petyr", "Moskov", 288, 10),
                new Worker("Stancho", "Stanev", 188, 4),
                new Worker("Boncho", "Genchev", 156, 4),
                new Worker("Ivan", "Goranov", 285, 9)
            };
            var sortedWorkers = listOfWorkers.OrderByDescending(worker => worker.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.Write(new string('-', 80));
            Console.WriteLine("Merge the lists and sort them by first name and last name.\n");
            var megredList = listOfStudents.Concat<Human>(listOfWorkers)
                                                        .OrderBy(h => h.FirstName)
                                                        .ThenBy(h => h.LastName);
            foreach (var human in megredList)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
