using System;
class Program
{
    static string DecimalToBinary(long num, int numBase)
    {
        string result = "";
        do
        {
            long digit = num % 2;
            num /= numBase;
            result = digit + result;
        } while (num > 0);
        return result;
    }
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string binNum = "";
        int numBase = 2;
        binNum = DecimalToBinary(num, numBase);
        Console.WriteLine(binNum);
    }
}