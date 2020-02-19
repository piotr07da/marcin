using System;
using System.Data.Common;
using System.Data.SQLite;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class DatabaseExecutor
    {
        private string _connectionString;

        public DatabaseExecutor(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Execute(Action<DbCommand> onCommandAction)
        {
            Execute<object>(cmd =>
            {
                onCommandAction(cmd);
                return null;
            });
        }

        public T Execute<T>(Func<DbCommand, T> onCommandFunction)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    return onCommandFunction(command);
                }
            }
        }
    }
}
