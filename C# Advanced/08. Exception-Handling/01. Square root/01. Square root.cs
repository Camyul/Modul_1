using System;
namespace _01.Square_root
{
    class SquareRoot
    {
       
        static void Main()
        {
            
            try
            {
                double num = double.Parse(Console.ReadLine());
                num = SqRoot(num);
                Console.WriteLine("{0:F3}", num);
            }
            catch (SystemException)
            {
                Console.WriteLine("Invalid number");
                //Console.WriteLine(ann.Message);
                
            }
            
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }

        private static double SqRoot(double num)
        {
            if (num <= 0)
            {
                throw new SystemException();
            }
            num = Math.Sqrt(num);
            return num;
        }
    }
}
