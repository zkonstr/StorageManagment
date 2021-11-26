
namespace StorageManagment
{
    partial class RegWindow
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

        #endregion
        ////////////////////////////////////////////////////////
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enter_password = new System.Windows.Forms.TextBox();
            this.passward_text = new System.Windows.Forms.TextBox();
            this.enter_login = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.enter_bankaccnum = new System.Windows.Forms.TextBox();
            this.bankaccnum_text = new System.Windows.Forms.TextBox();
            this.enter_email = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.enter_number = new System.Windows.Forms.TextBox();
            this.number_text = new System.Windows.Forms.TextBox();
            this.enter_surname = new System.Windows.Forms.TextBox();
            this.enter_adress = new System.Windows.Forms.TextBox();
            this.enter_country = new System.Windows.Forms.TextBox();
            this.adress_text = new System.Windows.Forms.TextBox();
            this.enter_lastname = new System.Windows.Forms.TextBox();
            this.enter_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.lastname_text = new System.Windows.Forms.TextBox();
            this.country_text = new System.Windows.Forms.TextBox();
            this.surname_text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PrivacyNoteLb = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1634, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 63);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(4, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 63);
            this.button2.TabIndex = 21;
            this.button2.Text = "Go back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enter_password
            // 
            this.enter_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_password.Location = new System.Drawing.Point(260, 556);
            this.enter_password.Margin = new System.Windows.Forms.Padding(4);
            this.enter_password.Name = "enter_password";
            this.enter_password.PasswordChar = '*';
            this.enter_password.Size = new System.Drawing.Size(1567, 26);
            this.enter_password.TabIndex = 19;
            this.enter_password.UseSystemPasswordChar = true;
            this.enter_password.TextChanged += new System.EventHandler(this.TextBox20_TextChanged);
            // 
            // passward_text
            // 
            this.passward_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passward_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passward_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passward_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passward_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passward_text.Location = new System.Drawing.Point(4, 556);
            this.passward_text.Margin = new System.Windows.Forms.Padding(4);
            this.passward_text.Name = "passward_text";
            this.passward_text.ReadOnly = true;
            this.passward_text.Size = new System.Drawing.Size(248, 19);
            this.passward_text.TabIndex = 18;
            this.passward_text.TabStop = false;
            this.passward_text.Text = "Password\r\n";
            // 
            // enter_login
            // 
            this.enter_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_login.Location = new System.Drawing.Point(260, 522);
            this.enter_login.Margin = new System.Windows.Forms.Padding(4);
            this.enter_login.Name = "enter_login";
            this.enter_login.Size = new System.Drawing.Size(1567, 26);
            this.enter_login.TabIndex = 17;
            this.enter_login.TextChanged += new System.EventHandler(this.Enter_login_TextChanged);
            // 
            // login_text
            // 
            this.login_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.login_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_text.Location = new System.Drawing.Point(4, 522);
            this.login_text.Margin = new System.Windows.Forms.Padding(4);
            this.login_text.Name = "login_text";
            this.login_text.ReadOnly = true;
            this.login_text.Size = new System.Drawing.Size(248, 19);
            this.login_text.TabIndex = 16;
            this.login_text.TabStop = false;
            this.login_text.Text = "Login";
            this.login_text.TextChanged += new System.EventHandler(this.Login_text_TextChanged);
            // 
            // enter_bankaccnum
            // 
            this.enter_bankaccnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_bankaccnum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_bankaccnum.Location = new System.Drawing.Point(260, 488);
            this.enter_bankaccnum.Margin = new System.Windows.Forms.Padding(4);
            this.enter_bankaccnum.Name = "enter_bankaccnum";
            this.enter_bankaccnum.Size = new System.Drawing.Size(1567, 26);
            this.enter_bankaccnum.TabIndex = 15;
            // 
            // bankaccnum_text
            // 
            this.bankaccnum_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bankaccnum_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankaccnum_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bankaccnum_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankaccnum_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankaccnum_text.Location = new System.Drawing.Point(4, 488);
            this.bankaccnum_text.Margin = new System.Windows.Forms.Padding(4);
            this.bankaccnum_text.Name = "bankaccnum_text";
            this.bankaccnum_text.ReadOnly = true;
            this.bankaccnum_text.Size = new System.Drawing.Size(248, 19);
            this.bankaccnum_text.TabIndex = 14;
            this.bankaccnum_text.TabStop = false;
            this.bankaccnum_text.Text = "Bank account number";
            this.bankaccnum_text.TextChanged += new System.EventHandler(this.Bankaccnum_text_TextChanged);
            // 
            // enter_email
            // 
            this.enter_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_email.Location = new System.Drawing.Point(260, 454);
            this.enter_email.Margin = new System.Windows.Forms.Padding(4);
            this.enter_email.Name = "enter_email";
            this.enter_email.Size = new System.Drawing.Size(1567, 26);
            this.enter_email.TabIndex = 13;
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.email_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.email_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(4, 454);
            this.email_text.Margin = new System.Windows.Forms.Padding(4);
            this.email_text.Name = "email_text";
            this.email_text.ReadOnly = true;
            this.email_text.Size = new System.Drawing.Size(248, 19);
            this.email_text.TabIndex = 12;
            this.email_text.TabStop = false;
            this.email_text.Text = "E-mail";
            // 
            // enter_number
            // 
            this.enter_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_number.Location = new System.Drawing.Point(260, 420);
            this.enter_number.Margin = new System.Windows.Forms.Padding(4);
            this.enter_number.Name = "enter_number";
            this.enter_number.Size = new System.Drawing.Size(1567, 26);
            this.enter_number.TabIndex = 11;
            // 
            // number_text
            // 
            this.number_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.number_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_text.Location = new System.Drawing.Point(4, 420);
            this.number_text.Margin = new System.Windows.Forms.Padding(4);
            this.number_text.Name = "number_text";
            this.number_text.ReadOnly = true;
            this.number_text.Size = new System.Drawing.Size(248, 19);
            this.number_text.TabIndex = 10;
            this.number_text.TabStop = false;
            this.number_text.Text = "Phone number";
            this.number_text.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // enter_surname
            // 
            this.enter_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_surname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_surname.Location = new System.Drawing.Point(260, 284);
            this.enter_surname.Margin = new System.Windows.Forms.Padding(4);
            this.enter_surname.Name = "enter_surname";
            this.enter_surname.Size = new System.Drawing.Size(1567, 26);
            this.enter_surname.TabIndex = 4;
            this.enter_surname.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // enter_adress
            // 
            this.enter_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_adress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_adress.Location = new System.Drawing.Point(260, 386);
            this.enter_adress.Margin = new System.Windows.Forms.Padding(4);
            this.enter_adress.Name = "enter_adress";
            this.enter_adress.Size = new System.Drawing.Size(1567, 26);
            this.enter_adress.TabIndex = 9;
            this.enter_adress.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // enter_country
            // 
            this.enter_country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_country.Location = new System.Drawing.Point(260, 352);
            this.enter_country.Margin = new System.Windows.Forms.Padding(4);
            this.enter_country.Name = "enter_country";
            this.enter_country.Size = new System.Drawing.Size(1567, 26);
            this.enter_country.TabIndex = 8;
            this.enter_country.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // adress_text
            // 
            this.adress_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adress_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adress_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.adress_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adress_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_text.Location = new System.Drawing.Point(4, 386);
            this.adress_text.Margin = new System.Windows.Forms.Padding(4);
            this.adress_text.Name = "adress_text";
            this.adress_text.ReadOnly = true;
            this.adress_text.Size = new System.Drawing.Size(248, 19);
            this.adress_text.TabIndex = 7;
            this.adress_text.TabStop = false;
            this.adress_text.Text = "Adress";
            this.adress_text.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // enter_lastname
            // 
            this.enter_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_lastname.Location = new System.Drawing.Point(260, 318);
            this.enter_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.enter_lastname.Name = "enter_lastname";
            this.enter_lastname.Size = new System.Drawing.Size(1567, 26);
            this.enter_lastname.TabIndex = 5;
            this.enter_lastname.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // enter_name
            // 
            this.enter_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enter_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter_name.Location = new System.Drawing.Point(260, 250);
            this.enter_name.Margin = new System.Windows.Forms.Padding(4);
            this.enter_name.Name = "enter_name";
            this.enter_name.Size = new System.Drawing.Size(1567, 26);
            this.enter_name.TabIndex = 3;
            this.enter_name.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.02838F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.97162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.Name_text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastname_text, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.enter_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.enter_lastname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.country_text, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.adress_text, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.enter_country, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.enter_adress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.surname_text, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.enter_surname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.number_text, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.enter_number, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.email_text, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.enter_email, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.bankaccnum_text, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.enter_bankaccnum, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.login_text, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.enter_login, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.passward_text, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.enter_password, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.PrivacyNoteLb, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 13);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1853, 1038);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // Name_text
            // 
            this.Name_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_text.Location = new System.Drawing.Point(4, 250);
            this.Name_text.Margin = new System.Windows.Forms.Padding(4);
            this.Name_text.Name = "Name_text";
            this.Name_text.ReadOnly = true;
            this.Name_text.Size = new System.Drawing.Size(248, 19);
            this.Name_text.TabIndex = 0;
            this.Name_text.TabStop = false;
            this.Name_text.Text = "Name";
            this.Name_text.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lastname_text
            // 
            this.lastname_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lastname_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lastname_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_text.Location = new System.Drawing.Point(4, 318);
            this.lastname_text.Margin = new System.Windows.Forms.Padding(4);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.ReadOnly = true;
            this.lastname_text.Size = new System.Drawing.Size(248, 19);
            this.lastname_text.TabIndex = 2;
            this.lastname_text.TabStop = false;
            this.lastname_text.Text = "Last name\r\n";
            this.lastname_text.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // country_text
            // 
            this.country_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.country_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.country_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.country_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_text.Location = new System.Drawing.Point(4, 352);
            this.country_text.Margin = new System.Windows.Forms.Padding(4);
            this.country_text.Name = "country_text";
            this.country_text.ReadOnly = true;
            this.country_text.Size = new System.Drawing.Size(248, 19);
            this.country_text.TabIndex = 6;
            this.country_text.TabStop = false;
            this.country_text.Text = "Country\r\n\r\n";
            this.country_text.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // surname_text
            // 
            this.surname_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.surname_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.surname_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_text.Location = new System.Drawing.Point(4, 284);
            this.surname_text.Margin = new System.Windows.Forms.Padding(4);
            this.surname_text.Name = "surname_text";
            this.surname_text.ReadOnly = true;
            this.surname_text.Size = new System.Drawing.Size(248, 19);
            this.surname_text.TabIndex = 1;
            this.surname_text.TabStop = false;
            this.surname_text.Text = "Surname";
            this.surname_text.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1823, 238);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "\r\n\r\nRegistration";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // PrivacyNoteLb
            // 
            this.PrivacyNoteLb.AutoSize = true;
            this.PrivacyNoteLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrivacyNoteLb.Location = new System.Drawing.Point(259, 1018);
            this.PrivacyNoteLb.Name = "PrivacyNoteLb";
            this.PrivacyNoteLb.Size = new System.Drawing.Size(1569, 20);
            this.PrivacyNoteLb.TabIndex = 23;
            this.PrivacyNoteLb.TabStop = true;
            this.PrivacyNoteLb.Text = "что-то про защиту персональных данных";
            // 
            // RegWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 1038);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox lastname_text;
        private System.Windows.Forms.TextBox enter_name;
        private System.Windows.Forms.TextBox enter_lastname;
        private System.Windows.Forms.TextBox country_text;
        private System.Windows.Forms.TextBox adress_text;
        private System.Windows.Forms.TextBox enter_country;
        private System.Windows.Forms.TextBox enter_adress;
        private System.Windows.Forms.TextBox surname_text;
        private System.Windows.Forms.TextBox enter_surname;
        private System.Windows.Forms.TextBox number_text;
        private System.Windows.Forms.TextBox enter_number;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox enter_email;
        private System.Windows.Forms.TextBox bankaccnum_text;
        private System.Windows.Forms.TextBox enter_bankaccnum;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox enter_login;
        private System.Windows.Forms.TextBox passward_text;
        private System.Windows.Forms.TextBox enter_password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel PrivacyNoteLb;
    }
}
