using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CheckExpressionForCorrectlyBrackets
{
    class CheckExpressionForCorrectlyBrackets
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";
            bool areCorrect = AreBracketsCorrect(expression);
            Console.WriteLine("Are brackets of: {0} correct? {1}",
                expression, areCorrect);
        }

        public static bool AreBracketsCorrect(string expression)
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push('(');
                }
                if (expression[i] == ')')
                {
                    if (brackets.Count == 0)
                    {
                        return false;
                    }
                    brackets.Pop();
                }
            }

            if (brackets.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
