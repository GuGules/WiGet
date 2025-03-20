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


using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;



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

            try
            {
                string[] args = Environment.GetCommandLineArgs();
                args = args.Where(a => !a.EndsWith(".dll", StringComparison.OrdinalIgnoreCase)).ToArray();

                // Vérifier si l'application est déjà en cours
                var existingProcess = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName)
                                             .FirstOrDefault(p => p.Id != Process.GetCurrentProcess().Id);

                if (args.Contains("/settings"))
                {
                    MessageBox.Show("Ouverture des paramètres...");
                    // Tu peux ouvrir directement un autre formulaire ici, ex :
                    // Application.Run(new SettingsForm());
                }
                else if (args.Contains("/replayLastReq"))
                {
                    //File.AppendAllText(logPath, $"Application démarée");
                    MessageBox.Show("Execution de la dernière requete");
                    Application.Run(new replayLastRequest());
                }
                else
                {
                    Application.Run(new Main());
                }
            } catch (Exception e)
            {
                MessageBox.Show("Il y a eu un problème lors du démarrage de l'application");
            }
        }
    }
}