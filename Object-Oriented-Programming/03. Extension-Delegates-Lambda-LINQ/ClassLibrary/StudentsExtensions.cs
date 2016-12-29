namespace ClassLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    public static class StudentsExtensions
    {
        public static List<Student> SortByFirstName(this List<Student> listSt) //Task 10
        {
            List<Student> sortedList = listSt.OrderBy(st => st.FirstName).ToList();
            return sortedList;
        }
        public static List<Student> SearchTwoMarksTwo(this List<Student> st)  //Task 14
        {
            var studentsWithTwoTwo = st.Where(s => s.Mark.FindAll(m => m == 2).Count == 2).ToList();
            return studentsWithTwoTwo;

        }
    }
}
    

