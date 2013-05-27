using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadAndPrintCompanyInfo
{
    class ReadAndPrintCompanyInfo
    {
        private Company company;
        private Manager manager;

        ReadAndPrintCompanyInfo()
        {
            company = new Company();
            manager = new Manager();
        }

        static void Main(string[] args)
        {
            ReadAndPrintCompanyInfo program = new ReadAndPrintCompanyInfo();
            program.ReadInfo();
            program.PrintInfo();
        }

        private void ReadInfo()
        {
            Console.Write("Enter Company's name: ");
            company.Name = Console.ReadLine();
            Console.Write("Enter Company's phone number: ");
            company.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Company's fax number: ");
            company.Fax = Console.ReadLine();
            Console.Write("Enter Company's web-site: ");
            company.WebSite = Console.ReadLine();

            Console.Write("Enter Manager's first name: ");
            manager.FirstName = Console.ReadLine();
            Console.Write("Enter Manager's last name: ");
            manager.LastName = Console.ReadLine();
            company.Manager = manager;
        }

        private void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Printing Company;s Info: ");
            Console.WriteLine("Company Name: " + company.Name);
            Console.WriteLine("Company Phone Number: " + company.PhoneNumber);
            Console.WriteLine("Company Fax Number: " + company.Fax);
            Console.WriteLine("Company Web Site: " + company.WebSite);
            Console.WriteLine("Manager: " + company.Manager.FullName);
        }
    }
}
