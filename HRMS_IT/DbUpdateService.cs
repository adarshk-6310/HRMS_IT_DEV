public class DbUpdateService : IHostedService
{
    private readonly IConfiguration _configuration;

    public DbUpdateService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        InitializeDatabase();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void InitializeDatabase()
    {
        //var connStr = _configuration.GetConnectionString("ConnStrVal");

        //using var conn = new NpgsqlConnection(connStr);
        //conn.Open();

        //var s = new DBUpdate().ApplyDBUpdate(1);

        //using var cmd = new NpgsqlCommand(sql, conn);
        //cmd.ExecuteNonQuery();

    }
}
