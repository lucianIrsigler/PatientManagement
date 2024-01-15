namespace PatientManagement.Database
{
    internal class DatabaseConnection
    {

        private readonly string _databaseConnectionInfo;

        public string getDatabaseInfo()
        {
            return _databaseConnectionInfo;
        }

        private void connect() { }
    }

}
