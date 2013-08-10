using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateAndPrintSquare
{
    class CalculateAndPrintSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                long square = Square(number);
                Console.WriteLine("The square of {0} is {1}", number, square);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        public static long Square(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return number * number;
            }
        }
    }
}
