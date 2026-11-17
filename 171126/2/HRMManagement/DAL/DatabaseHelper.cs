using System.Configuration;
using Microsoft.Data.SqlClient;

namespace HRMManagement.DAL
{
    public static class DatabaseHelper
    {
        private static readonly string DefaultConnectionString =
            "Server=.;Database=HRMDB;Integrated Security=True;TrustServerCertificate=True";

        public static string ConnectionString
        {
            get
            {
                var connSetting = ConfigurationManager.ConnectionStrings["HRMDB"];
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

