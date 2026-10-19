using Npgsql;

if (!Database.TestConnection())
{
    return;
}

Schema.CreateTables();

using var con = Database.GetConnection();
con.Open();

// using var sel = new NpgsqlCommand(
//     "SELECT * FROM genres;",
//     con
// );

// using var reader = sel.ExecuteReader();

// while (reader.Read())
// {
//     Console.WriteLine($"{reader[0]} | {reader[1]}");
// }

// var coy = new NpgsqlCommand("select count(*) from books" , con);
// var query = coy.ExecuteScalar();
// System.Console.WriteLine(query);

// using var cmd = new NpgsqlCommand(
//     "SELECT SUM(total_copies) FROM books",
//     con
// );

// var result = cmd.ExecuteScalar();
// Console.WriteLine($"Всего экземпляров: {result}");

