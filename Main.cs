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
using Newtonsoft.Json;
using System.Collections;

using Microsoft.Toolkit.Uwp.Notifications;

 



namespace WiGet
{
    public partial class Main : Form
    {


        // Liste pour stocker les onglets supprimés
        private Dictionary<string, TabPage> hiddenTabs = new Dictionary<string, TabPage>();
        private Dictionary<string, string> headers = new Dictionary<string, string>();
        private DataTable dt = new DataTable();

        // Méthode pour cacher un onglet
        private void HideTabPage(TabControl tabControl, string tabPageName)
        {
            var tabPage = tabControl.TabPages.Cast<TabPage>().FirstOrDefault(tp => tp.Name == tabPageName);
            if (tabPage != null)
            {
                hiddenTabs[tabPageName] = tabPage; // Stocker l'onglet caché
                tabControl.TabPages.Remove(tabPage);
            }
        }

        // Méthode pour afficher un onglet caché
        private void ShowTabPage(TabControl tabControl, string tabPageName)
        {
            if (hiddenTabs.ContainsKey(tabPageName))
            {
                tabControl.TabPages.Add(hiddenTabs[tabPageName]);
                hiddenTabs.Remove(tabPageName);
            }
        }

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
            if (urlTbx.Text.Length > 0 && urlTbx.Text != " " && urlTbx.Text != "")
            {
                switch (HTTPcbx.SelectedItem?.ToString())
                {
                    case "GET":
                        Request get0 = new Request();
                        get0.setApiUrl(urlTbx.Text);
                        //Affichage texte de chargement
                        loadingLbl.Show();
                        HttpResponseMessage feur = await get0.sendRequest();

                        if (new int[] { 200, 300 }.Contains((int)feur.StatusCode))
                        {
                            statusPanel.BackColor = Color.Green;
                            //Affichage du résultat dans le volet Résultat de la requête
                            string og = await feur.Content.ReadAsStringAsync();
                            try
                            {
                                resultBox.Text = System.Text.Json.Nodes.JsonNode.Parse(og)?.ToString();
                                displayCbx.SelectedItem = "JSON";
                            }
                            catch (Exception)
                            {
                                resultBox.Text = og;
                                displayCbx.SelectedItem = "TEXT";
                            }
                        }
                        else
                        {
                            statusPanel.BackColor = Color.Red;
                        }
                        // Affichage des valeurs du header
                        List<KeyValuePair<string, string>> headerList = feur.Headers
                            .SelectMany(header => header.Value.Select(value => new KeyValuePair<string, string>(header.Key, value)))
                            .ToList();

                        // Gestion des notifications
                        //TODO

                        ShowTabPage(Globaltbc, "headerRes");
                        ShowTabPage(Globaltbc, "contentRes");

                        // Liaison au DataGridView
                        dgHeader.DataSource = headerList;
                        dgHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgHeader.Columns[0].HeaderText = "Nom de l'en-tête";
                        dgHeader.Columns[1].HeaderText = "Valeur";
                        dgHeader.Show();

                        //Affichage des tabs

                        statusCodeLbl.Text = "Etat : " + ((int)feur.StatusCode).ToString();
                        statusPanel.Show();
                        //Masquage texte de chargement
                        loadingLbl.Hide();
                        //TODO : Historique des requêtes
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
                MessageBox.Show("Aucune adresse entré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void headerDGVRefresh()
        {
            dt.Rows.Clear();
            foreach (var kvp in headers)
            {
                dt.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            new ToastContentBuilder()
            .AddText("App Launched")
            .AddText("Hello World!, I'm in!!!")
            .Show();

            HTTPcbx.SelectedItem = "GET";


            // Hiding elements when not used
            loadingLbl.Hide();
            statusPanel.Hide();
            dgHeader.Hide();

            // Cachage des tabpages pas utiles.
            HideTabPage(Globaltbc, "headerRes");
            HideTabPage(Globaltbc, "contentRes");

            // Chargement de la liste des headers

            dt.Columns.Add("Nom", typeof(string)); // Colonne pour les clés
            dt.Columns.Add("Valeur", typeof(string)); // Colonne pour les valeurs
            headerDGVRefresh();

            headerDGV.DataSource = dt;

            //MessageBox.Show(new localDbContext().getLastRequest()[0]);

        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            histoReq histo = new histoReq();
            histo.Show();
        }

        private void headerAddBtn_Click(object sender, EventArgs e)
        {
            addHeaderForm form = new addHeaderForm();
            form.ShowDialog();
            if (form.getHeaderName() != "" && form.getHeaderValue() != "")
            {
                this.headers[form.getHeaderName()] = form.getHeaderValue();
                headerDGVRefresh();
            }
        }

        private void delHeaderBtn_Click(object sender, EventArgs e)
        {
            if (headerDGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in headerDGV.SelectedRows)
                {
                    string headerName = row.Cells["Nom"].Value.ToString();
                    headers.Remove(headerName);
                    headerDGVRefresh();
                }
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionné");
            }
        }

        private void runLastReq_Click(object sender, EventArgs e)
        {
            replayLastRequest r = new replayLastRequest();
            r.Show();
        }
    }
}
