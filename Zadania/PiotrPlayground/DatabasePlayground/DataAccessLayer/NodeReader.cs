using System;
using System.Collections.Generic;
using System.Text;
using PiotrPlayground.DatabasePlayground.Model;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class NodeReader
    {
      
            private readonly DatabaseExecutor _databaseExecutor;

            public NodeReader(DatabaseExecutor databaseExecutor)
            {
                _databaseExecutor = databaseExecutor;
            }

            public Node[] ReadAllNodes()
            {
                return _databaseExecutor.Execute(cmd =>
                {
                    cmd.CommandText = "select Id, Name from Departments";
                    using (var reader = cmd.ExecuteReader())
                    {
                        var result = new List<Node>();
                        while (reader.Read())
                        {
                            var dep = new Node()
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

