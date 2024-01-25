using Npgsql;
using PatientManagement.Objects;
using System.Data;

namespace PatientManagement.Database
{
    internal class AdminDatabaseHandler : DatabaseOperator<Admin>
    {

        private DatabaseConnection connection;

        public AdminDatabaseHandler()
        {
            connection = new DatabaseConnection();
        }

        public void DeleteRecord(Admin entity)
        {
        }

        public DataTable GetRecord(Admin entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Admin where " +
                    "EmployeeID == "+ entity.getID(), conn))
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

        public void InsertRecord(Admin entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("Insert into Admin (EmployeeID,StartingDate,FirstName," +
                    "LastName,EmpPosition,SuperAdmin) VALUES (@data,@data1,@data2,@data3,@data4,@data5)", conn))
                {
                    command.Parameters.AddWithValue("@data", entity.getID());
                    command.Parameters.AddWithValue("@data1", entity.StartingDate);
                    command.Parameters.AddWithValue("@data2", entity.FirstName);
                    command.Parameters.AddWithValue("@data3", entity.LastName);
                    //03->ADMIN POSITION ID
                    command.Parameters.AddWithValue("@data4", "03");
                    command.Parameters.AddWithValue("@data5", entity.isSuperAdmin());
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRecord(Admin entity)
        {
            
        }
    }
}
