namespace LabManagementApp
{
    partial class frmreport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_expriment = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtp_etime = new System.Windows.Forms.DateTimePicker();
            this.dtp_stime = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_edate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_sdate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sampleno = new System.Windows.Forms.TextBox();
            this.txt_technique = new System.Windows.Forms.TextBox();
            this.txt_projectno = new System.Windows.Forms.TextBox();
            this.txt_organization = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_visitorname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dg_report = new System.Windows.Forms.DataGridView();
            this.cms_edit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_exporttocsv = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_download = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dg_download = new System.Windows.Forms.DataGridView();
            this.cmd_donload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_search = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_download = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_exportcsv = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txt_searchprojdetails = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_expriment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).BeginInit();
            this.cms_edit.SuspendLayout();
            this.tab_download.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_download)).BeginInit();
            this.cmd_donload.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 593);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(883, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(109, 26);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab Management System";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_expriment);
            this.tabControl1.Controls.Add(this.tab_download);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 534);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_expriment
            // 
            this.tab_expriment.BackColor = System.Drawing.Color.White;
            this.tab_expriment.Controls.Add(this.groupBox1);
            this.tab_expriment.Controls.Add(this.panel3);
            this.tab_expriment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_expriment.Location = new System.Drawing.Point(4, 22);
            this.tab_expriment.Name = "tab_expriment";
            this.tab_expriment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_expriment.Size = new System.Drawing.Size(978, 508);
            this.tab_expriment.TabIndex = 0;
            this.tab_expriment.Text = " Expriment ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expriment Info";
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(778, 133);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(179, 23);
            this.btn_insert.TabIndex = 16;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(778, 204);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(179, 23);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(778, 166);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(179, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.MistyRose;
            this.panel6.Controls.Add(this.lbl_msg);
            this.panel6.Controls.Add(this.btn_browse);
            this.panel6.Controls.Add(this.txt_filepath);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(708, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 107);
            this.panel6.TabIndex = 9;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(2, 90);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(258, 13);
            this.lbl_msg.TabIndex = 16;
            this.lbl_msg.Text = "Please Click on INSERT button to add New ";
            this.lbl_msg.Visible = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_browse.Location = new System.Drawing.Point(68, 58);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(179, 23);
            this.btn_browse.TabIndex = 15;
            this.btn_browse.Text = "BROWSE";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_filepath
            // 
            this.txt_filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filepath.Location = new System.Drawing.Point(67, 28);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.ReadOnly = true;
            this.txt_filepath.Size = new System.Drawing.Size(191, 21);
            this.txt_filepath.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
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
            this.panel5.Controls.Add(this.dtp_etime);
            this.panel5.Controls.Add(this.dtp_stime);
            this.panel5.Controls.Add(this.txt_phone);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txt_email);
            this.panel5.Controls.Add(this.txt_description);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dtp_edate);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dtp_sdate);
            this.panel5.Location = new System.Drawing.Point(363, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 208);
            this.panel5.TabIndex = 8;
            // 
            // dtp_etime
            // 
            this.dtp_etime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_etime.Location = new System.Drawing.Point(236, 41);
            this.dtp_etime.Name = "dtp_etime";
            this.dtp_etime.ShowUpDown = true;
            this.dtp_etime.Size = new System.Drawing.Size(95, 21);
            this.dtp_etime.TabIndex = 10;
            this.dtp_etime.Value = new System.DateTime(2022, 9, 27, 0, 0, 0, 0);
            // 
            // dtp_stime
            // 
            this.dtp_stime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_stime.Location = new System.Drawing.Point(236, 8);
            this.dtp_stime.Name = "dtp_stime";
            this.dtp_stime.ShowUpDown = true;
            this.dtp_stime.Size = new System.Drawing.Size(95, 21);
            this.dtp_stime.TabIndex = 8;
            this.dtp_stime.Value = new System.DateTime(2022, 9, 27, 0, 0, 0, 0);
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Location = new System.Drawing.Point(110, 180);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(206, 21);
            this.txt_phone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(110, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 21);
            this.txt_email.TabIndex = 12;
            // 
            // txt_description
            // 
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Location = new System.Drawing.Point(109, 71);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(206, 69);
            this.txt_description.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Start Time";
            // 
            // dtp_edate
            // 
            this.dtp_edate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_edate.Location = new System.Drawing.Point(109, 40);
            this.dtp_edate.Name = "dtp_edate";
            this.dtp_edate.Size = new System.Drawing.Size(116, 21);
            this.dtp_edate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "End Time";
            // 
            // dtp_sdate
            // 
            this.dtp_sdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_sdate.Location = new System.Drawing.Point(109, 9);
            this.dtp_sdate.Name = "dtp_sdate";
            this.dtp_sdate.Size = new System.Drawing.Size(116, 21);
            this.dtp_sdate.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_sampleno);
            this.panel4.Controls.Add(this.txt_technique);
            this.panel4.Controls.Add(this.txt_projectno);
            this.panel4.Controls.Add(this.txt_organization);
            this.panel4.Controls.Add(this.txt_name);
            this.panel4.Controls.Add(this.txt_visitorname);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(6, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 208);
            this.panel4.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "No Of Sample ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(32, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "Technique";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 12;
            this.label17.Text = "Project Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Organization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Visitor Name";
            // 
            // txt_sampleno
            // 
            this.txt_sampleno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sampleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sampleno.Location = new System.Drawing.Point(118, 176);
            this.txt_sampleno.Name = "txt_sampleno";
            this.txt_sampleno.Size = new System.Drawing.Size(206, 21);
            this.txt_sampleno.TabIndex = 6;
            // 
            // txt_technique
            // 
            this.txt_technique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_technique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_technique.Location = new System.Drawing.Point(118, 143);
            this.txt_technique.Name = "txt_technique";
            this.txt_technique.Size = new System.Drawing.Size(206, 21);
            this.txt_technique.TabIndex = 5;
            // 
            // txt_projectno
            // 
            this.txt_projectno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_projectno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_projectno.Location = new System.Drawing.Point(118, 110);
            this.txt_projectno.Name = "txt_projectno";
            this.txt_projectno.Size = new System.Drawing.Size(206, 21);
            this.txt_projectno.TabIndex = 4;
            // 
            // txt_organization
            // 
            this.txt_organization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_organization.Location = new System.Drawing.Point(118, 44);
            this.txt_organization.Name = "txt_organization";
            this.txt_organization.Size = new System.Drawing.Size(206, 21);
            this.txt_organization.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(118, 11);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 21);
            this.txt_name.TabIndex = 1;
            // 
            // txt_visitorname
            // 
            this.txt_visitorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_visitorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visitorname.Location = new System.Drawing.Point(118, 77);
            this.txt_visitorname.Name = "txt_visitorname";
            this.txt_visitorname.Size = new System.Drawing.Size(206, 21);
            this.txt_visitorname.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dg_report);
            this.panel3.Location = new System.Drawing.Point(6, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 251);
            this.panel3.TabIndex = 1;
            // 
            // dg_report
            // 
            this.dg_report.AllowUserToAddRows = false;
            this.dg_report.AllowUserToDeleteRows = false;
            this.dg_report.AllowUserToResizeColumns = false;
            this.dg_report.AllowUserToResizeRows = false;
            this.dg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_report.ContextMenuStrip = this.cms_edit;
            this.dg_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_report.Location = new System.Drawing.Point(0, 0);
            this.dg_report.MultiSelect = false;
            this.dg_report.Name = "dg_report";
            this.dg_report.ReadOnly = true;
            this.dg_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_report.ShowCellErrors = false;
            this.dg_report.ShowEditingIcon = false;
            this.dg_report.ShowRowErrors = false;
            this.dg_report.Size = new System.Drawing.Size(973, 251);
            this.dg_report.TabIndex = 0;
            // 
            // cms_edit
            // 
            this.cms_edit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_edit,
            this.tsm_addnew,
            this.tsm_exporttocsv});
            this.cms_edit.Name = "cms_edit";
            this.cms_edit.Size = new System.Drawing.Size(146, 70);
            // 
            // tsm_edit
            // 
            this.tsm_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsm_edit.Image")));
            this.tsm_edit.Name = "tsm_edit";
            this.tsm_edit.Size = new System.Drawing.Size(145, 22);
            this.tsm_edit.Text = "Edit";
            this.tsm_edit.Click += new System.EventHandler(this.tsm_edit_Click);
            // 
            // tsm_addnew
            // 
            this.tsm_addnew.Image = ((System.Drawing.Image)(resources.GetObject("tsm_addnew.Image")));
            this.tsm_addnew.Name = "tsm_addnew";
            this.tsm_addnew.Size = new System.Drawing.Size(145, 22);
            this.tsm_addnew.Text = "Add New";
            this.tsm_addnew.Click += new System.EventHandler(this.tsm_addnew_Click);
            // 
            // tsm_exporttocsv
            // 
            this.tsm_exporttocsv.Image = ((System.Drawing.Image)(resources.GetObject("tsm_exporttocsv.Image")));
            this.tsm_exporttocsv.Name = "tsm_exporttocsv";
            this.tsm_exporttocsv.Size = new System.Drawing.Size(145, 22);
            this.tsm_exporttocsv.Text = "Export to CSV";
            this.tsm_exporttocsv.Click += new System.EventHandler(this.tsm_exporttocsv_Click);
            // 
            // tab_download
            // 
            this.tab_download.Controls.Add(this.panel8);
            this.tab_download.Controls.Add(this.panel7);
            this.tab_download.Location = new System.Drawing.Point(4, 22);
            this.tab_download.Name = "tab_download";
            this.tab_download.Padding = new System.Windows.Forms.Padding(3);
            this.tab_download.Size = new System.Drawing.Size(978, 508);
            this.tab_download.TabIndex = 1;
            this.tab_download.Text = "Dowonload Report";
            this.tab_download.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dg_download.ContextMenuStrip = this.cmd_donload;
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
            // cmd_donload
            // 
            this.cmd_donload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_search,
            this.tsm_download,
            this.tsm_exportcsv});
            this.cmd_donload.Name = "cmd_donload";
            this.cmd_donload.Size = new System.Drawing.Size(149, 70);
            // 
            // tsm_search
            // 
            this.tsm_search.Image = ((System.Drawing.Image)(resources.GetObject("tsm_search.Image")));
            this.tsm_search.Name = "tsm_search";
            this.tsm_search.Size = new System.Drawing.Size(148, 22);
            this.tsm_search.Text = "Search";
            this.tsm_search.Click += new System.EventHandler(this.tsm_search_Click);
            // 
            // tsm_download
            // 
            this.tsm_download.Image = ((System.Drawing.Image)(resources.GetObject("tsm_download.Image")));
            this.tsm_download.Name = "tsm_download";
            this.tsm_download.Size = new System.Drawing.Size(148, 22);
            this.tsm_download.Text = "Download";
            this.tsm_download.Click += new System.EventHandler(this.tsm_download_Click);
            // 
            // tsm_exportcsv
            // 
            this.tsm_exportcsv.Image = ((System.Drawing.Image)(resources.GetObject("tsm_exportcsv.Image")));
            this.tsm_exportcsv.Name = "tsm_exportcsv";
            this.tsm_exportcsv.Size = new System.Drawing.Size(148, 22);
            this.tsm_exportcsv.Text = "Export To CSV";
            this.tsm_exportcsv.Click += new System.EventHandler(this.tsm_exportcsv_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(972, 502);
            this.panel7.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.btn_exportcsv);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.btn_download);
            this.panel10.Location = new System.Drawing.Point(732, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(231, 114);
            this.panel10.TabIndex = 1;
            // 
            // btn_exportcsv
            // 
            this.btn_exportcsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportcsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exportcsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportcsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportcsv.Location = new System.Drawing.Point(74, 80);
            this.btn_exportcsv.Name = "btn_exportcsv";
            this.btn_exportcsv.Size = new System.Drawing.Size(110, 23);
            this.btn_exportcsv.TabIndex = 15;
            this.btn_exportcsv.Text = "EXPORT ";
            this.btn_exportcsv.UseVisualStyleBackColor = false;
            this.btn_exportcsv.Click += new System.EventHandler(this.btn_exportcsv_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(11, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Download Expriment Report";
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(74, 34);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(110, 23);
            this.btn_download.TabIndex = 13;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
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
            this.panel9.Controls.Add(this.txt_searchprojdetails);
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
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_searchclear
            // 
            this.btn_searchclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_searchclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchclear.Location = new System.Drawing.Point(371, 79);
            this.btn_searchclear.Name = "btn_searchclear";
            this.btn_searchclear.Size = new System.Drawing.Size(110, 23);
            this.btn_searchclear.TabIndex = 15;
            this.btn_searchclear.Text = "CLEAR";
            this.btn_searchclear.UseVisualStyleBackColor = false;
            this.btn_searchclear.Click += new System.EventHandler(this.btn_searchclear_Click);
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
            this.btn_search.Location = new System.Drawing.Point(370, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_searchstratdate
            // 
            this.dtp_searchstratdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_searchstratdate.Location = new System.Drawing.Point(136, 85);
            this.dtp_searchstratdate.Name = "dtp_searchstratdate";
            this.dtp_searchstratdate.Size = new System.Drawing.Size(206, 20);
            this.dtp_searchstratdate.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Expriment Date";
            // 
            // txt_searchprojdetails
            // 
            this.txt_searchprojdetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchprojdetails.Location = new System.Drawing.Point(136, 59);
            this.txt_searchprojdetails.Name = "txt_searchprojdetails";
            this.txt_searchprojdetails.Size = new System.Drawing.Size(206, 20);
            this.txt_searchprojdetails.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Project Details";
            // 
            // txt_searchname
            // 
            this.txt_searchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchname.Location = new System.Drawing.Point(135, 33);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(206, 20);
            this.txt_searchname.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name";
            // 
            // frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1023, 631);
            this.Name = "frmreport";
            this.Text = "Report LMS";
            this.Load += new System.EventHandler(this.frmreport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_expriment.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).EndInit();
            this.cms_edit.ResumeLayout(false);
            this.tab_download.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_download)).EndInit();
            this.cmd_donload.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_expriment;
        private System.Windows.Forms.TabPage tab_download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_report;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_searchstratdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_searchprojdetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip cms_edit;
        private System.Windows.Forms.ToolStripMenuItem tsm_edit;
        private System.Windows.Forms.ToolStripMenuItem tsm_exporttocsv;
        private System.Windows.Forms.DataGridView dg_download;
        private System.Windows.Forms.ContextMenuStrip cmd_donload;
        private System.Windows.Forms.ToolStripMenuItem tsm_search;
        private System.Windows.Forms.ToolStripMenuItem tsm_download;
        private System.Windows.Forms.ToolStripMenuItem tsm_exportcsv;
        private System.Windows.Forms.Button btn_searchclear;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_exportcsv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_refresh;
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
        private System.Windows.Forms.TextBox txt_visitorname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TextBox txt_projectno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_organization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_sampleno;
        private System.Windows.Forms.TextBox txt_technique;
        private System.Windows.Forms.DateTimePicker dtp_etime;
        private System.Windows.Forms.DateTimePicker dtp_stime;
        private System.Windows.Forms.ToolStripMenuItem tsm_addnew;
        private System.Windows.Forms.Label lbl_msg;
    }
}