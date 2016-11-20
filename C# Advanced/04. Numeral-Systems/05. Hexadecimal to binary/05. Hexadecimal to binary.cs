using System;
class Program
{
    static string HexToBinary(string hexDigit, int numBase)
    {
        string result = "";
        int index = 0;
        char[] digits = hexDigit.ToCharArray();
        string[] dictionary = {
            "0000","0001","0010","0011",
            "0100","0101","0110","0111",
            "1000","1001","1010","1011",
            "1100","1101","1110","1111"
        };
        foreach (char num  in digits)
        {
            if (char.IsDigit(num))
            {
                index = num - '0';
            }
            else
            {
                index = char.ToUpper(num) - 'A' + 10;
            }

                result = result + dictionary[index];
        }
        return result.TrimStart('0');
    }
    static void Main()
    {
        string hexDigit = Console.ReadLine();
        int numBase = 2;
        string binNum = "";
        binNum = HexToBinary(hexDigit, numBase);

        Console.WriteLine(binNum);
    }
}