using System;
using System.Data.SqlClient;
using System.Data;

namespace Ado_Connected_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5E1Q7T3\\SQLEXPRESS;initial catalog=PracticeDB;integrated security=true");
                con.Open();
                Console.WriteLine("Connection Established");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
