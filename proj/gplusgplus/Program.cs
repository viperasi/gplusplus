using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace com.xu81.dotnet.gplusplus
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AppController.accessToken = Properties.Settings.Default.accessToken;
            AppController.authcode = Properties.Settings.Default.authcode;
            AppController.userid = Properties.Settings.Default.userid;
            AppController.autoRefresh = Properties.Settings.Default.autorefresh;
            AppController.refreshDelay = Properties.Settings.Default.refreshdelay;
            AppController.notePath = Properties.Settings.Default.notepath;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
