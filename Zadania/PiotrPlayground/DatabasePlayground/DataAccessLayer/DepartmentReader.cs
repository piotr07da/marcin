using PiotrPlayground.DatabasePlayground.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class DepartmentReader
    {
        private readonly DatabaseExecutor _databaseExecutor;

        public DepartmentReader(DatabaseExecutor databaseExecutor)
        {
            _databaseExecutor = databaseExecutor;
        }

        public Department[] ReadAllDepartments()
        {
            return _databaseExecutor.Execute(cmd =>
            {
                cmd.CommandText = "select Id, Name from Departments";
                using (var reader = cmd.ExecuteReader())
                {
                    var result = new List<Department>();
                    while(reader.Read())
                    {
                        var dep = new Department()
                        {
                            Id = new Guid((byte[])reader["Id"]),
                            Name = (string)reader["Name"],
                        };
                        result.Add(dep);
                    }
                    return result.ToArray();
                }
            });
        }
    }
}
