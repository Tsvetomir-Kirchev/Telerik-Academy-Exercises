using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GetCategoiresAndProductsFromNorthwind
{
    class GetCategoiresAndProductsFromNorthwind
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Categories c " +
                                                    "INNER JOIN Products p " +
                                                    "ON c.CategoryID = p.CategoryID", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("{0} - {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
