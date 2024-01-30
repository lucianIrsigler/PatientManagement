using Npgsql;
using System.Data;

namespace PatientManagement.Database
{
    internal class ConsultationDatabaseHandler : DatabaseOperator<Consultation>
    {

        private DatabaseConnection connection;

        public ConsultationDatabaseHandler()
        {
            connection = new DatabaseConnection();
        }

        public void DeleteRecord(Consultation entity)
        {
            
        }

        public DataTable GetAll()
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetRecord(Consultation entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Consultation where " +
                    "ConsultationID == " + entity.getID(), conn))
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

        public void InsertRecord(Consultation entity)
        {
            
        }

        public void UpdateRecord(Consultation entity)
        {
            
        }
    }
}
