using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetCategoriesNameAndDescriptionInNorthwind
{
    class GetCategoriesNameAndDescriptionInNorthwind
    {
        static void Main(string[] args)
        {
            PrintCategoriesNamesAndDescription();
        }

        public static void PrintCategoriesNamesAndDescription()
        {
            string connectionString = @"Server=./; Database=Northwind; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT CategoryName, Description FROM Categories", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("Category name: {0}", categoryName);
                        Console.WriteLine("Category description: {0}", description);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
