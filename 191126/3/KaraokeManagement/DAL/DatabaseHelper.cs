using System.Configuration;
using Microsoft.Data.SqlClient;

namespace KaraokeManagement.DAL;

public static class DatabaseHelper
{
    private static readonly string _connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
        ?? "Server=localhost;Database=KaraokeDB;Integrated Security=True;TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}

