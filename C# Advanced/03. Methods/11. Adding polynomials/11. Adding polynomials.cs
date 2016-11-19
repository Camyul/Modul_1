using System;
class Program
{
    static int[] ConvertArray(string[] strArr, int[] intArr)
    {
        for (int i = 0; i < strArr.Length; i++)
        {
            intArr[i] = int.Parse(strArr[i]);
        }
        return intArr;
    }
    static void SumArray(int[] firstArr, int[] secondArr, int[] sumArr)
    {
        for (int i = 0; i < firstArr.Length; i++)
        {
            sumArr[i] = firstArr[i] + secondArr[i];
        }
        return;
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();
        int[] firstPoly = new int[num];
        int[] secondPoly = new int[num];
        int[] sumPoly = new int[num];
        firstPoly = ConvertArray(firstArray, firstPoly);
        secondPoly = ConvertArray(secondArray, secondPoly);
        SumArray(firstPoly, secondPoly, sumPoly);
        Console.WriteLine(string.Join(" ", sumPoly));
    }
}