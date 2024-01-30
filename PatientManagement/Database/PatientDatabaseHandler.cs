using PatientManagement.Objects;
using Npgsql;
using System.Data;

namespace PatientManagement.Database
{
    internal class PatientDatabaseHandler : DatabaseOperator<Patient>
    {

        private DatabaseConnection connection;

        public PatientDatabaseHandler()
        {
            connection = new DatabaseConnection();
        }

        public void DeleteRecord(Patient entity)
        {
        }

        public DataTable GetAll()
        {
            using(NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Patient\"", conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataTable GetRecord(Patient entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Patient\" where " +
                    "PatientID == " + entity.getID(), conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataTable GetRecords(string key, string value)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Patient\" where \"" +
                    key+"\" like '" + value + "%'", conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void InsertRecord(Patient entity)
        {
        }

        public void UpdateRecord(Patient entity)
        {
        }
    }
}
