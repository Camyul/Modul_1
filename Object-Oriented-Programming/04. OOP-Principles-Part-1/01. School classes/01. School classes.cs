namespace School_classes
{
    using System;
    using System.Collections.Generic;
    class SchoolSystem
    {
        static void Main()
        {
            School lubenKaravelov = new School();  //Create new school
            var listOfDisciplines = new List<Disciplines>  //Create List Of Disciplines
            {
                new Disciplines(DisciplineList.Boilogy, 125, 150),
                new Disciplines(DisciplineList.Chemistry, 90, 165),
                new Disciplines(DisciplineList.Mathematic, 170, 170)
            };
            var anatherListOfDisciplines = new List<Disciplines>  //Create List Of Disciplines
            {
                new Disciplines(DisciplineList.History, 105, 25),
                new Disciplines(DisciplineList.English, 119, 135),
                new Disciplines(DisciplineList.Programming, 100, 175)
            };
            var teachersList = new List<Teacher>        //Create List Of Teachers
            {
                new Teacher("Peter","Siderov",listOfDisciplines),
                new Teacher("Kamen", "Nedelev", anatherListOfDisciplines)
            };
            var anatherTeachersList = new List<Teacher>             //Create List Of Teachers
            {
                new Teacher("Ivan","Penev",anatherListOfDisciplines),
                new Teacher("Milen", "Ignatov", listOfDisciplines)
            };

            var studentList = new List<Student>     //Create List Of Student
            {
                new Student("Pesho", "Peshov", 2233),      
                new Student("Gosho", "Goshov", 3344)      
            };
            var anatherStudentList = new List<Student>     //Create List Of Student
            {
                new Student("Toshko", "Todorov", 9876),
                new Student("Petyr", "Milev", 1234)
            };
            ClassOfStudents desetiB = new ClassOfStudents(10, 'B', teachersList, studentList);      //Create new Class
            ClassOfStudents edinaistiG = new ClassOfStudents(11, 'G', anatherTeachersList, anatherStudentList);  //Create new Class
            
            lubenKaravelov.AddClass(desetiB);       //Add Class to School
            lubenKaravelov.AddClass(edinaistiG);    //Add Class to School

            studentList[1].AddComent("Gosho e Jelezen!");       // Add Commentar for student
            desetiB.AddComent("Proba, 1, 2, proba, proba...");  // Add Commentar for class
            Console.WriteLine(lubenKaravelov);                  //Print All Infornation, about School

            //Console.WriteLine(String.Join("\n", teachersList));
        }
    }
}
