using System;
class Program
{
    static long HexToDecimal(string num, int numBase)
    {
        long result = 0;
        char[] digits = num.ToCharArray();
        foreach (char digit in digits)
        {
            if (char.IsDigit(digit))
            {
                result = ( result * numBase) + (digit - '0');
            }
            else
            {
                result = (result * numBase) + (Char.ToLower(digit) - 'a' + 10);
            }
          
        }
        return result;
    }
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        int numBase = 16;
        long decNum = 0;
        decNum = HexToDecimal(hexNumber, numBase);
        Console.WriteLine(decNum);
    }
}