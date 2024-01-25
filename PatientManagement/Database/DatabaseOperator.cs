using Npgsql;
using System.Data;

namespace PatientManagement.Database
{
    internal interface DatabaseOperator<T>
    {
        public void InsertRecord(T entity);
        public void UpdateRecord(T entity);
        public void DeleteRecord(T entity);
        public DataTable GetRecord(T entity);
    }
}
