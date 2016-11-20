using System;
class Program
{
    static string DecimalToHex(long num, int numBase)
    {
        string result = "";
        string hexDigit = "0123456789ABCDEF";
        do
        {
            long index = num % numBase;
            char digit = hexDigit[(int)index];
            result = digit + result;
            num /= numBase;
        } while (num > 0);

        return result;
    }
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string hexNum = "";
        int numBase = 16;
        hexNum = DecimalToHex(num, numBase);
        Console.WriteLine(hexNum);
    }
}