using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Storage.Databases;
using Storage.WinFormsStorageManagment;

namespace Storage
{
    static class Program
    {
        static SqlConnection cn = new SqlConnection();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            
        }
    }
}