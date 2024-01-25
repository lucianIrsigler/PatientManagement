using Npgsql;

namespace PatientManagement.Database
{
    internal class DatabaseConnection
    {

        private readonly string _databaseConnectionInfo =
            "Host=localhost;Username=postgresql;Password=U3a4^5F2fTkO;Database=PatientManagement";

        public string getDatabaseInfo()
        {
            return _databaseConnectionInfo;
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_databaseConnectionInfo);
        }
    }

}
