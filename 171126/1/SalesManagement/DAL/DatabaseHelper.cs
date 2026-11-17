using System.Configuration;
using Microsoft.Data.SqlClient;

namespace SalesManagement.DAL
{
    public static class DatabaseHelper
    {
        private static readonly string DefaultConnectionString =
            "Server=.;Database=SalesDB;Integrated Security=True;TrustServerCertificate=True";

        public static string ConnectionString
        {
            get
            {
                var connSetting = ConfigurationManager.ConnectionStrings["SalesDB"];
                if (connSetting != null && !string.IsNullOrWhiteSpace(connSetting.ConnectionString))
                {
                    return connSetting.ConnectionString;
                }
                return DefaultConnectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}

