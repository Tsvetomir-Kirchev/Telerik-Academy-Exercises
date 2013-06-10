using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.InputChoice
{
    class InputChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \'int\' for integer, \'string\' for text or\n\'double\'" +
                 " for floating point variable: ");
            string choice = Console.ReadLine();

            PorcessChoice(choice);
        }

        private static void PorcessChoice(string choice)
        {
            switch (choice)
            {
                case "int":
                    Console.Write("Enter an integer: ");
                    int number = Int32.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine(number);
                    break;
                case "string":
                    Console.Write("Enter a string: ");
                    string str = Console.ReadLine();
                    str += "*";
                    Console.WriteLine(str);
                    break;
                case "double":
                    Console.Write("Enter a floating point variable: ");
                    double doubleNum = Double.Parse(Console.ReadLine());
                    doubleNum += 1.0;
                    Console.WriteLine(doubleNum);
                    break;
                default:
                    Console.WriteLine("Unknown type!");
                    break;
            }
        }
    }
}
