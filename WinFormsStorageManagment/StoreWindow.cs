using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
