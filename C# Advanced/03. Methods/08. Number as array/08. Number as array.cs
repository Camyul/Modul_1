using System;
class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(); // Size of Arrays
        string[] firstArr = Console.ReadLine().Split(); //Read First Array
        string[] secondArr = Console.ReadLine().Split(); //Read Second Array
        int[] firstArrInt = new int[firstArr.Length]; 
        int[] secondArrInt = new int[secondArr.Length];
        int[] sumArr = new int[Math.Max(firstArr.Length, secondArr.Length)];
        ConvertToInt(firstArr, firstArrInt); // Convert String Array to Int Array
        ConvertToInt(secondArr, secondArrInt);
        sumArr = CheckLargestArray(firstArrInt, secondArrInt, sumArr); // Call Method
        Console.WriteLine(string.Join(" ", sumArr)); //Print Sum of Arrays
    }
    static int[] CheckLargestArray(int[] firstArr, int[] secondArr, int[] sumArr)
    {
        int inMind = 0;
        int tempSum = 0;
        int tempDigit = 0;
        if (firstArr.Length >= secondArr.Length) // Check who is Largest
        {
            SumArr(firstArr, secondArr, sumArr, ref inMind, ref tempSum, ref tempDigit);
            //Call Method to Sum Arrays
        }
        else
        {
            SumArr(secondArr, firstArr, sumArr, ref inMind, ref tempSum, ref tempDigit);
            //Call Method to Sum Arrays
        }

        return sumArr;
    }

    private static void SumArr(int[] firstArr, int[] secondArr, int[] sumArr, ref int inMind, ref int tempSum, ref int tempDigit)
    {
        for (int i = 0; i < firstArr.Length; i++) //First is Largest
        {
            if (i < secondArr.Length)
            {
                tempSum = firstArr[i] + secondArr[i] + inMind;
                tempDigit = (tempSum % 10);
                inMind = tempSum / 10;
                sumArr[i] = tempDigit;
            }
            else
            {
                tempSum = firstArr[i] + inMind;
                tempDigit = (tempSum % 10);
                inMind = tempSum / 10;
                sumArr[i] = tempDigit;
            }
        }
    }

    private static void ConvertToInt(string[] firstArr, int[] firstArrInt)
    {
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArrInt[i] = int.Parse(firstArr[i]);
        }
        
    }
}