using System.Data.SqlClient;

Console.WriteLine("Hello World!");



using SqlConnection conn = new("Data Source=localhost;Database=Weather;Trusted_Connection=True;");
conn.Open();

#region Read

var query = """
    SELECT *
    FROM Clouds
""";

var command = new SqlCommand(query, conn);

SqlDataReader reader = command.ExecuteReader();
var schema = reader.GetColumnSchema();

foreach (var column in schema)
{
    Console.Write($"{column.ColumnName} \t");
}

Console.WriteLine();

while (reader.Read())
{
    Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetInt32(1)}");
}
#endregion

#region ReadScalar

// var query = """
//     SELECT COUNT(*)
//     FROM Clouds
// """;
//
// var command = new SqlCommand(query, conn);
//
// var count = command.ExecuteScalar();
//
// Console.WriteLine($"Count: {count}");

#endregion

#region ExecuteNonQuery
/*
var query = """

select * from Clouds;

    INSERT INTO Clouds ([all])
    VALUES (99);


    INSERT INTO Clouds ([all])
    VALUES (98);


    INSERT INTO Clouds ([all])
    VALUES (97);
""";

var command = new SqlCommand(query, conn);

var rowsAffected = command.ExecuteNonQuery();

Console.WriteLine($"Rows affected: {rowsAffected}");
*/
#endregion

    



