using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string pathToRead = @"../../file.txt";
            try
            {
                StreamReader reader = new StreamReader(pathToRead);
                using (reader)
                {
                    string line = reader.ReadLine();
                    int lineNumbers = 1;
                    while (line != null)
                    {
                        if (lineNumbers % 2 != 0)
                        {
                            list.Add(line);
                        }
                        lineNumbers++;
                        line = reader.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while reading file: {0}", pathToRead);
            }

            string pathToWrite = @"../../file.txt";
            try
            {
                StreamWriter writer = new StreamWriter(pathToWrite);
                using (writer)
                {
                    foreach (var item in list)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error writing file: {0}", pathToWrite);
            }
        }
    }
}
