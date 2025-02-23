using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using System.Runtime.CompilerServices;
using WiGet;
using wigetUtils;


namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = Environment.GetCommandLineArgs();

            if (args.Contains("/settings"))
            {
                MessageBox.Show("Ouverture des paramètres...");
                // Tu peux ouvrir directement un autre formulaire ici, ex :
                // Application.Run(new SettingsForm());
            }
            else if (args.Contains("/replayLastReq"))
            {
                MessageBox.Show("Redémarage de la dernière requête GET...");
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}