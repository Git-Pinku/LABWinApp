namespace LabManagementApp
{
    partial class frmnew
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_expriment = new System.Windows.Forms.TabPage();
            this.dg_report = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtp_edate = new System.Windows.Forms.DateTimePicker();
            this.dtp_sdate = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_expname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_download = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dg_download = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_exportcsv = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_searchclear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_searchstratdate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_searchexpname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_expriment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_download.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_download)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_expriment);
            this.tabControl1.Controls.Add(this.tab_download);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 576);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_expriment
            // 
            this.tab_expriment.BackColor = System.Drawing.Color.White;
            this.tab_expriment.Controls.Add(this.dg_report);
            this.tab_expriment.Controls.Add(this.groupBox1);
            this.tab_expriment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_expriment.Location = new System.Drawing.Point(4, 22);
            this.tab_expriment.Name = "tab_expriment";
            this.tab_expriment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expriment.Size = new System.Drawing.Size(1248, 550);
            this.tab_expriment.TabIndex = 0;
            this.tab_expriment.Text = " Expriment ";
            // 
            // dg_report
            // 
            this.dg_report.AllowUserToAddRows = false;
            this.dg_report.AllowUserToDeleteRows = false;
            this.dg_report.AllowUserToResizeColumns = false;
            this.dg_report.AllowUserToResizeRows = false;
            this.dg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_report.Location = new System.Drawing.Point(12, 340);
            this.dg_report.MultiSelect = false;
            this.dg_report.Name = "dg_report";
            this.dg_report.ReadOnly = true;
            this.dg_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_report.ShowCellErrors = false;
            this.dg_report.ShowEditingIcon = false;
            this.dg_report.ShowRowErrors = false;
            this.dg_report.Size = new System.Drawing.Size(1228, 251);
            this.dg_report.TabIndex = 0;
            this.dg_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_report_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expriment Info";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(772, 127);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(179, 23);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(772, 200);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(179, 23);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(772, 160);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(179, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MistyRose;
            this.panel6.Controls.Add(this.btn_browse);
            this.panel6.Controls.Add(this.txt_filepath);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(711, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 214);
            this.panel6.TabIndex = 9;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browse.Location = new System.Drawing.Point(61, 69);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(179, 23);
            this.btn_browse.TabIndex = 9;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            // 
            // txt_filepath
            // 
            this.txt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filepath.Location = new System.Drawing.Point(60, 28);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.ReadOnly = true;
            this.txt_filepath.Size = new System.Drawing.Size(179, 21);
            this.txt_filepath.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "File Path:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(51, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Upload Expriment Report";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.dtp_edate);
            this.panel5.Controls.Add(this.dtp_sdate);
            this.panel5.Controls.Add(this.txt_description);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txt_expname);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(363, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 208);
            this.panel5.TabIndex = 8;
            // 
            // dtp_edate
            // 
            this.dtp_edate.Location = new System.Drawing.Point(111, 86);
            this.dtp_edate.Name = "dtp_edate";
            this.dtp_edate.Size = new System.Drawing.Size(206, 21);
            this.dtp_edate.TabIndex = 9;
            // 
            // dtp_sdate
            // 
            this.dtp_sdate.Location = new System.Drawing.Point(110, 52);
            this.dtp_sdate.Name = "dtp_sdate";
            this.dtp_sdate.Size = new System.Drawing.Size(206, 21);
            this.dtp_sdate.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Location = new System.Drawing.Point(109, 124);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(206, 69);
            this.txt_description.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "End Date";
            // 
            // txt_expname
            // 
            this.txt_expname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_expname.Location = new System.Drawing.Point(109, 15);
            this.txt_expname.Name = "txt_expname";
            this.txt_expname.Size = new System.Drawing.Size(206, 21);
            this.txt_expname.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Expriment Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.txt_address);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_phone);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_email);
            this.panel4.Controls.Add(this.txt_name);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(6, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 208);
            this.panel4.TabIndex = 0;
            // 
            // txt_address
            // 
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Location = new System.Drawing.Point(109, 124);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(206, 69);
            this.txt_address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Location = new System.Drawing.Point(109, 85);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(206, 21);
            this.txt_phone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone No";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(109, 49);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 21);
            this.txt_email.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(109, 15);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 21);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // tab_download
            // 
            this.tab_download.Controls.Add(this.panel8);
            this.tab_download.Controls.Add(this.panel7);
            this.tab_download.Location = new System.Drawing.Point(4, 22);
            this.tab_download.Name = "tab_download";
            this.tab_download.Padding = new System.Windows.Forms.Padding(3);
            this.tab_download.Size = new System.Drawing.Size(1248, 550);
            this.tab_download.TabIndex = 1;
            this.tab_download.Text = "Dowonload Report";
            this.tab_download.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dg_download);
            this.panel8.Location = new System.Drawing.Point(14, 155);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(952, 347);
            this.panel8.TabIndex = 1;
            // 
            // dg_download
            // 
            this.dg_download.AllowUserToAddRows = false;
            this.dg_download.AllowUserToDeleteRows = false;
            this.dg_download.AllowUserToResizeColumns = false;
            this.dg_download.AllowUserToResizeRows = false;
            this.dg_download.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_download.Location = new System.Drawing.Point(0, 0);
            this.dg_download.MultiSelect = false;
            this.dg_download.Name = "dg_download";
            this.dg_download.ReadOnly = true;
            this.dg_download.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_download.ShowCellErrors = false;
            this.dg_download.ShowEditingIcon = false;
            this.dg_download.ShowRowErrors = false;
            this.dg_download.Size = new System.Drawing.Size(952, 347);
            this.dg_download.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1242, 544);
            this.panel7.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.btn_exportcsv);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.btn_download);
            this.panel10.Location = new System.Drawing.Point(732, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(216, 114);
            this.panel10.TabIndex = 1;
            // 
            // btn_exportcsv
            // 
            this.btn_exportcsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exportcsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportcsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportcsv.Location = new System.Drawing.Point(59, 80);
            this.btn_exportcsv.Name = "btn_exportcsv";
            this.btn_exportcsv.Size = new System.Drawing.Size(110, 23);
            this.btn_exportcsv.TabIndex = 15;
            this.btn_exportcsv.Text = "EXPORT ";
            this.btn_exportcsv.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(3, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Download Expriment Report";
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(59, 34);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(110, 23);
            this.btn_download.TabIndex = 13;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.btn_refresh);
            this.panel9.Controls.Add(this.btn_searchclear);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.btn_search);
            this.panel9.Controls.Add(this.dtp_searchstratdate);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.txt_searchexpname);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.txt_searchname);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(704, 114);
            this.panel9.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(582, 48);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(110, 23);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // btn_searchclear
            // 
            this.btn_searchclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_searchclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchclear.Location = new System.Drawing.Point(347, 79);
            this.btn_searchclear.Name = "btn_searchclear";
            this.btn_searchclear.Size = new System.Drawing.Size(110, 23);
            this.btn_searchclear.TabIndex = 15;
            this.btn_searchclear.Text = "CLEAR";
            this.btn_searchclear.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(271, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Search Expriment Report";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(346, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // dtp_searchstratdate
            // 
            this.dtp_searchstratdate.Location = new System.Drawing.Point(112, 85);
            this.dtp_searchstratdate.Name = "dtp_searchstratdate";
            this.dtp_searchstratdate.Size = new System.Drawing.Size(206, 20);
            this.dtp_searchstratdate.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Expriment Date";
            // 
            // txt_searchexpname
            // 
            this.txt_searchexpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchexpname.Location = new System.Drawing.Point(112, 59);
            this.txt_searchexpname.Name = "txt_searchexpname";
            this.txt_searchexpname.Size = new System.Drawing.Size(206, 20);
            this.txt_searchexpname.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Expriment Name";
            // 
            // txt_searchname
            // 
            this.txt_searchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchname.Location = new System.Drawing.Point(111, 33);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(206, 20);
            this.txt_searchname.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name";
            // 
            // frmnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmnew";
            this.Text = "frmnew";
            this.Load += new System.EventHandler(this.frmnew_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_expriment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_download.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_download)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_expriment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtp_edate;
        private System.Windows.Forms.DateTimePicker dtp_sdate;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_expname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab_download;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dg_download;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_exportcsv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_searchclear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_searchstratdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_searchexpname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dg_report;
    }
}