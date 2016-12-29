namespace Grouped_by_GroupNumber
{
    using Student_groups;
    using System;
    using System.Linq;
    class GroupedByGroupNumber
    {
        static void Main()
        {
            //Extract all students grouped by GroupNumber and prints to the console. - Task 18
            Console.WriteLine("Extract all students grouped by GroupNumber and prints to the console. - Task 18");
            Console.WriteLine(new String('-', 80));
            var groupedStudents = from st in StudentGroups.listOfStudent
                                  group st by st.GroupNum
                                  into groups
                                  select new
                                  {
                                      Group = groups.Key,
                                      Students = groups
                                  };
            foreach (var gr in groupedStudents)
            {
                Console.Write("\nGroup: {0} Students:\n--------------\n{1}", gr.Group,
                                                    string.Join("\r\n", gr.Students));
                Console.WriteLine("\r\n" + new string('-', 65));
            }

            //Rewrite the previous using extension methods. - Task -19"
            Console.WriteLine("Rewrite the previous using extension methods. - Task -19");
            Console.WriteLine(new String('-', 80));
            var groupStud = StudentGroups.listOfStudent.GroupBy(x => x.GroupNum,
            (groupNumber, students) => new { Group = groupNumber, Students = students });

            foreach (var grouped in groupStud)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                string.Join("\r\n", grouped.Students));
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
