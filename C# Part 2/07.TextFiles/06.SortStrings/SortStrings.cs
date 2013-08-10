using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortStrings
{
    class SortStrings
    {
        static void Main(string[] args)
        {
            string path = @"../../people.txt";
            string pathToWrite = @"../../sortedPeople.txt";
            List<string> people = new List<string>();
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        people.Add(line);
                        line = reader.ReadLine();
                    }
                }

                StreamWriter writer = new StreamWriter(pathToWrite);
                using (writer)
                {
                    people.Sort();
                    foreach (string human in people)
                    {
                        writer.WriteLine(human);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing the files.");
            }
        }
    }
}
