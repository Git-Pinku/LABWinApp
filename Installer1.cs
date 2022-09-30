using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Diagnostics;
using System.IO;



namespace LabManagementApp
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
        clsdb objdb = new clsdb();
        private string RunCMDFolderPermission()
        {
            var proc1 = new ProcessStartInfo();
            string result = string.Empty;
            //string anyCommand = @"Echo Y| cacls %userprofile%\AppData\Roaming /e /g %username%:R";
            string anyCommand = @"Echo Y| cacls %userprofile%\Program Files (x86)\PDInfotech /e /g %username%:R";
            try
            {
                proc1.UseShellExecute = false;
                proc1.RedirectStandardOutput = true;
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + anyCommand;
                proc1.WindowStyle = ProcessWindowStyle.Maximized;
                using (Process process = Process.Start(proc1))
                {
                    using (StreamReader reader = process.StandardOutput)
                    { result = reader.ReadToEnd(); }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message+ex.StackTrace;
                objdb.WriteLog(result);
            }
            return result;

        }

        private void Installer1_BeforeInstall(object sender, InstallEventArgs e)
        {
            try
                {
                 string ret = RunCMDFolderPermission();
                 objdb.WriteLog("RunCMDFolderPermission is OK" + Environment.NewLine);
                 objdb.WriteLog(ret);
                }
                catch (Exception ex)
                {
                    objdb.WriteLog("Error in RunCMDFolderPermission" + ex.Message + Environment.NewLine);
                }

        }

    }
}
