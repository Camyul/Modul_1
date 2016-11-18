using System;
class Program
{
    static string GetDigitAsWord(long num)
    {
        num = num % 10;
        string digit = "";
        switch (num)
        {
            case 0: digit = "zero";break;
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            default:
                break;
        }
        return digit;
    }
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string word = GetDigitAsWord(number);
        Console.WriteLine(word);
    }
}