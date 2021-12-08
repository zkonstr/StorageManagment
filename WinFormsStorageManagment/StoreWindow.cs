using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage.WinFormsStorageManagment
{
    public partial class StoreWindow : Form
    {
        private static StoreWindow instance;
        public static StoreWindow getInstanse()
        {
            if (instance == null)
                instance = new StoreWindow();
            return instance;
        }
        public StoreWindow()
        {
            InitializeComponent();
        }

        private void StoreWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storageDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.storageDataSet.Stock);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StoreWindow_Shown(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zkons\Documents\Storage.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Stock Where ID = '" + textBox1.Text + "' and CONVERT(VARCHAR, Password) = '" + textBox2.Text + "'", cn);
            DataTable dt = new DataTable();
            //sda.Fill(dt);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
