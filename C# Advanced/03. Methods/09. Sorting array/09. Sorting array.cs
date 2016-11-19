using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int sizeArr = Convert.ToInt32(Console.ReadLine());
        string[] stringArr = Console.ReadLine().Split();
        int[] intArr = new int[sizeArr];
        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = Convert.ToInt32(stringArr[i]);
        }
        SortArray(intArr);
        Console.WriteLine(string.Join(" ", intArr));
    }

    private static void SortArray(int[] intArr)
    {
        for (int i = intArr.Length - 1; i >= 0; i--)
        {
            int element = intArr[i];
            int indexBigElem = IndexOfBigestElement(intArr, i, element);
            SwitchWithMaxElement(intArr, indexBigElem, i);
        }
    }
    static void SwitchWithMaxElement(int[] sortArray, int indexBigElem, int indexCurrentElem)
    {
        if (sortArray[indexCurrentElem] < sortArray[indexBigElem])
        {
            int temp = sortArray[indexBigElem];
            sortArray[indexBigElem] = sortArray[indexCurrentElem];
            sortArray[indexCurrentElem] = temp;
        }
    }
    static int IndexOfBigestElement(int[] intArr, int endIndex, int maxElement)
    {
        int index = endIndex;
        for (int i = 0; i < endIndex; i++)
        {
            if (maxElement < intArr[i])
            {
                maxElement = intArr[i];
                index = i;
            }
        }
        return index;
    }
}