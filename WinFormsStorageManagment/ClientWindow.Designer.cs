
namespace Storage.WinFormsStorageManagment
{
    partial class ClientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TV");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PC");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Smartphones");
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("TV", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("PC", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Smartphones", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {"Horizont", "Horiz1", "Horiz2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {"Asus", "A1", "A2"}, -1);
            this.CategoriesTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AtoZcomboBox = new System.Windows.Forms.ComboBox();
            this.HighLowComboBox = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Orders = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cart = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CartField = new System.Windows.Forms.ListView();
            this.NameColumn = new System.Windows.Forms.ColumnHeader();
            this.CostColumn = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Orders.SuspendLayout();
            this.Cart.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesTree
            // 
            this.CategoriesTree.CheckBoxes = true;
            this.CategoriesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesTree.Location = new System.Drawing.Point(3, 3);
            this.CategoriesTree.Name = "CategoriesTree";
            treeNode1.Name = "TvNode";
            treeNode1.Text = "TV";
            treeNode2.Name = "PcNode";
            treeNode2.Text = "PC";
            treeNode3.Name = "SmartphonesNode";
            treeNode3.Text = "Smartphones";
            this.CategoriesTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode1, treeNode2, treeNode3});
            this.tableLayoutPanel1.SetRowSpan(this.CategoriesTree, 2);
            this.CategoriesTree.Size = new System.Drawing.Size(232, 659);
            this.CategoriesTree.TabIndex = 1;
            this.CategoriesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.96474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Controls.Add(this.CategoriesTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Orders, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cart, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1269, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(241, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(838, 659);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.39335F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60665F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.listView2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.858934F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.14107F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(832, 638);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AtoZcomboBox);
            this.flowLayoutPanel1.Controls.Add(this.HighLowComboBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 24);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AtoZcomboBox
            // 
            this.AtoZcomboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.AtoZcomboBox.FormattingEnabled = true;
            this.AtoZcomboBox.Items.AddRange(new object[] {"A to Z", "Z to A"});
            this.AtoZcomboBox.Location = new System.Drawing.Point(3, 3);
            this.AtoZcomboBox.Name = "AtoZcomboBox";
            this.AtoZcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AtoZcomboBox.Size = new System.Drawing.Size(229, 24);
            this.AtoZcomboBox.TabIndex = 0;
            this.AtoZcomboBox.Text = "name";
            // 
            // HighLowComboBox
            // 
            this.HighLowComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.HighLowComboBox.FormattingEnabled = true;
            this.HighLowComboBox.Items.AddRange(new object[] {"Low to high", "High to low"});
            this.HighLowComboBox.Location = new System.Drawing.Point(238, 3);
            this.HighLowComboBox.Name = "HighLowComboBox";
            this.HighLowComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HighLowComboBox.Size = new System.Drawing.Size(212, 24);
            this.HighLowComboBox.TabIndex = 1;
            this.HighLowComboBox.Text = "cost";
            // 
            // listView2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.listView2, 3);
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "TV";
            listViewGroup1.Name = "TVlvg";
            listViewGroup2.Header = "PC";
            listViewGroup2.Name = "PClvg";
            listViewGroup3.Header = "Smartphones";
            listViewGroup3.Name = "SMRTPHNlvg";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {listViewGroup1, listViewGroup2, listViewGroup3});
            this.listView2.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem2.IndentCount = 2;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {listViewItem1, listViewItem2});
            this.listView2.Location = new System.Drawing.Point(3, 33);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(826, 602);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.listBox1);
            this.Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Orders.Location = new System.Drawing.Point(1085, 335);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(181, 327);
            this.Orders.TabIndex = 4;
            this.Orders.TabStop = false;
            this.Orders.Text = "Your orders";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 306);
            this.listBox1.TabIndex = 0;
            // 
            // Cart
            // 
            this.Cart.Controls.Add(this.tableLayoutPanel2);
            this.Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cart.Location = new System.Drawing.Point(1085, 3);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(181, 326);
            this.Cart.TabIndex = 3;
            this.Cart.TabStop = false;
            this.Cart.Text = "Cart";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.8284F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.1716F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CartField, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.67972F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32028F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 305);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(74, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "cost";
            // 
            // button1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CartField
            // 
            this.CartField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.NameColumn, this.CostColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.CartField, 2);
            this.CartField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartField.HideSelection = false;
            this.CartField.Location = new System.Drawing.Point(3, 3);
            this.CartField.Name = "CartField";
            this.CartField.Size = new System.Drawing.Size(169, 243);
            this.CartField.TabIndex = 3;
            this.CartField.UseCompatibleStateImageBehavior = false;
            this.CartField.View = System.Windows.Forms.View.List;
            this.CartField.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientWindow";
            this.Text = "ClientWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Cart.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView CartField;

        #endregion

        public System.Windows.Forms.TreeView CategoriesTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Orders;
        private System.Windows.Forms.GroupBox Cart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader CostColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox AtoZcomboBox;
        private System.Windows.Forms.ComboBox HighLowComboBox;
        private System.Windows.Forms.ListView listView2;
    }
}