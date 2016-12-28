namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StudentsExtensions
    {
        public static List<Student> SortByFirstName(this List<Student> listSt)
        {
            List<Student> sortedList = listSt.OrderBy(st => st.FirstName).ToList();
            return sortedList;
        }
    }
}
