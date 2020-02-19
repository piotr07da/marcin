using PiotrPlayground.DatabasePlayground.Model;
using System.Data.Common;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class DepartmentWriter
    {
        private readonly DatabaseExecutor _databaseExecutor;

        public DepartmentWriter(DatabaseExecutor databaseExecutor)
        {
            _databaseExecutor = databaseExecutor;
        }

        public void WriteDepartment(Department department)
        {
            _databaseExecutor.Execute(cmd =>
            {
                cmd.CommandText = "insert into Departments (Id, Name) values ($Id, $Name)";
                AddParameter(cmd, "$Id", department.Id.ToByteArray());
                AddParameter(cmd, "$Name", department.Name);
                cmd.ExecuteNonQuery();
            });
        }

        private void AddParameter(DbCommand dbCommand, string name, object value)
        {
            var p = dbCommand.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            dbCommand.Parameters.Add(p);
        }
    }
}
