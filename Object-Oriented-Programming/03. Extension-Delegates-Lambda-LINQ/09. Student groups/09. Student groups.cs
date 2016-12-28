namespace Student_groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ClassLibrary;
    using System.Text;
    using System.Threading.Tasks;
    public class StudentGroups
    {
        static void Main()
        {
            //Create list of Students
            List<Student> listOfStudent = new List<Student>();   //Create List Of Student
            listOfStudent.Add(new Student("Ivan",  "Penev",   "0220114565", "02501560",   "test1@abv.bg",      1)); //Add Student
            listOfStudent.Add(new Student("Genka", "Veleva",  "0120126954", "0878945225", "test2@mail.bg",     2));
            listOfStudent.Add(new Student("Mitko", "Zanev",   "1220073245", "056201205",  "test3@abv.bg",      2));
            listOfStudent.Add(new Student("Petar", "Lalev",   "0420126565", "02444555",   "test4@gmail.com",   1));
            listOfStudent.Add(new Student("Maria", "Dobreva", "0120014532", "0887256321", "test5@abv.bg",      2));
            listOfStudent.Add(new Student("Tanya", "Koleva",  "0720102235", "064205322",  "test6@mail.ru",     1));
            listOfStudent.Add(new Student("Tanya", "Toteva",  "0420158741", "0877212001", "test7@yahoo.com",   2));
            listOfStudent.Add(new Student("Zoran", "Chernev", "0820063598", "02301888",   "test8@mail.bg", 1));
            listOfStudent.Add(new Student("Sindy", "Mileva",  "0920082182", "032547124",  "test9@abv.bg",      2));
            //Add List of Marks for every student with loop and random generator
            Random rnd = new Random();
            foreach (var st in listOfStudent)
            {
                for (int i = 0; i < 3; i++)
                {
                    st.AddMark(rnd.Next(2, 7));
                }

            }
            //Select only the students that are from group number 2.  - Task 9

            Console.WriteLine("Print only the students that are from group number 2. - Task 9\n");
            List<Student> studentsOfGroupTwo = listOfStudent.FindAll(st => st.GroupNum == 2);
            Print(studentsOfGroupTwo);

            //Use LINQ query. Order the students by FirstName.   - Task 9
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Use LINQ query. Order the students by FirstName.  - Task 9\n");
            var sortedByFN = from st in listOfStudent
                             orderby st.FirstName
                             select st;
            Print(sortedByFN.ToList());

            //Student groups extensions - Task 10
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Print students by FirstName with groups extensions - Task 10\n");
            List<Student> sortedWithExtension = listOfStudent.SortByFirstName();
            Print(sortedWithExtension);


            //Extract all students that have email in abv.bg - Task 11
            var abvEmailStud = from st in listOfStudent
                               where Student.IndexOf(st.EMail) > 0
                               orderby st.FirstName
                               select st;
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Print all students that have email in abv.bg - Task 11\n");
            Print(abvEmailStud.ToList());

        }

        private static void Print(List<Student> list)
        {
            foreach (var st in list)
            {
                Console.WriteLine(st.ToString());
            }
        }
    }
}
