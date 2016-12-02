using System;
using System.Collections.Generic;
using System.Numerics;

namespace Messages
{
    class Messages
    {
        static BigInteger Encode(string enWord)
        {
            string result = String.Empty;
            string encodeSecuence = "cadxoznopcykminmarkonivaogiyan";
            List <string> enArr = new List<string>();
            for (int i = 0; i < enWord.Length; i += 3)
            {
                enArr.Add(enWord.Substring(i, 3));
            }
            for (int i = 0; i < enArr.Count; i++)
            {
                result += encodeSecuence.IndexOf(enArr[i]) / 3;
            }
            return BigInteger.Parse(result);
        }
        static void Main()
        {
            string encriptedWord = Console.ReadLine();
            char operation = char.Parse(Console.ReadLine());
            string secondEncriptedWord = Console.ReadLine();
            BigInteger firstEncrWord = Encode(encriptedWord);
            BigInteger secondEncrWord = Encode(secondEncriptedWord);
            BigInteger result = (operation == '+') ? (firstEncrWord + secondEncrWord) : (firstEncrWord - secondEncrWord);
            string decriptedResult = Decode(result);

            Console.WriteLine(decriptedResult);
        }

        private static string Decode(BigInteger result)
        {
            string decodeSecuence = "cadxoznopcykminmarkonivaogiyan";
            string decodeResult = string.Empty;
            while(result > 0)
            {
                BigInteger digit = result % 10;
                result /= 10;
                decodeResult = decodeSecuence.Substring((int)digit * 3, 3) + decodeResult;
            }
            return decodeResult;
        }
    }
}
