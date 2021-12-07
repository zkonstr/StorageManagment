using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Storage.Databases;
using Storage.WinFormsStorageManagment;

namespace Storage
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zkons\Documents\Storage.mdf;Integrated Security=True;Connect Timeout=30");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            
        }
    }
}