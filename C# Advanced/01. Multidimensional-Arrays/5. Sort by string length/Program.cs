using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static List<string> SortList(List<string> strList)
    {
        int count = 0;
        while (count < strList.Count)
        {
            
            int minIndex = FindMinElement(strList, strList.Count, strList[count].Length);
            count++;
            string temp = strList[0];
            strList[0] = strList[minIndex];
            strList[minIndex] = temp;
        }
        return strList;
    }
    static int FindMinElement(List<string> strList, int maxCount, int element)
    {
        int minIndex = int.MaxValue;
        for (int i = 0; i < maxCount; i++)
        {
            if (strList[i].Length < element)
            {
                minIndex = i;
                element = strList[i].Length;
            }
        }
        return minIndex;
    }
    static void Main()
    {
        List<string> strList = new List<string>();
        string sequence = "";
        while (sequence != "end")
        {
            sequence = Console.ReadLine();
            strList.Add(sequence);
        }
        SortList(strList);
        Console.WriteLine(string.Join(" ", strList));
    }
}