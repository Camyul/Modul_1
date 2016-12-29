namespace Grouped_by_GroupNumber
{
    using System;
    using Student_groups;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClassLibrary;
    class GroupedByGroupNumber
    {
        static void Main()
        {
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


        }
    }
}
