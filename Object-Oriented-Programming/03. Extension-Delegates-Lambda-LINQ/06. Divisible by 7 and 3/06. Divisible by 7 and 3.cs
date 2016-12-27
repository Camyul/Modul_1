using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisible_by_7_and_3
{
    class DivisibleBySevenAndThree
    {
        static void Main()
        {
            int[] arrIntegers = new int[] {1, 12, 14, 23, 43, 21, 44, 28, 27, 87, 56 };
            int[] orderedArr = Array.FindAll(arrIntegers, num => num % 3 == 0 || num % 7 == 0); // Using extension methods and lambda expressions
            Console.WriteLine("Using extension methods and lambda expressions");
            Console.WriteLine(String.Join(" ", orderedArr.ToArray()));
            Console.WriteLine();
            Console.WriteLine("Using LINQ");                                                    //Using LINQ
            var secondOrderedArr = from num in arrIntegers
                                     where num % 3 == 0 || num % 7 == 0
                                     select num;
            Console.WriteLine(String.Join(" ", secondOrderedArr.ToArray()));

        }
    }
}
