using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=adonetdb;Trusted_Connection=True;";
            string sqlExpression = "INSERT INTO ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Добавлено объектов: {number}");
            }
            Console.Read();
        }
    }
}
