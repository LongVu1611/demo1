using demo.Utils;
using demo.View;
using demo.View.ChildForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.serverName = "ZEN-SPRIGGAN";
            DatabaseHelper.dbName = "demo";
            DatabaseHelper.userDb = "gosu";
            DatabaseHelper.password = "29041976";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}