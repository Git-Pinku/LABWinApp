using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LabManagementApp
{
    public partial class frmLogin : Form
    {

        clsdb objdb; 

        public frmLogin()
        {
            InitializeComponent();
            objdb = new clsdb();
        }
        private void Clear()
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();   
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username;
            string password;
            try
            {
                if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
                    MessageBox.Show("Please enter vaild username and password", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string dbfilepath = Path.GetDirectoryName(Application.ExecutablePath) + @"\labdb.db";
                    if (!File.Exists(dbfilepath))
                    {
                        MessageBox.Show("Unable to Login Please contact to Administrator!!", "DB Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear();
                        return;
                    }
                    DataTable dt = new DataTable();
                    dt = objdb.GetLoginInfo();
                    bool isvaliduser = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        username = dt.Rows[i]["username"].ToString().ToLower().Trim();
                        password = dt.Rows[i]["userpassword"].ToString().ToLower().Trim();
                        if (username.Equals(txt_username.Text.ToLower().Trim()) && password.Equals(txt_password.Text.ToLower().Trim()))
                        {
                            //login done here
                            isvaliduser = true;
                            this.Hide();
                            var frm = new frmreport();
                            frm.Closed += (s, args) => this.Close();
                            frm.Show();
                            break;
                        }
                    }
                    if (isvaliduser == false)
                    {
                        MessageBox.Show("Please enter vaild username and password", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }


        }

    }
}
