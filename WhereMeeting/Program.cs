using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereMeeting
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
            //Console.WriteLine("UserName: {0} UserDomain: {1}", Environment.UserName, Environment.UserDomainName);
            if ("FAREAST".Equals(Environment.UserDomainName))
            {
                Application.Run(new Home());
            } else
            {
                Application.Run(new Error());
            }
        }
    }
}
