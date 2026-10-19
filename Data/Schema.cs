


using Npgsql;

public static class Schema
{
    public static void CreateTables()
    {
        using var con = Database.GetConnection();
        con.Open();

        var com = new NpgsqlCommand(
            @"CREATE TABLE IF NOT EXISTS genres (
            id    SERIAL PRIMARY KEY,
            name  VARCHAR(100) NOT NULL UNIQUE);" ,
            con
        );
        com.ExecuteNonQuery();

        using var insert = new NpgsqlCommand(
            @"INSERT INTO genres (name)
            VALUES
                ('Programming'),
                ('Software Design'),
                ('Databases'),
                ('Fiction'),
                ('History')
            ON CONFLICT (name) DO NOTHING;" ,
            con
        );
        insert.ExecuteNonQuery();
        Console.WriteLine("Table created and genres inserted!");
    }
}