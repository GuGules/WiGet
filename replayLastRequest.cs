using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wigetUtils;

namespace WiGet
{
    public partial class replayLastRequest : Form
    {
        private localDbContext ctx = new localDbContext();
        public replayLastRequest()
        {
            InitializeComponent();
            //this.ShowInTaskbar = true;
        }

        private async void replayLastRequest_Load(object sender, EventArgs e)
        {
            Request req = ctx.getLastRequest();
            if (req.getApiUrl() == "")
            {
                new ToastContentBuilder()
                .AddText("Impossible d'envoyer la requête")
                .AddText("Aucune requête dans l'historique")
                .Show();
            }
            else
            {
                HttpResponseMessage message = await req.sendRequest();

                new ToastContentBuilder()
                .AddText($"Requête vers {req.getApiUrl()} exécutée")
                .AddText("Code de réponse : " + ((int)message.StatusCode).ToString())
                .Show();

                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
