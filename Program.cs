using System;
using System.Windows.Forms;
using Storage.Databases;
using Storage.WinFormsStorageManagment;
using StorageManagment;

namespace Storage
{
    static class Program
    {
        private const string EnvStDbTableName = "DB_STORE_TABLE_NAME";
        private const string EnvStDbLocation = "DB_STORE_LOCATION";
        private const string EnvUsDbTableName = "DB_USER_TABLE_NAME";
        private const string EnvUsDbLocation = "DB_USER_LOCATION";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var storeConnection = new StoreDb(Environment.GetEnvironmentVariable(EnvStDbTableName));
            storeConnection.Connect(Environment.GetEnvironmentVariable(EnvStDbLocation));
            var userDbConnection = new UserDb(Environment.GetEnvironmentVariable(EnvUsDbTableName));
            userDbConnection.Connect(Environment.GetEnvironmentVariable(EnvUsDbLocation));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexWindow());
            storeConnection.Disconnect();
            userDbConnection.Disconnect();
        }
    }
}