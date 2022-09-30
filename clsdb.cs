using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace LabManagementApp
{
   public class clsdb
    {
        public SQLiteConnection sql_con;
        public SQLiteCommand sql_cmd;
        public SQLiteDataAdapter DB;
        public DataSet DS = new DataSet();
        //public DataTable DT = new DataTable();

        public void WriteLog(string msg = "***Error Log***")
        {
            try
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory + @"\Log";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                string data = DateTime.Now.ToString() + ": " + msg + "\n";
                string filename = dir + "\\error_log" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                File.AppendAllText(filename, data);
            }
            catch (Exception ex)
            {
                //nothing can do...
            }
        }

        public void SetConnection()
        {
            string dbfile = AppDomain.CurrentDomain.BaseDirectory + @"labdb.db";
            //sql_con = new SQLiteConnection("Data Source=C:/sqlite/labdb.db;Version=3;New=False;Compress=True;");
            sql_con = new SQLiteConnection("Data Source="+dbfile+";Version=3;New=False;Compress=True;");
        }
        public DataTable GetLoginInfo()
        {
            DataTable DT = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from users";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);

                DT = DS.Tables[0];
                sql_con.Close();
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return DT;
        }
        //public DataTable GetReports()
        //{
        //    DataTable DT = new DataTable();
        //    try
        //    {
        //        SetConnection();
        //        sql_con.Open();
        //        sql_cmd = sql_con.CreateCommand();
        //        string CommandText = "select * from report";
        //        DB = new SQLiteDataAdapter(CommandText, sql_con);
        //        DS.Reset();
        //        DB.Fill(DS);

        //        DT = DS.Tables[0];
        //        sql_con.Close();
        //    }
        //    catch (Exception ex)
        //    { WriteLog(ex.Message+"\n"+ex.StackTrace); }
        //    return DT;
        //}

        public DataTable GetExprimentReports()
        {
            DataTable DT = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from expriment_report order by reportid DESC ";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);

                DT = DS.Tables[0];
                sql_con.Close();
            }
            catch (Exception ex)
            { WriteLog(ex.Message+"\n"+ex.StackTrace); }
            return DT;
        }

        public DataTable GetTimeSlot()
        {
            DataTable DT = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select slot from time_slot where isactive=1";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);

                DT = DS.Tables[0];
                sql_con.Close();
            }
            catch (Exception ex)
            { WriteLog(ex.Message + "\n" + ex.StackTrace); }
            return DT;

        }
        

        public bool InserReport(string username, string email, string phone, string address, string expname, string startdate, string enddate, string desc, string filename, string path, int active)
        {
            bool IsInsert = false;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = @"INSERT INTO report 
                (username, email, phone, address, expname,startdate,enddate,desc,reportfilename,filepath,isactive) 
                VALUES (@unmae, @email, @phone, @add, @ename,@sdate,@edate,@desc,@rfname,@fpath,@active)";
                sql_cmd.Parameters.AddWithValue("@unmae", username);
                sql_cmd.Parameters.AddWithValue("@email", email);
                sql_cmd.Parameters.AddWithValue("@phone", phone);
                sql_cmd.Parameters.AddWithValue("@add", address);
                sql_cmd.Parameters.AddWithValue("@ename", expname);
                sql_cmd.Parameters.AddWithValue("@sdate", startdate);
                sql_cmd.Parameters.AddWithValue("@edate", enddate);
                sql_cmd.Parameters.AddWithValue("@desc", desc);
                sql_cmd.Parameters.AddWithValue("@rfname", filename);
                sql_cmd.Parameters.AddWithValue("@fpath", path);
                sql_cmd.Parameters.AddWithValue("@active", active);
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                IsInsert = true;
            }
            catch (SQLiteException ex)
            {
                IsInsert = false;
                WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return IsInsert;
        }

        public bool InsertExprimentReport(string name, string org, string vname, string projno, string tech, string smpno, string startdate, string enddate, string desc, string email, string phone, string filename, string path, int active)
        {
            bool IsInsert = false;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = @"INSERT INTO expriment_report 
                (name,orgname,visitorname,projectno,technique,sampleno,startdate,enddate,desc,email,phone,reportfilename,filepath,isactive) 
                VALUES (@nmae, @orgn, @vname, @projno, @tech,@smno,@sdate,@edate,@desc,@email,@phone,@rfname,@fpath,@active)";
                sql_cmd.Parameters.AddWithValue("@nmae", name);
                sql_cmd.Parameters.AddWithValue("@orgn", org);
                sql_cmd.Parameters.AddWithValue("@vname", vname);
                sql_cmd.Parameters.AddWithValue("@projno", projno);
                sql_cmd.Parameters.AddWithValue("@tech", tech);
                sql_cmd.Parameters.AddWithValue("@smno", smpno);
                sql_cmd.Parameters.AddWithValue("@sdate", startdate);
                sql_cmd.Parameters.AddWithValue("@edate", enddate);
                sql_cmd.Parameters.AddWithValue("@desc", desc);
                sql_cmd.Parameters.AddWithValue("@email", email);
                sql_cmd.Parameters.AddWithValue("@phone", phone);
                sql_cmd.Parameters.AddWithValue("@rfname", filename);
                sql_cmd.Parameters.AddWithValue("@fpath", path);
                sql_cmd.Parameters.AddWithValue("@active", active);
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                IsInsert = true;
            }
            catch (SQLiteException ex)
            {
                IsInsert = false;
                WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return IsInsert;
        }

        public bool UpdateReport(int id,string username, string email, string phone, string address, string expname, string startdate, string enddate, string desc, string filename, string path, int active)
        {
            bool IsUpdate = false;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = @"update report set username = :unmae,email = :email, phone =:phone ,address =:add,
                expname =:ename,startdate =:sdate,enddate =:edate,desc =:desc,reportfilename =:rfname,filepath =:fpath,
                isactive =:active where reportid =:id";
                sql_cmd.Parameters.Add("unmae", DbType.String).Value=username;
                sql_cmd.Parameters.Add("email", DbType.String).Value=email;
                sql_cmd.Parameters.Add("phone", DbType.String).Value=phone;
                sql_cmd.Parameters.Add("add", DbType.String).Value=address;
                sql_cmd.Parameters.Add("ename", DbType.String).Value=expname;
                sql_cmd.Parameters.Add("sdate", DbType.String).Value=startdate;
                sql_cmd.Parameters.Add("edate", DbType.String).Value=enddate;
                sql_cmd.Parameters.Add("desc", DbType.String).Value=desc;
                sql_cmd.Parameters.Add("rfname", DbType.String).Value=filename;
                sql_cmd.Parameters.Add("fpath", DbType.String).Value=path;
                sql_cmd.Parameters.Add("active", DbType.Int32).Value=active;
                sql_cmd.Parameters.Add("id", DbType.Int32).Value = id;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                IsUpdate = true;
            }
            catch (SQLiteException ex)
            {
                IsUpdate = false;
                WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return IsUpdate;
        }

        public bool UpdateExprimentReport(int id, string name, string org, string vname, string projno, string tech, string smpno, string startdate, string enddate, string desc, string email, string phone, string filename, string path, int active)
        {
            bool IsUpdate = false;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = @"update expriment_report set name = :name,orgname = :org, visitorname =:vname ,projectno =:proj,
                technique =:tech,sampleno=:smno,startdate =:sdate,enddate =:edate,desc =:desc, email=:email,phone=:phone,
                 reportfilename =:rfname,filepath =:fpath,isactive =:active where reportid =:id";
                sql_cmd.Parameters.Add("name", DbType.String).Value = name;
                sql_cmd.Parameters.Add("org", DbType.String).Value = org;
                sql_cmd.Parameters.Add("vname", DbType.String).Value = vname;
                sql_cmd.Parameters.Add("proj", DbType.String).Value = projno;
                sql_cmd.Parameters.Add("tech", DbType.String).Value = tech;
                sql_cmd.Parameters.Add("smno", DbType.String).Value = smpno;
                sql_cmd.Parameters.Add("sdate", DbType.String).Value = startdate;
                sql_cmd.Parameters.Add("edate", DbType.String).Value = enddate;
                sql_cmd.Parameters.Add("desc", DbType.String).Value = desc;
                sql_cmd.Parameters.Add("email", DbType.String).Value = email;
                sql_cmd.Parameters.Add("phone", DbType.String).Value = phone;
                sql_cmd.Parameters.Add("rfname", DbType.String).Value = filename;
                sql_cmd.Parameters.Add("fpath", DbType.String).Value = path;
                sql_cmd.Parameters.Add("active", DbType.Int32).Value = active;
                sql_cmd.Parameters.Add("id", DbType.Int32).Value = id;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                IsUpdate = true;
            }
            catch (SQLiteException ex)
            {
                IsUpdate = false;
                WriteLog(ex.Message+"\n"+ex.StackTrace);
            }
            return IsUpdate;
        }

    }
}
