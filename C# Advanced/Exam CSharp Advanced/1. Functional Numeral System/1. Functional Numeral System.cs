
namespace _1.Functional_Numeral_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            string[] separ = { ", " };
            string[] input = Console.ReadLine().Split(separ, StringSplitOptions.None);
            string[] encodeWords = {"ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure",
                                    "erlang", "standardml", "racket", "elm",  "mercury",  "commonlisp", "scheme", "curry"};
            //List<int> encodeDigit = new List<int>();
            StringBuilder encodeDigit = new StringBuilder();
            List<string> encodeWorsdList = new List<string>();
            long result = 1;
            //string hexNum = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                int ind = 0;
                for (int j = 0; j < encodeWords.Length; j++)
                {

                    ind = 0;
                    ind = input[i].IndexOf(encodeWords[j], ind);
                    if (ind != -1 && ind < 1)
                    {
                        encodeWorsdList.Add(input[i].Substring(ind, encodeWords[j].Length));
                        input[i] = input[i].Remove(ind, encodeWords[j].Length);
                        j = 0;
                        if (input[i].Length < 1)
                        {
                            break;
                        }
                    }
                    else
                    {
                        ind++;
                    }
                }
                ConvertToHex(encodeWords, encodeDigit, encodeWorsdList);
                result *= Convert.ToInt64(encodeDigit.ToString(), 16);
                encodeDigit.Clear();
                encodeWorsdList.Clear();
                //ConvertToDec(encodeDigit);
            }


            Console.WriteLine(result);
        }



        private static void ConvertToHex(string[] encodeWords, StringBuilder encodeDigit, List<string> encodeWorsdList)
        {
            for (int i = 0; i < encodeWorsdList.Count; i++)
            {

                for (int j = 0; j < encodeWords.Length; j++)
                {
                    if (encodeWorsdList[i] == encodeWords[j])
                    {
                         
                  
                        if (j< 9)
                        {
                            encodeDigit.Append(j.ToString());
                        }
                        else
                        {
                            switch (j)
                            {
                                case 10: encodeDigit.Append("A"); break;
                                case 11: encodeDigit.Append("B"); break;
                                case 12: encodeDigit.Append("C"); break;
                                case 13: encodeDigit.Append("D"); break;
                                case 14: encodeDigit.Append("E"); break;
                                case 15: encodeDigit.Append("F"); break;
                                default:
                                    break;
                            }
                        }
                        break;
                    }
                }
            }
            //StringBuilder hex = new StringBuilder();
            //for (int i = 0; i < encodeDigit.Length; i++)
            //{
            //    hex.Append(encodeDigit[i]);
            //}
            //return hexNum = hex.ToString();
        }
    }
}
