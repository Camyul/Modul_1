using System;
class Program
{
    static long BinToDecimal(string binN, int numBase)
    {
        long result = 0;
        foreach (char bin in binN)
        {
            result = (result * numBase) + (bin - '0');
        }
        return result;
    }
    static void Main()
    {
        string binNum = Console.ReadLine();
        int numBase = 2;
        long decNum = 0;
        decNum = BinToDecimal(binNum, numBase);
        Console.WriteLine(decNum);
    }
}