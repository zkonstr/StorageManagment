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
    public partial class LoginWindow : Form
    {
        private static LoginWindow instance;
        public static LoginWindow getInstanse()
        {
            if (instance == null)
                instance = new LoginWindow();
            return instance;
        }
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cn = "";
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [].[].[] Where UserName='"+ textBox1.Text +"' and Password'"+ textBox2.Text +"'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and/or password. Please try again", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
