using System.Collections.Generic;
using System.Data.SQLite;
using static System.Data.SqlClient.SqlConnection;

namespace Storage.RegNLog
{
    public class UserDb
    {
        private SQLiteConnection _connection;
        private readonly string _tableName;
        public UserDb(string tableName)
        {
            _tableName = tableName;
        }

        public bool Connect(string url)
        {
            var connString = $"Data Source={url};Version=3;";
            _connection = new SQLiteConnection(connString);
            _connection.Open();
            var cmd = _connection.CreateCommand();
            cmd.CommandText =
                $"CREATE TABLE IF NOT EXISTS {_tableName}(ID INTEGER PRIMARY KEY AUTOINCREMENT, NAME TEXT, COST REAL)";
            //TODO make DB great again
            cmd.ExecuteScalar();
            return true;
        }

        public bool Disconnect()
        {
            _connection.Close();
            return true;
        }

    }
}