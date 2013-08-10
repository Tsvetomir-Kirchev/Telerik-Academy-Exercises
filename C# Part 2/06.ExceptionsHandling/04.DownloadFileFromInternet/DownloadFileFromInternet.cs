using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main(string[] args)
        {
            try
            {
                string currentDurectory = Directory.GetCurrentDirectory();
                WebClient client = new WebClient();
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", currentDurectory + "\\myfile.jpg");
            }
            catch (WebException)
            {

                Console.WriteLine("WebException");
            }
            finally
            {
                Console.WriteLine("done");
            }
        }
    }
}
