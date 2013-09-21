using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ParseUrl
{
    class ParseUrl
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter url address: ");
                string urlAddress = Console.ReadLine();
                urlAddress += "/";

                int protocolEndIndex = urlAddress.IndexOf("://");
                string protocol = urlAddress.Substring(0, protocolEndIndex);

                int serverFirstIndex = protocolEndIndex + 3;
                int serverLastIndex = urlAddress.IndexOf("/", serverFirstIndex);
                string server = urlAddress.Substring(serverFirstIndex, serverLastIndex - serverFirstIndex);

                string resource = null;
                if (serverLastIndex + 1 < urlAddress.Length)
                {
                    resource = urlAddress.Substring(serverLastIndex + 1, urlAddress.Length - serverLastIndex - 2);
                }

                Console.WriteLine("[protocol] = " + protocol);
                Console.WriteLine("[server] = " + server);
                if (resource != null)
                {
                    Console.WriteLine("[resource] = " + resource);
                }
                else
                {
                    Console.WriteLine("[resurce] = No");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The format must be for example [http://domain.com/reosurce]");
            }
        }
    }
}
