

namespace Correct_brackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static bool CorrectBrackets(string expression)
        {
            bool isEqual = false;
            int leftBracket = 0;
            int rightBracket = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBracket++;
                }
                else if (expression[i] == ')')
                {
                    rightBracket++;
                }
            }
            if (leftBracket == rightBracket)
            {
                isEqual = true;
            }
            return isEqual;
        }
        static void Main()
        {
            string expression = Console.ReadLine();
            bool isCorrect = CorrectBrackets(expression);
            if (!isCorrect)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                int indexLeft = expression.IndexOf('(');
                int indexRight = expression.IndexOf(')');
                while (indexLeft != -1 && indexRight != -1)
                {
                    
                    if (indexLeft < indexRight)
                    {
                        isCorrect = true;
                        
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                    indexLeft = expression.IndexOf('(', indexLeft + 1);
                    indexRight = expression.IndexOf(')', indexRight) + 1;
                }
                string result = isCorrect ? "Correct" : "Incorrect";
                Console.WriteLine(result);
            }
        }

    }
}
