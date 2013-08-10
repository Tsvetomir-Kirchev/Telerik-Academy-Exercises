using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenateTwoFilesInAnother
{
    class ConcatenateTwoFilesInAnother
    {
        static void Main(string[] args)
        {
            string path1 = @"../../TextFile1.txt";
            string path2 = @"../../TextFile2.txt";
            string outputFile = "../../Result.txt";

            AddToTheEndOfFile(path1, outputFile);
            AddToTheEndOfFile(path2, outputFile);
        }

        public static void AddToTheEndOfFile(string path, string outpuFile)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    StreamWriter writer = new StreamWriter(outpuFile, true);
                    using (writer)
                    {
                        string text = reader.ReadToEnd();
                        writer.Write(text);
                    }
                }
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The file {0}, does not exisits", path);
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured with {0} file or {1} file",
                    path, outpuFile);
            }
        }
    }
}
