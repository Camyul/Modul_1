using System;
class Program
{
    static int GetMax(int firstNum, int secondNum)
    {
        int maxNum = firstNum;
        if (maxNum < secondNum)
        {
            maxNum = secondNum;
        }
        return maxNum;
    }
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int maxNumber = GetMax(int.Parse(numbers[0]), int.Parse(numbers[1]));
        maxNumber = GetMax(maxNumber, int.Parse(numbers[2]));
        Console.WriteLine(maxNumber);
    }
}