using System;

namespace Sum_integers
{
    class SumIntegers
    {
        private static int SumElements(string seq)
        {
            int sum = 0;
            string[] newStr = new string[seq.Length / 2 + 1];
            int j = 0;
            for (int i = 0; i < seq.Length; i++)
            {

                if (seq[i] == ' ')
                {
                    j++;
                }
                else
                {
                    newStr[j] += seq[i];
                    
                }
            }
            int[] newArr = StrArrToIntArr(newStr);
            foreach (int digit in newArr)
            {
                sum += digit;
            }
            return sum;
        }

        private static int[] StrArrToIntArr(string[] newStr)
        {
            int[] newArr = new int[newStr.Length];
            for (int i = 0; i < newStr.Length; i++)
            {
                if (newStr[i] == null)
                {
                    break;
                }
                else
                {
                    newArr[i] = int.Parse(newStr[i]);
                }
                
            }

            return newArr;
        }

        static void Main()
        {
            string sequence = Console.ReadLine();
            int sum = SumElements(sequence);
            Console.WriteLine(sum);
        }
    }
}
