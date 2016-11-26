using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_words
{
    class ForbiddenWords
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] forbidenWords = Console.ReadLine().Split(' ').ToArray();
            //char[] splitSymbols = {' ', ',', '-'};
            //string[] textWords = text.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                {
                    text = text.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}