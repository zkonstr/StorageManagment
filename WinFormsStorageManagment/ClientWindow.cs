using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Storage.WinFormsStorageManagment
{
    public partial class ClientWindow : Form
    {
        public ClientWindow()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CategoriesTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            throw new System.NotImplementedException();
            //TODO DB
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClientWindow
            // 
            this.ClientSize = new System.Drawing.Size(922, 383);
            this.Name = "ClientWindow";
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.ResumeLayout(false);

        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
