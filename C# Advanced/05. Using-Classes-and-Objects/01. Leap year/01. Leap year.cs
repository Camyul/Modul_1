using System;

namespace Leap_year
{
    class Date
    {
        private string isLeap;
        public string IsLeap
        {
            get
            {
                if (DateTime.IsLeapYear(Year))
                {
                    isLeap = "Leap";
                }
                else
                {
                    isLeap = "Common";
                }
                return isLeap;
            }
        }

        public int Year { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Date leap = new Date();
            leap.Year = int.Parse(Console.ReadLine());
            Console.WriteLine(leap.IsLeap);
        }
    }
}
