using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintOddLinesFromFile
{
    class PrintOddFilesFromFile
    {
        static void Main(string[] args)
        {
            string path = @"..\..\PrintOddFilesFromFile.cs";
            PrintOddLines(path);
        }

        public static void PrintOddLines(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    int lineNumber = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (lineNumber % 2 != 0)
                        {
                            Console.WriteLine("{0}: {1}", lineNumber, line);
                        }
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file {0}, does not exists.", path);
            }
        }
    }
}
