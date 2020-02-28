using System;
using System.Collections.Generic;
using System.Text;
using PiotrPlayground.DatabasePlayground.Model;
using System.Data.Common;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class EmployeeReader
    {
        private readonly DatabaseExecutor _databaseExecutor;
        public EmployeeReader(DatabaseExecutor databaseExecutor)
        {
            _databaseExecutor = databaseExecutor;
        }
        public Employee[] ReadAllEmployees()
        {
            return _databaseExecutor.Execute(cmd =>
            {
                cmd.CommandText = "select Id, FirstName, LastName, DepartmentId from Employees";
                using (var reader = cmd.ExecuteReader())
                {
                    var result = new List<Employee>();
                    while (reader.Read())
                    {
                        var emp = new Employee()
                        {
                            Id = new Guid((byte[])reader["Id"]),
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            //SupervisorId = new Guid((byte[]) reader["SupervisorId"]),
                            DepartmentId= new Guid((byte[])reader["DepartmentId"]),
                        };
                        result.Add(emp);
                    }
                    return result.ToArray();
                }
            });
        }
    }
}
