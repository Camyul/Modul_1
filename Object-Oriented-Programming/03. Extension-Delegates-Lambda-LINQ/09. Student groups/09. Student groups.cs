using System;
namespace Student_groups
{
    using Students;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class StudentGroups
    {
        static void Main()
        {
            //Create list of Students
            List<Student> listOfStudent = new List<Student>();   //Create List Of Student
            listOfStudent.Add(new Student("Ivan", "Penev", "0220114565", "02501560", "test1@abv.bg", 1)); //Add Student
            listOfStudent.Add(new Student("Genka", "Veleva", "0120126954", "0878945225", "test2@abv.bg", 2));
            listOfStudent.Add(new Student("Mitko", "Zanev", "1220073245", "056201205", "test3@abv.bg", 2));
            listOfStudent.Add(new Student("Petar", "Lalev", "0420126565", "02444555", "test4@abv.bg", 1));
            listOfStudent.Add(new Student("Maria", "Dobreva", "0120014532", "0887256321", "test5@abv.bg", 2));
            listOfStudent.Add(new Student("Tanya", "Koleva", "0720102235", "064205322", "test6@abv.bg", 1));
            listOfStudent.Add(new Student("Tanya", "Toteva", "0420158741", "0877212001", "test7@abv.bg", 2));
            listOfStudent.Add(new Student("Zoran", "Chernev", "0820063598", "02301888", "test8@abv.bg", 1));
            listOfStudent.Add(new Student("Sindy", "Mileva", "0920082182", "032547124", "test9@abv.bg", 2));
            //Add List of Marks for every student with loop and random generator
            Random rnd = new Random();
            foreach (var st in listOfStudent)
            {
                for (int i = 0; i < 3; i++)
                {
                    st.AddMark(rnd.Next(2, 7));
                }

            }

            Console.WriteLine();

            //Select only the students that are from group number 2.

            //Use LINQ query. Order the students by FirstName.
        }
    }
}
