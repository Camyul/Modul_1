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
            School lubenKaravelov = new School();  //Create new school
            ClassOfStudents desetiB = new ClassOfStudents(10, 'B');      //Create new Class
            ClassOfStudents edinaistiG = new ClassOfStudents(11, 'G');  //Create new Class
            Student pesho = new Student("Pesho", "Peshov", 2233);      //Create new Student
            Student gosho = new Student("Gosho", "Goshov", 3344);      //Create new Student
            lubenKaravelov.AddClass(desetiB);       //Add Class to School
            lubenKaravelov.AddClass(edinaistiG);    //Add Class to School


            desetiB.AddComent("Proba, 1, 2, proba, proba...");  // Add Commentar for class
            gosho.AddComent("Proba, 1, 2, proba, proba...");    // Add Commentar for student
            Console.WriteLine(lubenKaravelov);
            
            Console.WriteLine(gosho);
        }
    }
}
