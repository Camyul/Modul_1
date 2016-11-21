using System;
class Program
{
    static string DecToBin(short shortNum, short numBase)
    {
        string result = "";
        if (shortNum > 0) 
        {
            do
            {
                int digit = shortNum % numBase;
                shortNum /= 2;
                result = digit + result;
            } while (shortNum > 0);
        } 
        else if (shortNum < 0)
        {
            shortNum = Math.Abs(++shortNum);
            do
            {
                string digit = (shortNum % 2 == 0) ? "1" : "0";
                shortNum /= numBase;
                result = digit + result;
            } while (shortNum > 0);
            result = result.PadLeft(16, '1');
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
    //static void Main()
    //{
    //    short signedShort = short.Parse(Console.ReadLine());

    //    string binary = string.Empty;

    //    for (int i = 0; i < 16; i++)
    //    {
    //        string sign = (signedShort & 1) == 0 ? "0" : "1";
    //        binary = sign + binary;

    //        signedShort >>= 1;
    //    }

    //    Console.WriteLine(binary.PadLeft(16, '0'));
    //}
}