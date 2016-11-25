using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    class Program
    {
        public static string Revers(string strFrase)
        {
            char[] charArr = strFrase.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
        static void Main()
        {
            string frase = Console.ReadLine();
            frase = Revers(frase);
            Console.WriteLine(frase);
        }
    }
}
