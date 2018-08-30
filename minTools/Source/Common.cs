using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace minTools
{
    public class ScheduledTaskRemoteLauncher
    {
        public bool launchRemoteTask(string machineName, string taskName)
        {
            string appLocation = "C:/Windows/system32/schtasks.exe";
            string appArguments = "/end /s " + machineName + " /tn '" + taskName + "'";
            ProcessStartInfo appLaunchInfo = new ProcessStartInfo(appLocation,appArguments);

            appLaunchInfo.WorkingDirectory = new FileInfo(appLocation).DirectoryName;
            appLaunchInfo.UserName = "vcladmin";
            appLaunchInfo.Password = new System.Net.NetworkCredential("", "").SecurePassword;
            appLaunchInfo.Domain = "vcl";
            appLaunchInfo.UseShellExecute = false;
            Process p = Process.Start(appLaunchInfo);

            int counter=0;
            while (!p.HasExited)
                counter++;

            Console.WriteLine(p.ExitCode);
            return true;
        }
    }
}
