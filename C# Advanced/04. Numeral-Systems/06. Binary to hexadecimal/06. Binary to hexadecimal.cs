using System;
class Program
{
    static string BinToHex(string binNumber)
    {
        binNumber = AddZeros(binNumber);
        string result = "";
        string[] binNums = SplitBinNumberToParts(binNumber);
        ConvertBinPartsToHex(ref result, binNums);

        return result;
    }

    private static string[] SplitBinNumberToParts(string binNumber)
    {
        string[] binNums = new string[(binNumber.Length / 4)];
        int j = 0;
        for (int i = 0; i < binNumber.Length; i += 4)
        {
            binNums[j++] = binNumber.Substring(i, 4);
        }

        return binNums;
    }

    private static void ConvertBinPartsToHex(ref string result, string[] binNums)
    {
        string[] dictionary = {
            "0000","0001","0010","0011",
            "0100","0101","0110","0111",
            "1000","1001","1010","1011",
            "1100","1101","1110","1111"
        };

        for (int i = 0; i < binNums.Length; i++)
        {
            for (int j = 0; j < dictionary.Length; j++)
            {
                if (binNums[i] == dictionary[j])
                {
                    if (j <= 9)
                    {
                        result = result + j;
                        break;
                    }
                    else
                    {
                        char digit = (char)(j - 10 + 'A');
                        result = result + digit.ToString();
                        break;
                    }
                }
            }
        }
    }

    private static string AddZeros(string binNumber)
    {
        while (binNumber.Length % 4 != 0)
        {
            binNumber = "0" + binNumber;
        }

        return binNumber;
    }

    static void Main()
    {
        string binNum = Console.ReadLine();
        string hexNum = "";
        hexNum = BinToHex(binNum);
        Console.WriteLine(hexNum);
    }
}