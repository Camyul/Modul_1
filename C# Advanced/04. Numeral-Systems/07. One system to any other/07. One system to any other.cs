using System;
class Program
{
    
    static void Main()
    {
        int baseS = int.Parse(Console.ReadLine());
        string numBaseS = Console.ReadLine();
        int baseD = int.Parse(Console.ReadLine());
        string numBaseD = "";
        if ((baseD == 10) && (baseS < 10))
        {
            numBaseD = AnyToDecimal(numBaseS, baseS);
        }
        if ((baseD == 10) && (baseS > 10))
        {
            numBaseD = AnyUpOfTenToDecimal(numBaseS, baseS);
        }
        else if(baseS < 11)
        {
            numBaseD = AnyToDecimal(numBaseS, baseS);
            numBaseD = DecimalToAny(long.Parse(numBaseD), baseD);
        }
        else if (baseS > 10)
        {
            numBaseD = AnyUpOfTenToDecimal(numBaseS, baseS);
            numBaseD = DecimalToAny(long.Parse(numBaseD), baseD);
        }
        Console.WriteLine(numBaseD);
    }
    static string AnyUpOfTenToDecimal(string num, int numBase)
    {
        long result = 0;
        char[] digits = num.ToCharArray();
        foreach (char digit in digits)
        {
            if (char.IsDigit(digit))
            {
                result = (result * numBase) + (digit - '0');
            }
            else
            {
                result = (result * numBase) + (char.ToUpper(digit) - 'A' + 10);
            }

        }
        return result.ToString();
    }
    static string DecimalToAny(long num, int numBase)
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
    static string AnyToDecimal(string numBaseS, int baseS)
    {
        long result = 0;
        foreach (char bin in numBaseS)
        {
            result = (result * baseS) + (bin - '0');
        }
        return result.ToString();
    }
    
}
