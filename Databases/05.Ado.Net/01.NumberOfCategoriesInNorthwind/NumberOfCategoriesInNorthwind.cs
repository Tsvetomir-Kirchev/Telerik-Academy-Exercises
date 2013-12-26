using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumberOfCategoriesInNorthwind
{
    class NumberOfCategoriesInNorthwind
    {
        static void Main(string[] args)
        {
            int count = GetNumberOfRowsInCategories();
            Console.WriteLine("The number of categires is: {0}", count);
        }

        public static int GetNumberOfRowsInCategories()
        {
            int count = 0;
            string connectionString = @"Server=./; Database=Northwind; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Categories", conn);
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }
    }
}
