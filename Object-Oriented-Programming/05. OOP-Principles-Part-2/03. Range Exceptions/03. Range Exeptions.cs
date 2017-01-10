namespace Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class RangeExeptions
    {
        static void Main()
        {
            try
            {
                //var petko = new Human(34);
                var petko = new Human(105);
            }
            catch (InvalidRangeException<int> ex)  //InvalidRangeException<int> by entering numbers in the range [1..100].
            {
                Console.WriteLine("Age Min Value: {0}", ex.Min);
                Console.WriteLine("Age Max Value: {0}", ex.Max);
            }
            Console.WriteLine(new string('-', 75));
            try
            {
                var joro = new Human(DateTime.Parse("01.01.1979"));
                //var joro = new Human(DateTime.Parse("01.01.1981"));
            }
            catch (InvalidRangeException<DateTime> ex)  //InvalidRangeException<DateTime> by entering dates in the range [1.1.1980 … 31.12.2013].
            {
                Console.WriteLine("Date Min Value: {0}", ex.Min.ToString("dd.MM.yyyy"));
                Console.WriteLine("Date Max Value: {0}", ex.Max.ToString("dd.MM.yyyy"));
            }
            Console.WriteLine(new string('-', 75));

        }
    }
}
