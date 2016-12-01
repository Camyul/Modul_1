using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Subtracting_polynomials
{
    class SubtractingPolynomials
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
        static void SubstractionArray(int[] firstArr, int[] secondArr, int[] substractionArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                substractionArr[i] = firstArr[i] - secondArr[i];
            }
            return;
        }
        static void MultipliArray(int[] firstArr, int[] secondArr, int[] resultArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                resultArr[i] = firstArr[i] * secondArr[i];
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
            int[] resultPoly = new int[num];
            firstPoly = ConvertArray(firstArray, firstPoly);
            secondPoly = ConvertArray(secondArray, secondPoly);
            SumArray(firstPoly, secondPoly, resultPoly);
            Console.WriteLine(string.Join(" ", resultPoly));
            SubstractionArray(firstPoly, secondPoly, resultPoly);
            Console.WriteLine(string.Join(" ", resultPoly));
            MultipliArray(firstPoly, secondPoly, resultPoly);
            Console.WriteLine(string.Join(" ", resultPoly));
        }
    }
}

