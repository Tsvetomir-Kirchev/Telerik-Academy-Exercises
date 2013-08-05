using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateValueOfGivenExpression
{
    class CalculateValueOfGivenExpression
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            ExpressionEvaluator expressionEvaluator =
                new ExpressionEvaluator();
            double result = 0;
            if (expressionEvaluator.TryEvaluate(expression,
                out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Incorrect expression!");
            }
        }
    }
}
