using Npgsql;

namespace PatientManagement.Database
{
    internal class DatabaseConnection
    {

        private readonly string _databaseConnectionInfo =
            "Host=localhost;Username=management;Password=management;Database=PatientManagement";

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
