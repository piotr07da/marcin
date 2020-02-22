using System;
using System.Collections.Generic;
using System.Text;
using PiotrPlayground.DatabasePlayground.Model;
using System.Data.Common;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class NodeWriter
    {
        private readonly DatabaseExecutor _databaseExecutor;

        public NodeWriter(DatabaseExecutor databaseExecutor)
        {
            _databaseExecutor = databaseExecutor;
        }

        public void WriteNode(Node node)
        {
            _databaseExecutor.Execute(cmd =>
            {
                cmd.CommandText = "insert into Nodes (Id, Name) values ($Id, $Name)";
                AddParameter(cmd, "$Id", node.Id.ToByteArray());
                AddParameter(cmd, "$Name", node.Name);
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
