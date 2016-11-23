using System;

namespace _02.Random_numbers
{
    class Program
    {
        static void Main()
        {
            Random digit = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(digit.Next(100, 201));
            }
        }
    }
}
