using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string sameStr = Console.ReadLine();
            char[] sameChar = sameStr.ToCharArray();
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < sameChar.Length - 1; i++)
            {
                if ((sameChar[i] == sameChar[i + 1]) && (i + 1 != sameChar.Length - 1))
                {
                    continue;
                }
                else if (i + 1 == sameChar.Length - 1)
                {
                    if (sameChar[i] == sameChar[i + 1])
                    {
                        newStr.Append(sameChar[i + 1]);
                    }
                    else
                    {
                        newStr.Append(sameChar[i]);
                        newStr.Append(sameChar[i + 1]);
                    }
                }
                else
                {
                    newStr.Append(sameChar[i]);
                }
            }
            Console.WriteLine(newStr.ToString());
        }
    }
}
