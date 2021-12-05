using System;
using System.Windows.Forms;
using Storage.Actors;
using StorageManagment;

namespace Storage.WinFormsStorageManagment
{
    public partial class IndexWindow : Form
    {
        public IndexWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Client().DoRegistration();
            RegWindow frm = new RegWindow();
            frm.Show();
            // do smth with main form
            //Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Client().DoLogin();
            LoginWindow frm = new LoginWindow();
            frm.Show();
            // do smth with main form
            //Hide();
        }
    }
}
