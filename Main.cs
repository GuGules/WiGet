using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

// Import jump libraries

using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using wigetUtils;
using System.Net.Http.Headers;
using System.Net;



namespace WiGet
{
    public partial class Main : Form
    {
        public void loadJumpList()
        {
            // Chargement des actions spécifiques dans la barre des tâches
            try
            {
                if (TaskbarManager.IsPlatformSupported)
                {

                    JumpList jumplist = JumpList.CreateJumpList();

                    // Ajouter des tâches personnalisées
                    JumpListLink parametres = new JumpListLink(Application.ExecutablePath, "Ouvrir les Paramètres")
                    {
                        Arguments = "/settings",
                        IconReference = new IconReference(Application.ExecutablePath, 0) // Icône de l'application
                    };

                    JumpListLink replayLastReq = new JumpListLink(Application.ExecutablePath, "Rejouer la dernière requête")
                    {
                        Arguments = "/replayLastReq",
                        IconReference = new IconReference(Application.ExecutablePath, 0) // Icône de l'application
                    };

                    jumplist.AddUserTasks(parametres);
                    jumplist.AddUserTasks(replayLastReq);
                    jumplist.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during jumplist:" + ex.Message);
            }
        }

        private void showClientInfos()
        {
            MessageBox.Show("Fonctionnalité à venir");
        }

        public Main()
        {
            InitializeComponent();
        }

        private async void sendReqBtn_Click(object sender, EventArgs e)
        {
            if (urlTbx.Text.Length>0 && urlTbx.Text != " " && urlTbx.Text!="")
            {
                switch (HTTPcbx.SelectedItem?.ToString())
                {
                    case "GET":
                        getRequest get0 = new getRequest();
                        get0.setApiUrl(urlTbx.Text);
                        loadingLbl.Show();
                        HttpResponseMessage feur = await get0.sendRequest();
                        if (feur.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Requête réussi");
                            resultBox.Text = await feur.Content.ReadAsStringAsync();
                            //MessageBox.Show(feur.Headers.ToString());
                            MessageBox.Show(((int)feur.StatusCode).ToString());
                            if (feur.StatusCode.ToString() == "OK"){
                                statusPanel.BackColor = Color.Green;
                            } else
                            {
                                statusPanel.BackColor = Color.Red;
                            }
                            statusCodeLbl.Text = "Etat : " + ((int)feur.StatusCode).ToString();
                            statusPanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Requête échouée");
                        }
                        loadingLbl.Hide();


                        break;
                    case "POST":
                        MessageBox.Show("Méthode non implémenté");
                        break;
                    default:
                        MessageBox.Show("Veuillez vous assurer d'avoir sélectionner une méthode");
                        break;
                }

                //Affichage des résultats de la requête
                Globaltbc.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Aucune adresse entré", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            loadJumpList();
        }

        private void quitApp(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showClientInfos(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité à venir");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HTTPcbx.SelectedItem = "GET";
            loadingLbl.Hide();
            statusPanel.Hide();
        }
    }
}
