using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using C_sharp_gitlab_runner.executor;
using C_sharp_gitlab_runner.network;

namespace C_sharp_gitlab_runner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            PowerShell ps = new PowerShell();

            GitLab gitlab = new GitLab("http://192.168.10.15");
            gitlab.UpdateJobStatus();
        }
    }
}
