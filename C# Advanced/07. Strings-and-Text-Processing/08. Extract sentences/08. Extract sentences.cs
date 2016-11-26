using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string searchedWord = Console.ReadLine(); //"in";
        string text = Console.ReadLine();  //"We are living in a yellow in submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; 

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        char[] delimiters = text.Where(symbol => !char.IsLetter(symbol)).Distinct().ToArray();

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < words.Length; j++)
            {
                if (searchedWord == words[j].Trim())
                {
                    Console.Write(sentence + ". ");
                    break;                        
                }
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Extract_sentences
//{
//    class ExtractSentences
//    {
//        static void Main()
//        {
//            string word = Console.ReadLine();
//            string str = Console.ReadLine();
//            ;
//            String[] strParts = str.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
//            strParts = ExtractWord(strParts, word);

//        }

//        private static string[] ExtractWord(string[] strArr, string word)
//        {
//            for (int i = 0; i < strArr.Length; i++)
//            {
//                string temp = strArr[i].Trim();
//                StringBuilder splitSymbolsStr = new StringBuilder();//{ ' ', ',', '!', '?', '"', '-', '=', '+' };//temp.Where(symbol => !char.IsLetter(symbol)).Distinct().ToArray();
//                for (int j = 32; j < 127; j++)
//                {
//                    if ((j > 31 && j < 47) || ((j > 57) && (j < 65)) || (j > 90 && j < 97) || (j > 122))
//                    {
//                        splitSymbolsStr.Append((char)j);
//                    }

//                }
//                char[] splitSymbols = splitSymbolsStr.ToString().ToCharArray();
//                List<string> searchWord = temp.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries).ToList();
//                for (int j = 0; j < searchWord.Count; j++)
//                {
//                    if (searchWord[j].Trim() == word)
//                    {
//                        Console.Write(temp + ".");
//                        break;
//                    }
//                }
//            }
//            return strArr;
//        }
//    }
//}
