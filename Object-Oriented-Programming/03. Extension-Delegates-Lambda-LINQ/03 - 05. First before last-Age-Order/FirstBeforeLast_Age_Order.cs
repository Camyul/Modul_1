

namespace First_before_last_Age_Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class FirstBeforeLast_Age_Order
    {
        static void Main()
        {
            List<Student> listOfStudent = new List<Student>();   //Create List Of Student
            listOfStudent.Add(new Student("Ivan", "Penev", 19)); //Add Student
            listOfStudent.Add(new Student("Genka", "Veleva", 27));
            listOfStudent.Add(new Student("Mitko", "Zanev", 39));
            listOfStudent.Add(new Student("Petar", "Lalev", 22));
            listOfStudent.Add(new Student("Maria", "Dobreva", 21));
            listOfStudent.Add(new Student("Tanya", "Koleva", 24));
            listOfStudent.Add(new Student("Tanya", "Toteva", 28));
            listOfStudent.Add(new Student("Zoran", "Chernev", 43));
            listOfStudent.Add(new Student("Sindy", "Mileva", 26));

            var filteredList = listOfStudent.FindAll(st => st.FirstName.CompareTo(st.LastName) < 0); //Task 3
            Console.WriteLine("Task 3 Sort by First Name before to Last Name:\n");
            Print(filteredList);

            var ageList = listOfStudent.FindAll(st => (st.Age >= 18) && (st.Age <= 24)); // Task 4
            Console.WriteLine("Task 4 Sort by age range (18-24):");
            PrintName(ageList);

            var orderedList = listOfStudent                                 // Task 5 by lambda
                                    .OrderByDescending(st => st.FirstName)
                                    .ThenByDescending(st => st.LastName);    
            Console.WriteLine("Task 5 Sort descending by First Name then Last Name using extencions methods:");
            Print(orderedList.ToList());

            Console.WriteLine("Task 5 Order by first name and last name descending LINQ ");      // Task 5 by LINQ
            var secondOrderedList =
                             from st in listOfStudent
                             orderby st.FirstName descending, st.LastName descending
                             select st;
            Print(secondOrderedList.ToList());
        }

        private static void Print(List<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("{0}\t{1}\t{2}", item.FirstName, item.LastName, item.Age);
            }
            Console.WriteLine();
        }
        private static void PrintName(List<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("{0}\t{1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();
        }
    }
}
