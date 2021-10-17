using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperToolRenovado
{
    static class CommandsCMD
    {
        public static void RunCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/C " + command;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.Start();
        }
        static public Task RunSlmgr(string command)
        {
            return new Task(() => {
                Process cmd = new Process();
                cmd.StartInfo.FileName = @"cscript";
                cmd.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                cmd.StartInfo.Arguments = "//B //Nologo slmgr.vbs " + command;
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.Start();
                cmd.WaitForExit(2000); //no funciona
                //cmd.Kill();
                //MessageBox.Show("prueba");
            });

        }
    }
}
