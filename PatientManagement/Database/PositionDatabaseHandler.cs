﻿using Npgsql;
using PatientManagement.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Database
{
    internal class PositionDatabaseHandler : DatabaseOperator<Position>
    {

        private DatabaseConnection connection;

        public PositionDatabaseHandler()
        {
            connection = new DatabaseConnection();
        }

        public void DeleteRecord(Position entity)
        {
            
        }

        public DataTable GetRecord(Position entity)
        {
            using (NpgsqlConnection conn = connection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Position where " +
                    "PositionID == " + entity.getID(), conn))
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

        public void InsertRecord(Position entity)
        {
            
        }

        public void UpdateRecord(Position entity)
        {
            
        }
    }
}
