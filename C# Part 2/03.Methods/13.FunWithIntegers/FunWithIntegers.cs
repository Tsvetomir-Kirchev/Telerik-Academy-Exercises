using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FunWithIntegers
{
    class FunWithIntegers
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                PrintMenuOptios();
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter for your choice <1 - 4>");
                }
                Menu(choice);
            }
        }

        public static void PrintMenuOptios()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MENU");
            Console.WriteLine("\t1.Reverse the digits of a number.");
            Console.WriteLine("\t2.Calculate average of a sequence of integers.");
            Console.WriteLine("\t3.Solve e linear equation (a * x + b = 0).");
            Console.WriteLine("\t4.Exit.");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
        }

        public static void Menu(int choice)
        {
            switch (choice)
            {
                case 1:
                    ReverseDigitsOfANumber();
                    break;
                case 2:
                    CalculateAverageOfIntegerSequence();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Good Bye!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        public static void ReverseDigitsOfANumber()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            decimal number = 0;
            Console.Write("Enter a number to be reversed: ");
            try
            {
                number = Decimal.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input was not in a number!");
                ReverseDigitsOfANumber();
                return;
            }

            if (number < 0)
            {
                Console.WriteLine("The number must not be negative!");
                ReverseDigitsOfANumber();
                return;
            }

            string strNumber = number.ToString();
            Console.WriteLine(strNumber);
            char[] digits = strNumber.ToCharArray();
            int index = digits.Length;
            char[] reverseDigits = new char[index];

            for (int i = 0; i < index; i++)
            {
                reverseDigits[index - i - 1] = digits[i];
            }

            Console.Write("Number {0} with revrsed digits is: ", number);
            foreach (var item in reverseDigits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void CalculateAverageOfIntegerSequence()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int number = 0;
            List<int> sequence = new List<int>();
            Console.WriteLine("Enter your sequence of integers each on separate line, for end: -1");
            while (number != -1)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are not entered a number!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    continue;
                }
                if (number != -1)
                {
                    sequence.Add(number);
                }
            }

            if (sequence.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The sequence should not be empty!");
                CalculateAverageOfIntegerSequence();
                return;
            }

            int sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
            }

            int average = sum / sequence.Count;
            Console.WriteLine("The average of your sequence is: {0}", average);
        }

        public static void SolveLinearEquation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("a = ");
            int a = 0;
            try
            {
                a = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You musT etner a number!");
                SolveLinearEquation();
                return;
            }

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a should not be 0!");
                SolveLinearEquation();
                return;
            }

            Console.WriteLine("b = ");
            int b = 0;
            try
            {
                b = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You musT etner a number!");
                SolveLinearEquation();
                return;
            }

            int rightSide = b * (-1);
            decimal x = (decimal)rightSide / (decimal)a;

            Console.WriteLine("x = {0}", x);
        }
    }
}
