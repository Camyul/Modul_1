using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Date_difference
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter First Date (dd/MM/yyyy): ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter Second Date (dd/MM/yyyy): ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int count = 0;
            while (firstDate != secondDate)
            {
               firstDate = firstDate.AddDays(1);
                count++;
            }
            Console.WriteLine("{0} days",count);

        }
    }
}
