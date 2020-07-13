using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 影院售票管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            else
            {
                frmLogin.Close();
            }
        }
    }
}
