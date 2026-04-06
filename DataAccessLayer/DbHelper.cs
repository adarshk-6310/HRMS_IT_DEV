using Microsoft.Extensions.Configuration;
using Npgsql;

public class DbHelper
{
    private readonly string _connectionString;

    public DbHelper(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Postgres");
    }

    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }


    public bool ExecuteQuery(string query)
    {
        bool result = false;
        try
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);
            result = cmd.ExecuteNonQuery() >= 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Excute Query" + query + ex);
        }
        return result;
    }






}
