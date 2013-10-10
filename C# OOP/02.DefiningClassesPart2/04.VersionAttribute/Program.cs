using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VersionAttribute
{
    [Version("1.2")]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] versionAttributes = type.GetCustomAttributes(false);
            VersionAttribute attr = versionAttributes[0] as VersionAttribute;
            Console.WriteLine("Version of this class: {0}", attr.Version);
        }
    }
}
