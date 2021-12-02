using System;
using System.Windows.Forms;
using Storage.Databases;
using StorageManagment;

namespace Storage
{
    static class Program
    {
        private const string EnvDbTableName = "DB_TABLE_NAME";
        private const string EnvDbLocation = "DB_LOCATION";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var connection = new StoreDb(Environment.GetEnvironmentVariable(EnvDbTableName));
            connection.Connect(Environment.GetEnvironmentVariable(EnvDbLocation));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexWindow());
        }
    }
}
