using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        char[] digits = number.ToCharArray();
        Revers(digits);
        PrintNumber(digits);
    }
    static void Revers(char[] arr)
    {
        for (int i = 0; i < (arr.Length / 2); i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - 1 -i];
            arr[arr.Length - 1 -i] = temp;
        }
        return;
    }
    private static void PrintNumber(char[] digits)
    {
        foreach (char digit in digits)
        {
            Console.Write(digit);
        }
    }
}