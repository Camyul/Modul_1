using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workdays
{
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.Write("Enter start Date(\"dd.MM.yyyy\"): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            int count = 0;
            List<DateTime> hollyDays = new List<DateTime>();
            Console.Write("Enter a HollyDays(\"dd.MM.yyyy\")\nEnter \"end\" for finish: ");
            
            while (true)
            {
                string hollyDay = Console.ReadLine();
                if (hollyDay == "end")
                {
                    break;
                }
                else
                {
                    hollyDays.Add(DateTime.ParseExact(hollyDay, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                }
            }
            foreach (var day in hollyDays)
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                else
                {
                    count--;
                }
            }
            while (startDate.CompareTo(today) <= 0)
            {
                
                if (startDate.DayOfWeek != DayOfWeek.Saturday &&
                    startDate.DayOfWeek != DayOfWeek.Sunday)
                {

                    Console.WriteLine(startDate.DayOfWeek.ToString());
                    count++;
                }
                startDate = startDate.AddDays(+1);
            }
            Console.WriteLine(count);
        }
    }
}
