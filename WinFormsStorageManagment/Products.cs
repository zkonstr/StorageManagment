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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = Storage; Integrated Security = True");
            if (IfProductExists(con, textBox1.Text))
            {
                con.Open();
                // проверь запрос(я ж не ебу как у тебя поля названы
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Storage WHERE [ProductCode] = '" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData() ;
            }
            else
            {
                MessageBox.Show("Record not Exists");
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //проверь здесь
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = Storage; Integrated Security = True");
            con.Open();
            // это перемнная статус, которую ты сказал добавишь 
            bool status;
            if (comboBox1.SelectedIndex == 0) status = true;
            else status = false;
            /// 
            var sqlQuery = "";
            //ну тут точно что то не так
            if (IfProductExists(con, textBox1.Text))
            {
                sqlQuery = @"UPDATE Storage SET [ProductName] = '"+textBox2.Text+"' [ProductStatus] ='"+ status + "' WHERE [ProductCode] = '" + textBox1.Text + "'";
            }
            else { // проверь запрос(я ж не ебу как у тебя поля названы)
                sqlQuery = @"INCERT INTO Storage (ProductCode, ProductName, ProductStatus) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "')";
            }
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();

        }
        public void LoadData() {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = Storage; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"Select * From Storage ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"]) dataGridView1.Rows[n].Cells[2].Value = "Active";
                else dataGridView1.Rows[n].Cells[2].Value = "Deactive";

            }
        }
        private bool IfProductExists(SqlConnection con, string productCode) {
            SqlDataAdapter sda = new SqlDataAdapter(@"Select 1 From Storage WHERE [ProductCode] = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            return true;
            else return false;  
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBox1.SelectedIndex = 0;
            }
            else comboBox1.SelectedIndex = 1;
        }
    }
}
