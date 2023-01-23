using PenyewaanMotorJogjaApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenyewaanMotorJogjaApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var Login = new Login();
            if (Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPenyewaan());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
