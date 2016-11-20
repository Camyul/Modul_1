using System;
using System.Numerics;

class Program
{
    //static BigInteger FactorialRacursive(int num)
    //{
    //    if (num > 1)
    //    {
    //        BigInteger tempFackt = num * Factorial(num - 1);
    //        return tempFackt;
    //    }
    //    else
    //    {
    //        return 1;
    //    }

    //}
    static BigInteger Factorial(int[] matrix)
    {
        BigInteger result = 1;
        foreach (var digit in matrix)
        {
            result *= digit;
        }
        return result;
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] matrix = new int[num];
        BigInteger factorial = 1;
        for (int i = 1; i <= matrix.Length; i++)
        {
            matrix[i-1] = i;
        }
        factorial = Factorial(matrix);
        Console.WriteLine(factorial);
    }
}