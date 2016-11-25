using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_decode
{
    class EncodeDecode
    {
        static void Main()
        {
            char[] cipher = Console.ReadLine().ToCharArray();
            char[] str = Console.ReadLine().ToCharArray();
            String strEncode = String.Empty;
            String strDecode = String.Empty;
            strEncode = Encode(str, cipher);
            Console.WriteLine(String.Join(" ", strEncode));
            strDecode = Decode(strEncode, cipher);
            Console.WriteLine(String.Join(" ", strDecode));

        }

        private static string Decode(string strEncode, char[] cipher)
        {
            char[] decode = new Char[strEncode.Length];
            for (int i = 0, j = 0; i < strEncode.Length; i++, j++)
            {
                if (j == cipher.Length)
                {
                    j = 0;
                }
                decode[i] = (char)((int)strEncode[i] ^ (int)cipher[j]);

            }
            return new string(decode);
        }

        private static string Encode(char[] str, char[] cipher)
        {
            char[] encode = new Char[str.Length];
            for (int i = 0, j = 0; i < str.Length; i++, j++)
            {
                if (j == cipher.Length)
                {
                    j = 0;
                }
                encode[i] = (char)((int)str[i] ^ (int)cipher[j]);
                
            }
            return new string(encode);
        }
    }
}
