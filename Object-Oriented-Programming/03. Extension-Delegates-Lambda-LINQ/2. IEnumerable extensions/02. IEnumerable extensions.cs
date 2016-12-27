

namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    public class IEnumerable
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;  

            List<int> integers = new List<int> { 9, 1, 2, 3, 4, 5 };  //Create List of int 
            Print(integers);

            IEnumerable<double> doubles = new List<double> { 4.5, 1.1, 2.2, 3.3, 4.4, 5.5 };   //Create List of double
            Print(doubles);

            var decimals = new List<decimal> {12m,  1m, 2m, 31.2m, 4.7m, 5.5m };    //Create List of decimal
            Print(decimals);

        }

        private static void Print<T>(IEnumerable<T> elements)  //Print Results
        {
            Console.WriteLine(string.Join(" ", elements));
            Console.WriteLine("Sum: {0:F2}", elements.SumOfElements());
            Console.WriteLine("Product: {0:F2}", elements.MultiplyElement());
            Console.WriteLine("Min: {0:F2}", elements.MinElement());
            Console.WriteLine("Max: {0:F2}", elements.MaxElement());
            Console.WriteLine("Average: {0:F2}", elements.Average());
            Console.WriteLine();
        }



    }
}