using System;
class Program
{
    static string DecToBin(short shortNum, short numBase)
    {
        string result = "";
        short shortN = Math.Abs(shortNum);
        do
        {
            int digit = shortN % numBase;
            shortN /= 2;
            result = digit + result;
        } while (shortN > 0);
        if (shortNum < 0)
        {
            result = (~(int.Parse(result) + 1)).ToString();
        }
        return result;
    }
    static void Main()
    {
        short shortNum = short.Parse(Console.ReadLine());
        short numBase = 2;
        string binNum = "";
        binNum = DecToBin(shortNum, numBase);
        Console.WriteLine(binNum.PadLeft(16, '0'));
    }
}