using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DeleteAllWordsWithGivenPrefix
{
    class DeleteAllWordsWithGivenPrefix
    {
        static void Main(string[] args)
        {
            string pathToRead = @"../../test.txt";
            string pathToWrite = @"../../output.txt";

            try
            {
                StreamReader reader = new StreamReader(pathToRead);
                using (reader)
                {
                    StreamWriter writer = new StreamWriter(pathToWrite);
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string empty = "";
                        writer.WriteLine(line.Replace("test", empty));
                        line = reader.ReadLine();
                    }
                    writer.Close();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error while processing files.");
            }
        }
    }
}
