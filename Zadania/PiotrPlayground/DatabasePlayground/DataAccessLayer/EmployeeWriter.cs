using System;
using System.Collections.Generic;
using System.Text;
using PiotrPlayground.DatabasePlayground.DataAccessLayer;
using PiotrPlayground.DatabasePlayground.Model;
using System.Data.Common;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class EmployeeWriter
    {
        private readonly DatabaseExecutor _databaseExecutor;

        public EmployeeWriter(DatabaseExecutor databaseExecutor)
        {
            _databaseExecutor = databaseExecutor;
        }

        public void WriteEmployee(Employee employee)
        {
            _databaseExecutor.Execute(cmd =>
            {
                cmd.CommandText = "insert into Employees (Id, DepartmentId, FirstName, LastName) values ($Id, $DepartmentId, $FirstName, $LastName)";
                AddParameter(cmd, "$Id", employee.Id.ToByteArray());
                AddParameter(cmd, "$Id", employee.DepartmentId.ToByteArray());
                AddParameter(cmd, "$FirstName", employee.FirstName);
                AddParameter(cmd, "$LastName", employee.LastName);
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
