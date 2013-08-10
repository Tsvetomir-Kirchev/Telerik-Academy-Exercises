using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WriteFileToOtherWithLineNumbers
{
    class WriteFileToOtherWithineNumbers
    {
        static void Main(string[] args)
        {
            string path = @"../../read.txt";
            string fileToWrite = @"../../write.txt";
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    StreamWriter writer = new StreamWriter(fileToWrite);
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        int lineNumber = 1;
                        while (line != null)
                        {
                            writer.WriteLine(lineNumber + ": " + line);
                            lineNumber++;
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File {0} does not exists", path);
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured while processing files: {0}, {1}",
                    path, fileToWrite);
            }
        }
    }
}
