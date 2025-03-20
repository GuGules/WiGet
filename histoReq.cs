using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wigetUtils;

namespace WiGet
{
    public partial class histoReq : Form
    {
        private localDbContext ctx = new localDbContext();

        public histoReq()
        {
            InitializeComponent();
        }



        private void histoReq_Load(object sender, EventArgs e)
        {
            histoDbg.Width = this.Width - 1;
            histoDbg.Height = this.Height - 1;

            DataTable dt = ctx.getHisto();

            histoDbg.DataSource = dt;
            histoDbg.AutoResizeColumns();
            this.Width = histoDbg.Width;

        }

        private void histoReq_Resize(object sender, EventArgs e)
        {
            histoDbg.Width = this.Width - 1;
            histoDbg.Height = this.Height - 1;
        }
    }
}
