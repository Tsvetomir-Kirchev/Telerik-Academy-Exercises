using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\win.ini";
            try
            {
                string reader = File.ReadAllText(path);
                Console.WriteLine(reader);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path {0} is to long!", path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found", path);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do NOT have authorization to open this file!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exists!");
            }
        }
    }
}
