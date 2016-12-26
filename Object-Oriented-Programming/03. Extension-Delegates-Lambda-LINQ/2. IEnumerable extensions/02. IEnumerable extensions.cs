

namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class IEnumerable
    {
        static void Main()
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
            Print(integers);

        }

        private static void Print(IEnumerable<T> elements)
        {
            Console.WriteLine(string.Join(" ", elements));
            Console.WriteLine(elements.SumOfElements());
        }

       
    }
}