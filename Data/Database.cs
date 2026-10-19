
using System.Reflection.Metadata;
using Npgsql;
public static class Database
{
    private static string connectionString = 
        "Host=localhost;Port=5432;Database=shop1_db;Username=postgres;Password=1234";
    public static NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(connectionString);
    }
    public static bool TestConnection()
    {
        try
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT version();", conn);
            var version = cmd.ExecuteScalar();

            Console.WriteLine($"PostgreSQL version: {version}");
            return true;
        }
        catch(NpgsqlException ex)
        {
            System.Console.WriteLine("Cannot continue without a database");
            return false;
        }
    }

}