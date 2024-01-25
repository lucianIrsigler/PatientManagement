using Npgsql;
using PatientManagement.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Database
{
    internal class EmployeeDatabaseHandler : DatabaseOperator<Employee>
    {
        private DatabaseConnection connection;

        public EmployeeDatabaseHandler()
        {
            connection = new DatabaseConnection();
        }

        public void DeleteRecord(Employee entity)
        {
            
        }

        public DataTable GetRecord(Employee entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Employee where " +
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

        public void InsertRecord(Employee entity)
        {
            
        }

        public void UpdateRecord(Employee entity)
        {
            
        }
    }
}
