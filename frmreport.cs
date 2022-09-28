using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LabManagementApp
{
    public partial class frmreport : Form
    {
        public frmreport()
        {
            InitializeComponent();
        }
        Int32 reportid;
        string reportfilename = string.Empty;
        string dbsavefilename = string.Empty;
        string oldreportFile;
        clsdb objdb = new clsdb();

        private void frmreport_Load(object sender, EventArgs e)
        {
            

            dtp_stime.Format = DateTimePickerFormat.Custom;
            dtp_stime.CustomFormat = "tt hh:mm:ss";
            dtp_etime.Format = DateTimePickerFormat.Custom;
            dtp_etime.CustomFormat = "tt hh:mm:ss";
            dtp_stime.Text = DateTime.Now.TimeOfDay.ToString();
            dtp_etime.Text = DateTime.Now.TimeOfDay.ToString();
            using (DataTable dt = objdb.GetExprimentReports())
            {
                try
                {
                    dg_report.AutoGenerateColumns = false;
                    dg_report.ColumnCount = 15;
                    dg_report.Columns[0].HeaderText = "Report No";
                    dg_report.Columns[0].DataPropertyName = "reportid";
                    //dg_report.Columns[0].Width = 100;
                    dg_report.Columns[0].Visible = false;

                    dg_report.Columns[1].HeaderText = "Name";
                    dg_report.Columns[1].DataPropertyName = "name";
                    //dg_report.Columns[1].Width = 125;

                    dg_report.Columns[2].HeaderText = "Organization";
                    dg_report.Columns[2].DataPropertyName = "orgname";
                   // dg_report.Columns[2].Width = 100;

                    dg_report.Columns[3].HeaderText = "Visitor Name";
                    dg_report.Columns[3].DataPropertyName = "visitorname";
                    dg_report.Columns[3].Width = 150;

                    dg_report.Columns[4].HeaderText = "Project Details";
                    dg_report.Columns[4].DataPropertyName = "projectno";
                    dg_report.Columns[4].Width = 150;

                    dg_report.Columns[5].HeaderText = "Technique";
                    dg_report.Columns[5].DataPropertyName = "technique";
                    

                    dg_report.Columns[6].HeaderText = "No Of Sample";
                    dg_report.Columns[6].DataPropertyName = "sampleno";
                    dg_report.Columns[6].Width = 150;

                    dg_report.Columns[7].HeaderText = "Start Time";
                    dg_report.Columns[7].DataPropertyName = "startdate";

                    dg_report.Columns[8].HeaderText = "End Time";
                    dg_report.Columns[8].DataPropertyName = "enddate";

                    dg_report.Columns[9].HeaderText = "Description";
                    dg_report.Columns[9].DataPropertyName = "desc";
                    

                    dg_report.Columns[10].HeaderText = "Email";
                    dg_report.Columns[10].DataPropertyName = "email";

                    dg_report.Columns[11].HeaderText = "Phone";
                    dg_report.Columns[11].DataPropertyName = "phone";



                    dg_report.Columns[12].HeaderText = "Report File";
                    dg_report.Columns[12].DataPropertyName = "reportfilename";
                    //dg_report.Columns[9].Width = 170;

                    dg_report.Columns[13].Visible = false;
                    dg_report.Columns[13].HeaderText = "File Path";
                    dg_report.Columns[13].DataPropertyName = "filepath";


                    dg_report.Columns[14].Visible = false;
                    dg_report.Columns[14].HeaderText = "isactive";
                    dg_report.Columns[14].DataPropertyName = "isactive";

                    dg_report.DataSource = dt;
                }
                catch (Exception ex)
                {
                    objdb.WriteLog();
                    objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
                }
            }

            // LoadDownloadGrid();
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Browse The Files",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txt_filepath.Text = openFile.FileName;
                    reportfilename = Path.GetFileName(txt_filepath.Text.Trim());
                }

            }
            catch (Exception ex)
            {
                objdb.WriteLog("Unable to browse file");
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_visitorname.Text))
                {
                    MessageBox.Show("Please enter vaild Name and Technique", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrWhiteSpace(txt_projectno.Text) || string.IsNullOrWhiteSpace(txt_sampleno.Text))
                {
                    MessageBox.Show("Please enter vaild Project Details and No Of Sample", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string dirpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\LMSreport";
                    if (!Directory.Exists(dirpath))
                        Directory.CreateDirectory(dirpath);

                    string name = txt_name.Text.Trim();
                    string email = txt_email.Text.Trim();
                    string phone = txt_phone.Text.Trim();
                    string visitorname = txt_visitorname.Text.Trim();
                    string organization = txt_organization.Text.Trim();
                    string projectno = txt_projectno.Text.Trim();
                    string technique = txt_technique.Text.Trim();
                    string sampleno = txt_sampleno.Text.Trim();
                    string sdate = dtp_sdate.Text.Trim() + dtp_stime.Text.Trim();
                    string edate = dtp_edate.Text.Trim() + dtp_etime.Text.Trim();
                    string desc = txt_description.Text.Trim();
                    string filepath = dirpath.Trim();
                    string filename;
                    if (!string.IsNullOrEmpty(txt_filepath.Text))
                        filename = DateTime.Now.Millisecond.ToString() + "_" + reportfilename;
                    else
                        filename = string.Empty;
                    if (IsTimesSlotFree(sdate, edate) == false)
                    {
                        MessageBox.Show("Time Slots Are Not Available", "Time Slot ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dg_report.DataSource = objdb.GetExprimentReports();
                        return;
                    }
                    int isactive = 1;//defult value is 1 when want to not show in grid set 0
                    bool IsInsert = objdb.InsertExprimentReport(name, organization, visitorname, projectno, technique, sampleno, sdate, edate, desc, email, phone, filename, filepath, isactive);
                    if (IsInsert == true)
                    {
                        if (!string.IsNullOrEmpty(txt_filepath.Text))
                            File.Copy(txt_filepath.Text.Trim(), filepath + "\\" + filename, true);
                        clearAll();
                        lbl_msg.Visible = false;
                        dg_report.DataSource = objdb.GetExprimentReports();
                        MessageBox.Show("Record added successfully !", "Info Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Unable to add record Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog("Unable to Insert Data to DB");
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
        }
        private bool IsTimesSlotFree(string startime,string endtime)
        {
            bool isTime = true;
            DataTable dtfinal=new DataTable();
            try
            {
                DataTable dt = objdb.GetExprimentReports();
                 DataTable dttime = new DataTable();
                dttime.Columns.Add("sdate", typeof(string));
                dttime.Columns.Add("stime", typeof(string));
                dttime.Columns.Add("edate", typeof(string));
                dttime.Columns.Add("etime", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    string sdatetime = dr["startdate"].ToString();
                    string edatetime = dr["enddate"].ToString();
                    if (!string.IsNullOrEmpty(sdatetime) && !string.IsNullOrEmpty(edatetime))
                        dttime.Rows.Add(sdatetime.Substring(0, 10), sdatetime.Substring(10, 11), edatetime.Substring(0, 10), edatetime.Substring(10, 11));
                }
                var rows_all = dttime.AsEnumerable()
                               .Where(r => r.Field<string>("sdate").Equals(startime.Substring(0, 10)) &&
                               r.Field<string>("edate").Equals(endtime.Substring(0, 10)));
                if (rows_all.Any())
                    dtfinal = rows_all.CopyToDataTable();
                StringBuilder sb = new StringBuilder();
                foreach (DataRow d in dtfinal.Rows)
                {
                    string p = d["stime"].ToString();
                    DateTime tsdb = DateTime.Parse(d["sdate"].ToString() + d["stime"].ToString());
                    DateTime tsin = DateTime.Parse(startime.ToString());
                    DateTime tedb = DateTime.Parse(d["edate"].ToString() +d["etime"].ToString());
                    DateTime tein = DateTime.Parse(endtime.ToString());
                    /*  -1  if  t1 is shorter than t2.
                       0   if  t1 is equal to t2.
                       1   if  t1 is longer than t2.*/
                    int sdateval = DateTime.Compare(tsin, tsdb);
                    int edateval = DateTime.Compare(tein, tedb);
                    int sedateval = DateTime.Compare(tsin, tedb);
                    
                    if (sdateval == 1 && edateval == -1)
                    {
                        sb.AppendLine("NOT available slot");
                        isTime = false;
                        break;
                    }
                    else if (sdateval == 0 && edateval==0)
                    {
                        sb.AppendLine("NOT available slot");
                        isTime = false;
                        break;
                    }
                    else if (sdateval == 1 && edateval == 1 && sedateval == -1)
                    {
                        sb.AppendLine("NOT available slot");
                        isTime = false;
                        break;
                    }
                    else if (sdateval == 1 && edateval == 0 && sedateval == -1)
                    {
                        sb.AppendLine("NOT available slot");
                        isTime = false;
                        break;
                    }
                    else if (sdateval == 0 && edateval == 1 && sedateval == -1)
                    {
                        sb.AppendLine("NOT available slot");
                        isTime = false;
                        break;
                    }


                    else
                    {
                        sb.AppendLine("available slot");
                    }

                }

                string h = sb.ToString();
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message);
                isTime = true;
            }
            return isTime;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearAll();
            btn_insert.Enabled = true;
            btn_update.Enabled = false;
        }

        private void tsm_addnew_Click(object sender, EventArgs e)
        {
            try
            {
                clearAll();
                if (dg_report.DataSource != null && dg_report.SelectedRows.Count > 0)
                {
                    lbl_msg.Visible = true;
                    txt_name.Text = dg_report.SelectedRows[0].Cells[1].Value.ToString();
                    txt_organization.Text = dg_report.SelectedRows[0].Cells[2].Value.ToString();
                    txt_visitorname.Text = dg_report.SelectedRows[0].Cells[3].Value.ToString();
                    txt_projectno.Text = dg_report.SelectedRows[0].Cells[4].Value.ToString();
                    txt_technique.Text = dg_report.SelectedRows[0].Cells[5].Value.ToString();
                    txt_sampleno.Text = dg_report.SelectedRows[0].Cells[6].Value.ToString();
                    //dtp_stime.Text = dg_report.SelectedRows[0].Cells[7].Value.ToString().Substring(10, 11);
                   // dtp_etime.Text = dg_report.SelectedRows[0].Cells[8].Value.ToString().Substring(10, 11);
                   // dtp_sdate.Text = dg_report.SelectedRows[0].Cells[7].Value.ToString();
                   // dtp_edate.Text = dg_report.SelectedRows[0].Cells[8].Value.ToString();
                    txt_description.Text = dg_report.SelectedRows[0].Cells[9].Value.ToString();
                    txt_email.Text = dg_report.SelectedRows[0].Cells[10].Value.ToString();
                    txt_phone.Text = dg_report.SelectedRows[0].Cells[11].Value.ToString();
                    reportid = Convert.ToInt32(dg_report.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    oldreportFile = dg_report.SelectedRows[0].Cells[13].Value.ToString();
                    btn_insert.Enabled = true;
                    btn_update.Enabled = false;
                    lbl_msg.Text = "Please Click on INSERT button to add New";
                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
            }

        }
        private void tsm_edit_Click(object sender, EventArgs e)
        {
            try
            {
                clearAll();
                
                if (dg_report.DataSource != null && dg_report.SelectedRows.Count > 0)
                {
                    lbl_msg.Visible = true;
                    txt_name.Text = dg_report.SelectedRows[0].Cells[1].Value.ToString();
                    txt_organization.Text = dg_report.SelectedRows[0].Cells[2].Value.ToString();
                    txt_visitorname.Text = dg_report.SelectedRows[0].Cells[3].Value.ToString();
                    txt_projectno.Text = dg_report.SelectedRows[0].Cells[4].Value.ToString();
                    txt_technique.Text = dg_report.SelectedRows[0].Cells[5].Value.ToString();
                    txt_sampleno.Text = dg_report.SelectedRows[0].Cells[6].Value.ToString();
                    dtp_stime.Text = dg_report.SelectedRows[0].Cells[7].Value.ToString().Substring(10, 11);
                    dtp_etime.Text = dg_report.SelectedRows[0].Cells[8].Value.ToString().Substring(10, 11);
                    dtp_sdate.Text = dg_report.SelectedRows[0].Cells[7].Value.ToString();
                    dtp_edate.Text = dg_report.SelectedRows[0].Cells[8].Value.ToString();
                    txt_description.Text = dg_report.SelectedRows[0].Cells[9].Value.ToString();
                    txt_email.Text = dg_report.SelectedRows[0].Cells[10].Value.ToString();
                    txt_phone.Text = dg_report.SelectedRows[0].Cells[11].Value.ToString();
                    oldreportFile = dg_report.SelectedRows[0].Cells[13].Value.ToString();
                    dbsavefilename = dg_report.SelectedRows[0].Cells[12].Value.ToString();
                    reportid = Convert.ToInt32(dg_report.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    btn_insert.Enabled = false;
                    btn_update.Enabled = true;
                    lbl_msg.Text = "Please Click on UPDATE button after edit";
                }
               
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
            }
        }
        private void tsm_exporttocsv_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                DataTable data = (DataTable)dg_report.DataSource;
                if (data.Rows.Count > 0)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Title = "Export To CSV";
                    string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                    saveFile.Filter = filter;
                    string filename;
                    saveFile.FileName = "Report_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveFile.FileName;
                        if (DataTableToCSV(data, filename) == true)
                            MessageBox.Show("Experiment report exported successfully", "Export report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
            }

        }
        private void tsm_download_Click(object sender, EventArgs e)
        {
            btn_download_Click(null, null);
        }
        private void tsm_exportcsv_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                DataTable data = (DataTable)dg_download.DataSource;
                if (dg_download.DataSource!=null && data.Rows.Count > 0)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Title = "Export To CSV";
                    string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                    saveFile.Filter = filter;
                    string filename;
                    saveFile.FileName = "Report_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveFile.FileName;
                        if (DataTableToCSV(data, filename) == true)
                            MessageBox.Show("Experiment report exported successfully", "Export report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
            }

        }
        private void tsm_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_download.SelectedRows.Count > 0)
                {
                    txt_searchname.Text = dg_download.SelectedRows[0].Cells[1].Value.ToString();
                    txt_searchprojdetails.Text = dg_download.SelectedRows[0].Cells[4].Value.ToString();
                    dtp_searchstratdate.Text = dg_download.SelectedRows[0].Cells[7].Value.ToString().Substring(0, 10);
                }

            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);

            }
        }

        private void clearAll()
        {
            txt_name.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_visitorname.Text = string.Empty;
            txt_organization.Text = string.Empty;
            txt_projectno.Text = string.Empty;
            txt_sampleno.Text = string.Empty;
            txt_technique.Text = string.Empty;
            dtp_sdate.Text = DateTime.Now.ToString();
            dtp_edate.Text = DateTime.Now.ToString();
            dtp_stime.Text = DateTime.Now.TimeOfDay.ToString();
            dtp_etime.Text = DateTime.Now.TimeOfDay.ToString();
            txt_description.Text = string.Empty;
            txt_filepath.Text = string.Empty;
            lbl_msg.Visible = false;
        }
        private void LoadDownloadGrid()
        {
            using (DataTable dt1 = objdb.GetExprimentReports())
            {
                try
                {
                    if (dg_download.RowCount == 0)
                    {
                        dg_download.DataSource = null;
                        dg_download.AutoGenerateColumns = false;
                        dg_download.ColumnCount = 15;
                        dg_download.Columns[0].HeaderText = "Report No";
                        dg_download.Columns[0].DataPropertyName = "reportid";
                       // dg_download.Columns[0].Width = 100;
                        dg_download.Columns[0].Visible = false;

                        dg_download.Columns[1].HeaderText = "Name";
                        dg_download.Columns[1].DataPropertyName = "name";
                       // dg_report.Columns[1].Width = 200;

                        dg_download.Columns[2].HeaderText = "Organization";
                        dg_download.Columns[2].DataPropertyName = "orgname";
                        // dg_download.Columns[2].Width = 200;

                        dg_download.Columns[3].HeaderText = "Visitor Name";
                        dg_download.Columns[3].DataPropertyName = "visitorname";
                        dg_download.Columns[3].Width = 150;

                        dg_download.Columns[4].HeaderText = "Project Details";
                        dg_download.Columns[4].DataPropertyName = "projectno";
                        dg_download.Columns[4].Width = 150;

                        dg_download.Columns[5].HeaderText = "Technique";
                        dg_download.Columns[5].DataPropertyName = "technique";
                        //dg_download.Columns[5].Width = 150;

                        dg_download.Columns[6].HeaderText = "No Of Sample";
                        dg_download.Columns[6].DataPropertyName = "sampleno";
                        dg_download.Columns[6].Width = 150;

                        dg_download.Columns[7].HeaderText = "Start Time";
                        dg_download.Columns[7].DataPropertyName = "startdate";

                        dg_download.Columns[8].HeaderText = "End Time";
                        dg_download.Columns[8].DataPropertyName = "enddate";

                        dg_download.Columns[9].HeaderText = "Description";
                        dg_download.Columns[9].DataPropertyName = "desc";
                        dg_download.Columns[9].Width = 150;

                        dg_download.Columns[10].HeaderText = "Email";
                        dg_download.Columns[10].DataPropertyName = "email";

                        dg_download.Columns[11].HeaderText = "Phone";
                        dg_download.Columns[11].DataPropertyName = "phone";

                        dg_download.Columns[12].HeaderText = "Report File";
                        dg_download.Columns[12].DataPropertyName = "reportfilename";
                        
                        dg_download.Columns[13].Visible = false;
                        dg_download.Columns[13].HeaderText = "File Path";
                        dg_download.Columns[13].DataPropertyName = "filepath";

                        dg_download.Columns[14].Visible = false;
                        dg_download.Columns[14].HeaderText = "isactive";
                        dg_download.Columns[14].DataPropertyName = "isactive";

                   }
                    dg_download.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    objdb.WriteLog();
                    objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
                }
           }
        }       
        private DataTable GetSerchData(string name, string project, string sdate)
        {
            DataTable selectedTable = null ;
            try
            {
                string seaech = string.Empty;
                DataTable dtsearch=objdb.GetExprimentReports();
                if (!string.IsNullOrEmpty(name) && sdate == DateTime.Now.Date.ToString("dd-MM-yyyy"))
                    seaech = "Name";
                else if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(project))
                    seaech = "Date";
                else if (!(string.IsNullOrEmpty(name) && (string.IsNullOrEmpty(project)) && (sdate == DateTime.Now.Date.ToString("dd-MM-yyyy"))))
                    seaech = "NameNproj";
                else if (!(string.IsNullOrEmpty(project)) && (string.IsNullOrEmpty(project) && (sdate == DateTime.Now.Date.ToString("dd-MM-yyyy"))))
                    seaech = "Proj";
                else
                    seaech = "ALL";

                switch (seaech)
	            {
                    case "Name":
                        var rows_name = dtsearch.AsEnumerable()
                                .Where(r => r.Field<string>("name").ToLower().Equals(name.ToLower()));
                if (rows_name.Any())
                   selectedTable=rows_name.CopyToDataTable();
                        break;
                    case"Date":
                         var rows_date = dtsearch.AsEnumerable()
                                .Where(r => r.Field<string>("startdate").Substring(0, 10).ToLower().Equals(sdate.ToLower()));
                         if (rows_date.Any())
                             selectedTable = rows_date.CopyToDataTable();
                        break;
                    case "Proj":
                        var rows_proj = dtsearch.AsEnumerable()
                               .Where(r => r.Field<string>("projectno").Substring(0, 10).ToLower().Equals(project.ToLower()));
                        if (rows_proj.Any())
                            selectedTable = rows_proj.CopyToDataTable();
                        break;

                    case"NameNproj":
                        var rows_nameproj = dtsearch.AsEnumerable()
                                .Where(r => r.Field<string>("name").ToLower().Equals(name.ToLower()) ||
                                       r.Field<string>("projectno").ToLower().Equals(project.ToLower()));
                if (rows_nameproj.Any())
                   selectedTable=rows_nameproj.CopyToDataTable();
                        break;
                    case"ALL":
                        var rows_all = dtsearch.AsEnumerable()
                                .Where(r => r.Field<string>("name").ToLower().Equals(name.ToLower()) ||
                                       r.Field<string>("projectno").ToLower().Equals(project.ToLower()) ||
                                       r.Field<string>("startdate").Substring(0, 10).ToLower().Equals(sdate.ToLower()));
                if (rows_all.Any())
                   selectedTable=rows_all.CopyToDataTable();
                        break;
		        default:
                        selectedTable=objdb.GetExprimentReports();
                        break;

	            }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return selectedTable;
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                if (tabControl1.SelectedIndex == 0)
                {
                    dg_report.DataSource = objdb.GetExprimentReports();
                    dtp_sdate.Text = DateTime.Now.ToString();
                    dtp_edate.Text = DateTime.Now.ToString();
                    dtp_stime.Text = DateTime.Now.TimeOfDay.ToString();
                    dtp_etime.Text = DateTime.Now.TimeOfDay.ToString();
                }
                if (tabControl1.SelectedIndex == 1)
                    LoadDownloadGrid();
            }
            catch (Exception ex)
            {
                objdb.WriteLog();
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
            }
        }
 

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_visitorname.Text))
                {
                    MessageBox.Show("Please enter vaild Name and Technique", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrWhiteSpace(txt_projectno.Text) || string.IsNullOrWhiteSpace(txt_sampleno.Text))
                {
                    MessageBox.Show("Please enter vaild Project Details and No Of Sample", "Empty Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string dirpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\LMSreport";
                    if (!Directory.Exists(dirpath))
                        Directory.CreateDirectory(dirpath);

                    string name = txt_name.Text.Trim();
                    string orgname = txt_organization.Text.Trim();
                    string visitorname = txt_visitorname.Text.Trim();
                    string projectno = txt_projectno.Text.Trim();
                    string technique = txt_technique.Text.Trim();
                    string smpno = txt_sampleno.Text.Trim();
                    string sdate = dtp_sdate.Text.Trim() + dtp_stime.Text.Trim();
                    string edate = dtp_edate.Text.Trim() + dtp_etime.Text.Trim();
                    string desc = txt_description.Text.Trim();
                    string email = txt_email.Text.Trim();
                    string phone = txt_phone.Text.Trim();
                    string filepath = dirpath.Trim();
                    string filename;
                   // if (IsTimesSlotFree(sdate, edate) == false)
                   // {
                      ///  dg_report.DataSource = objdb.GetExprimentReports();
                     ///   MessageBox.Show("Time Slots Are Not Available", "Time Slot ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                     //   return;
                  //  }
                    if (!string.IsNullOrEmpty(txt_filepath.Text))
                        filename = DateTime.Now.Millisecond.ToString() + "_" + reportfilename;
                    else
                        if (string.IsNullOrEmpty(dbsavefilename))
                            filename = string.Empty;
                        else
                            filename = dbsavefilename;
                    int isactive = 1;//defult value is 1 when want to not show in grid set 0
                    bool IsUpdate = objdb.UpdateExprimentReport(reportid, name, orgname, visitorname, projectno, technique, smpno, sdate, edate, desc, email, phone, filename, filepath, isactive);
                    if (IsUpdate == true)
                    {
                        if (!string.IsNullOrEmpty(txt_filepath.Text))
                            File.Copy(txt_filepath.Text.Trim(), filepath + "\\" + filename, true);
                        clearAll();
                        btn_update.Enabled = false;
                        btn_insert.Enabled = true;
                        lbl_msg.Visible = false;
                        dg_report.DataSource = objdb.GetExprimentReports();
                        MessageBox.Show("Record Update successfully !", "Info Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        dg_report.DataSource = objdb.GetExprimentReports();
                        MessageBox.Show("Unable to Update record Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog("Unable to Update Data to DB");
                objdb.WriteLog(ex.Message + "\n" + ex.StackTrace);
                dg_report.DataSource = objdb.GetExprimentReports();
            }
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                btn_search.Enabled = false;
                //btn_search_Click(sender, e);
                DataTable dtsearch = GetSerchData(txt_searchname.Text.Trim(), txt_searchprojdetails.Text.Trim(),Convert.ToDateTime(dtp_searchstratdate.Text).ToString("dd-MM-yyyy").Trim());
                if (dtsearch!=null)
                {
                    if(dtsearch.Rows.Count>0)
                    dg_download.DataSource = null;
                    dg_download.DataSource = dtsearch;
                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }

            btn_search.Enabled = true;
        }
        private void btn_searchclear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_searchname.Text = string.Empty;
                txt_searchprojdetails.Text = string.Empty;
                dtp_searchstratdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                dg_download.DataSource = null;
                dg_download.DataSource = objdb.GetExprimentReports();
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                SaveFileDialog saveFile = new SaveFileDialog();
                string origenalfile = string.Empty;
                if (string.IsNullOrEmpty(dg_download.SelectedRows[0].Cells[12].Value.ToString().Trim()))
                {
                    MessageBox.Show("Experiment report file not found", "Download report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                origenalfile = dg_download.SelectedRows[0].Cells[13].Value + "\\" + dg_download.SelectedRows[0].Cells[12].Value;
                saveFile.FileName = dg_download.SelectedRows[0].Cells[12].Value.ToString().Split('_')[1];
                saveFile.Title = "Download Report File";
                string fileextention = Path.GetExtension(origenalfile);
                saveFile.Filter =  "All Files (*.*)|*.*";
                saveFile.AddExtension = true;
                 
               //saveFile.Filter = "|*" + fileextention + "| All Files (*.*)|*.*";
                if (!File.Exists(origenalfile))
                    MessageBox.Show("Experiment report file not found", "Download report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(origenalfile))
                    {
                        string newfilepath = saveFile.FileName;
                        if ((Path.GetExtension(newfilepath) != fileextention) || string.IsNullOrEmpty(Path.GetExtension(newfilepath)))
                        {
                          newfilepath= Path.GetDirectoryName(saveFile.FileName) +"\\"+Path.GetFileNameWithoutExtension(newfilepath) + fileextention;
                        }

                        File.Copy(origenalfile, newfilepath);
                        MessageBox.Show("Experiment report downloaded successfully", "Download report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }

            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
                
            }
        }
        private void btn_exportcsv_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                DataTable data = (DataTable)dg_download.DataSource;
                if (data.Rows.Count > 0)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Title = "Export To CSV";
                    string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                    saveFile.Filter = filter;
                    string filename;
                    saveFile.FileName = "Report_" + DateTime.Now.ToString("dd-MM-yyyy") + ".csv";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveFile.FileName;
                      if(DataTableToCSV(data, filename)==true)
                        MessageBox.Show("Experiment report exported successfully", "Export report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }

        }
        public bool DataTableToCSV(DataTable dtDataTable, string strFilePath)
        {
            bool IsExport = false;
            try
            {
                StreamWriter sw = new StreamWriter(strFilePath, false);
                //headers    
               // for (int i = 0; i < dtDataTable.Columns.Count; i++)
                //{
                   // sw.Write(dtDataTable.Columns[i]);
                   // if (i < dtDataTable.Columns.Count - 1)
                   // {
                    //    sw.Write(",");
                   // }
                //}
                string header = "Name,Organization,Visitor Name,Project Details,Technique,No Of Sample,Start Time,End Time,Description,Email,Phone,Report File";
                sw.Write(header+sw.NewLine);
                foreach (DataRow dr in dtDataTable.Rows)
                {
                    for (int i = 1; i < dtDataTable.Columns.Count-2; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            string value = dr[i].ToString();
                            if (value.Contains(',') || value.Contains('\n'))
                            {
                                value = String.Format("\"{0}\"", value);
                                sw.Write(value);
                            }
                            else
                            {
                                sw.Write(dr[i].ToString());
                            }
                        }
                        if (i < dtDataTable.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
                IsExport = true;
            }
            catch (Exception ex)
            {
                IsExport = false;
                if (ex.Message.Contains("The process cannot access the file"))
                    MessageBox.Show("File is open please close and try again", "Export report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return IsExport;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                txt_searchname.Text = string.Empty;
                txt_searchprojdetails.Text = string.Empty;
                dtp_searchstratdate.Text = DateTime.Now.ToString();
                dg_download.DataSource = null;
                dg_download.DataSource = objdb.GetExprimentReports();
            }
            catch (Exception ex)
            {
                objdb.WriteLog(ex.Message+"\n"+ex.StackTrace);
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data has been saved successfully!", "Log out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        

        

       
        
       
    }
}
