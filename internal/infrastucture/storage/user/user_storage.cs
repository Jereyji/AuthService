using Npgsql;
using System;

namespace Infrastucture.Storage;

public class UserStorage : IDisposable
{
    private NpgsqlConnection _connection;

    public UserStorage(string connectionString)
    {
        _connection = new NpgsqlConnection(connectionString);

        try
        {
            _connection.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
            // ADD Log
            throw;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        _connection?.Dispose();
    }

    ~UserStorage()
    {
        Dispose(false);
    }
}
