using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_characters
{
    class UnicodeCharacters
    {
        static string DecimalToHex(long num, int numBase)
        {
            string result = "";
            string hexDigit = "0123456789ABCDEF";
            do
            {
                long index = num % numBase;
                char digit = hexDigit[(int)index];
                result = digit + result;
                num /= numBase;
            } while (num > 0);

            return result;
        }
        static void Main()
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            StringBuilder unicodeLiteral = DecimalToUnicode(symbols);

            Console.WriteLine(unicodeLiteral.ToString());
        }

        private static StringBuilder DecimalToUnicode(char[] symbols)
        {
            StringBuilder unicodeLiteral = new StringBuilder();
            for (int i = 0; i < symbols.Length; i++)
            {
                string hexNum = DecimalToHex((long)symbols[i], 16);
                string unicodeConst = "\\u";
                for (int j = 4; j > hexNum.Length; j--)
                {
                    unicodeConst += "0";
                }
                if (hexNum.Length < 2)
                {

                }
                unicodeLiteral.Append(unicodeConst);
                unicodeLiteral.Append(hexNum);
            }

            return unicodeLiteral;
        }
    }
}
