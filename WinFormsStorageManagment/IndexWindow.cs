﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManagment
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
            RegWindow frm = new RegWindow();
            frm.Show();
            // do smth with main form
            //Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginWindow frm = new LoginWindow();
            frm.Show();
            // do smth with main form
            //Hide();
        }
    }
}
