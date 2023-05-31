using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

using SqlConnection conn = new("Data Source=localhost;Database=Weather;Trusted_Connection=True;TrustServerCertificate=True;");
conn.Open();

var tableName = Console.ReadLine();

var query = "SELECT * FROM @tableName";


var command = new SqlCommand(query, conn);
command.Parameters.AddWithValue("@tableName", tableName);

SqlDataReader reader = command.ExecuteReader();
var schema = reader.GetColumnSchema();

foreach (var column in schema)
{
    Console.Write($"{column.ColumnName}\t");
}

Console.WriteLine();

while (reader.Read())
{
    Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetInt32(1)}");
}

