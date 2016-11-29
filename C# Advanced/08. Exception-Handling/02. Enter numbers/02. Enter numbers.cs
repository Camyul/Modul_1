using System;

namespace _02.Enter_numbers
{
    class EnterNumbers
    {
        static int[] numb = new int[10];
        static int[] ReadNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                numb[i] = int.Parse(Console.ReadLine());
                if (numb[i] <= 1 || numb[i] > 99)
                {
                    throw new Exception();
                }
                
            }
            return numb;
        }
        static void Main()
        {
            
            
            try
            {
                numb = ReadNumbers(0, 10);
                CheckSorted(0, 10);
                Console.WriteLine("1 < " + string.Join(" < ", numb) + " < 100");
            }
            catch (Exception)
            {

                Console.WriteLine("Exception");
            }
        }

        private static void CheckSorted(int start, int end)
        {
            for (int i = start; i < end - 1; i++)
            {
                if (numb[i] >= numb[i + 1])
                {
                    throw new Exception();
                }
            }
        }
    }
}
