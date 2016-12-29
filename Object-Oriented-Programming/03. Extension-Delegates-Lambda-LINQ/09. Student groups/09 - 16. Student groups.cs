﻿namespace Student_groups
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
            listOfStudent.Add(new Student("Zoran", "Chernev", "0820063598", "02301888",   "test8@mail.bg",     1));
            listOfStudent.Add(new Student("Sindy", "Mileva",  "0920082182", "032547124",  "test9@abv.bg",      2));
            //Add List of Marks for every student with loop and random generator
            Random rnd = new Random();   
            foreach (var st in listOfStudent)       // Generate Random Marks
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
                               where Student.IndexOf(st.EMail, "abv.bg") > 0
                               orderby st.FirstName
                               select st;
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Print all students that have email in abv.bg - Task 11\n");
            Print(abvEmailStud.ToList());

            //Extract students by phone  - Task 12
            var sortByPhone = from st in listOfStudent
                              where Student.IndexOf(st.Telefon, "2") == 1
                              orderby st.FirstName
                              select st;
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Print students with phone from Sofia  - Task 12\n");
            Print(sortByPhone.ToList());

            //Select all students that have at least one mark Excellent (6) into a new anonymous class  - Task 13
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Select all students that have at least one mark Excellent(6). Use LINQ -Task 13\n");
            var anonymClassStudent = from st in listOfStudent
                                     where st.Mark.Contains(6)
                                     select new
                                     {
                                         FullName = st.FirstName + " " + st.LastName,
                                         Marks = st.Mark
                                     };
            foreach (var st in anonymClassStudent)
            {
                Console.WriteLine(st.FullName);
                Console.WriteLine(String.Join(" ", st.Marks));
            }

            //Write down a similar program that extracts the students with exactly two marks "2"
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Write down a similar program that extracts the students with exactly two marks \"2\" -Task 14\n");
           
            List<Student> stTwoTwo = listOfStudent.SearchTwoMarksTwo();
            if (stTwoTwo.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Marks was generated randomly, need exactly two Marks 2!");
                Console.WriteLine("Please start the program again (CTRL + F5), if needed 4-5 times. \n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            foreach (var st in stTwoTwo)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
                Console.WriteLine(String.Join(" ", st.Mark));
            }
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