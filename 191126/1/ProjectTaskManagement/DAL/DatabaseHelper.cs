using System.Configuration;
using Microsoft.Data.SqlClient;

namespace ProjectTaskManagement.DAL;

public static class DatabaseHelper
{
    private static readonly string _connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
        ?? "Data Source=SCHALE-PC;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}

