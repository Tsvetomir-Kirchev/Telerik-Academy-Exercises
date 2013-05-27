using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadAndPrintCompanyInfo
{
    public class Company
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public Manager Manager { get; set; }
    }
}
