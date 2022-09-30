﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace UserApp
{
   public static  class clsdb
    {
        public static  SQLiteConnection sql_con;
        public static  SQLiteCommand sql_cmd;
        public static  SQLiteDataAdapter DB;
        public static  DataSet DS = new DataSet();
        //public static DataTable DT = new DataTable();

        public static  void WriteLog(string msg = "***Error Log***")
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

        public static void SetConnection()
        {
            string dbfile = AppDomain.CurrentDomain.BaseDirectory + @"labdb.db";
            //sql_con = new SQLiteConnection("Data Source=C:/sqlite/labdb.db;Version=3;New=False;Compress=True;");
            sql_con = new SQLiteConnection("Data Source="+dbfile+";Version=3;New=False;Compress=True;");
        }
        public static DataTable GetLoginInfo()
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
        public static DataTable GetReports()
        {
            DataTable DT = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from report";
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

        public static bool UpdateUserPassword(string username, string password)
        {
            bool IsUpdate = false;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = @"update users set username = :unmae, userpassword = :pass,login_timestamp=:time where userid =:id";
                sql_cmd.Parameters.Add("unmae", DbType.String).Value = username;
                sql_cmd.Parameters.Add("pass", DbType.String).Value = password;
                sql_cmd.Parameters.Add("time", DbType.String).Value = DateTime.Now.ToString("dd-MM-yyyy hh:mm tt");
                sql_cmd.Parameters.Add("id", DbType.Int32).Value = 1;
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Parameters.Clear();
                IsUpdate = true;
            }
            catch (SQLiteException ex)
            {
                IsUpdate = false;
                WriteLog(ex.Message+"\n"+ex.StackTrace);
                //throw;
            }
            return IsUpdate;
        }

        public static bool InserReport(string username, string email, string phone, string address, string expname, string startdate, string enddate, string desc, string filename, string path, int active)
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

        public static bool UpdateReport(int id,string username, string email, string phone, string address, string expname, string startdate, string enddate, string desc, string filename, string path, int active)
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
    }
}
