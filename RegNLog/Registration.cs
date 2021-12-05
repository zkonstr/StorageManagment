using System;
using System.Collections.Generic;
using System.IO;
using Storage.Databases;

namespace Storage.RegNLog
{
    public class Registration
    {
        private const string EnvDbTableName = "DB_TABLE_NAME";
        private const string EnvDbLocation = "DB_LOCATION";
        public Registration()
        {
            
            var connection = new UserDb(Environment.GetEnvironmentVariable(EnvDbTableName));
            connection.Connect(Environment.GetEnvironmentVariable(EnvDbLocation));
        }

        public void DoRegister()
        {
            
        }
    }
}