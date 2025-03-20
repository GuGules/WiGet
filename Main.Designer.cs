namespace WiGet
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            sendReqBtn = new Button();
            urlTbx = new TextBox();
            Globaltbc = new TabControl();
            reqConf = new TabPage();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            delHeaderBtn = new Button();
            headerAddBtn = new Button();
            headerDGV = new DataGridView();
            headerRes = new TabPage();
            dgHeader = new DataGridView();
            contentRes = new TabPage();
            label1 = new Label();
            displayCbx = new ComboBox();
            resultBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            kinideszToolStripMenuItem = new ToolStripMenuItem();
            infosToolStripMenuItem = new ToolStripMenuItem();
            quitAppBtn = new ToolStripMenuItem();
            requToolStripMenuItem = new ToolStripMenuItem();
            runLastReq = new ToolStripMenuItem();
            showHistory = new ToolStripMenuItem();
            HTTPcbx = new ComboBox();
            loadingLbl = new Label();
            statusPanel = new Panel();
            statusCodeLbl = new Label();
            Globaltbc.SuspendLayout();
            reqConf.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerDGV).BeginInit();
            headerRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHeader).BeginInit();
            contentRes.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sendReqBtn
            // 
            sendReqBtn.Location = new Point(692, 48);
            sendReqBtn.Name = "sendReqBtn";
            sendReqBtn.Size = new Size(131, 23);
            sendReqBtn.TabIndex = 0;
            sendReqBtn.Text = "Envoyer la requête";
            sendReqBtn.UseVisualStyleBackColor = true;
            sendReqBtn.Click += sendReqBtn_Click;
            // 
            // urlTbx
            // 
            urlTbx.Location = new Point(173, 48);
            urlTbx.Name = "urlTbx";
            urlTbx.Size = new Size(513, 23);
            urlTbx.TabIndex = 1;
            // 
            // Globaltbc
            // 
            Globaltbc.Controls.Add(reqConf);
            Globaltbc.Controls.Add(headerRes);
            Globaltbc.Controls.Add(contentRes);
            Globaltbc.Location = new Point(0, 111);
            Globaltbc.Name = "Globaltbc";
            Globaltbc.SelectedIndex = 0;
            Globaltbc.Size = new Size(939, 424);
            Globaltbc.TabIndex = 2;
            // 
            // reqConf
            // 
            reqConf.Controls.Add(groupBox2);
            reqConf.Controls.Add(groupBox1);
            reqConf.Location = new Point(4, 24);
            reqConf.Name = "reqConf";
            reqConf.Padding = new Padding(3);
            reqConf.Size = new Size(931, 396);
            reqConf.TabIndex = 0;
            reqConf.Text = "Configuration de la requête";
            reqConf.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(480, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 383);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paramètres de la requête";
            // 
            // button1
            // 
            button1.Location = new Point(339, 51);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 5;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(339, 22);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 4;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(327, 355);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delHeaderBtn);
            groupBox1.Controls.Add(headerAddBtn);
            groupBox1.Controls.Add(headerDGV);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "En-têtes HTTP";
            // 
            // delHeaderBtn
            // 
            delHeaderBtn.Location = new Point(339, 51);
            delHeaderBtn.Name = "delHeaderBtn";
            delHeaderBtn.Size = new Size(121, 23);
            delHeaderBtn.TabIndex = 3;
            delHeaderBtn.Text = "Supprimer";
            delHeaderBtn.UseVisualStyleBackColor = true;
            delHeaderBtn.Click += delHeaderBtn_Click;
            // 
            // headerAddBtn
            // 
            headerAddBtn.Location = new Point(339, 22);
            headerAddBtn.Name = "headerAddBtn";
            headerAddBtn.Size = new Size(121, 23);
            headerAddBtn.TabIndex = 1;
            headerAddBtn.Text = "Ajouter";
            headerAddBtn.UseVisualStyleBackColor = true;
            headerAddBtn.Click += headerAddBtn_Click;
            // 
            // headerDGV
            // 
            headerDGV.BackgroundColor = Color.White;
            headerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            headerDGV.Location = new Point(6, 22);
            headerDGV.Name = "headerDGV";
            headerDGV.Size = new Size(327, 355);
            headerDGV.TabIndex = 0;
            // 
            // headerRes
            // 
            headerRes.Controls.Add(dgHeader);
            headerRes.Location = new Point(4, 24);
            headerRes.Name = "headerRes";
            headerRes.Size = new Size(931, 396);
            headerRes.TabIndex = 2;
            headerRes.Text = "En-tête de la réponse";
            headerRes.UseVisualStyleBackColor = true;
            // 
            // dgHeader
            // 
            dgHeader.BackgroundColor = Color.White;
            dgHeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHeader.Location = new Point(0, 0);
            dgHeader.Name = "dgHeader";
            dgHeader.Size = new Size(842, 328);
            dgHeader.TabIndex = 0;
            // 
            // contentRes
            // 
            contentRes.Controls.Add(label1);
            contentRes.Controls.Add(displayCbx);
            contentRes.Controls.Add(resultBox);
            contentRes.Location = new Point(4, 24);
            contentRes.Name = "contentRes";
            contentRes.Padding = new Padding(3);
            contentRes.Size = new Size(931, 396);
            contentRes.TabIndex = 1;
            contentRes.Text = "Contenu de la réponse";
            contentRes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(688, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Affichage :";
            // 
            // displayCbx
            // 
            displayCbx.FormattingEnabled = true;
            displayCbx.Items.AddRange(new object[] { "JSON", "TEXT" });
            displayCbx.Location = new Point(760, 17);
            displayCbx.Name = "displayCbx";
            displayCbx.Size = new Size(163, 23);
            displayCbx.TabIndex = 1;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(3, 46);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(928, 350);
            resultBox.TabIndex = 0;
            resultBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.IndianRed;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kinideszToolStripMenuItem, requToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // kinideszToolStripMenuItem
            // 
            kinideszToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infosToolStripMenuItem, quitAppBtn });
            kinideszToolStripMenuItem.ForeColor = Color.Black;
            kinideszToolStripMenuItem.Name = "kinideszToolStripMenuItem";
            kinideszToolStripMenuItem.Size = new Size(80, 20);
            kinideszToolStripMenuItem.Text = "Application";
            // 
            // infosToolStripMenuItem
            // 
            infosToolStripMenuItem.BackColor = Color.Transparent;
            infosToolStripMenuItem.ForeColor = Color.Black;
            infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            infosToolStripMenuItem.Size = new Size(179, 22);
            infosToolStripMenuItem.Text = "Infos";
            infosToolStripMenuItem.Click += showClientInfos;
            // 
            // quitAppBtn
            // 
            quitAppBtn.BackColor = Color.Transparent;
            quitAppBtn.ForeColor = Color.Black;
            quitAppBtn.Name = "quitAppBtn";
            quitAppBtn.Size = new Size(179, 22);
            quitAppBtn.Text = "Quitter l'application";
            quitAppBtn.Click += quitApp;
            // 
            // requToolStripMenuItem
            // 
            requToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runLastReq, showHistory });
            requToolStripMenuItem.Name = "requToolStripMenuItem";
            requToolStripMenuItem.Size = new Size(143, 20);
            requToolStripMenuItem.Text = "Historique des requêtes";
            // 
            // runLastReq
            // 
            runLastReq.Name = "runLastReq";
            runLastReq.Size = new Size(247, 22);
            runLastReq.Text = "Executer la dernière requête";
            runLastReq.Click += runLastReq_Click;
            // 
            // showHistory
            // 
            showHistory.Name = "showHistory";
            showHistory.Size = new Size(247, 22);
            showHistory.Text = "Afficher l'historique des requêtes";
            showHistory.Click += showHistory_Click;
            // 
            // HTTPcbx
            // 
            HTTPcbx.FormattingEnabled = true;
            HTTPcbx.Items.AddRange(new object[] { "GET", "POST" });
            HTTPcbx.Location = new Point(46, 48);
            HTTPcbx.Name = "HTTPcbx";
            HTTPcbx.Size = new Size(121, 23);
            HTTPcbx.TabIndex = 4;
            // 
            // loadingLbl
            // 
            loadingLbl.AutoSize = true;
            loadingLbl.Location = new Point(46, 86);
            loadingLbl.Name = "loadingLbl";
            loadingLbl.Size = new Size(130, 15);
            loadingLbl.TabIndex = 5;
            loadingLbl.Text = "Chargement en cours...";
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(statusCodeLbl);
            statusPanel.Location = new Point(648, 93);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(188, 35);
            statusPanel.TabIndex = 6;
            // 
            // statusCodeLbl
            // 
            statusCodeLbl.AutoSize = true;
            statusCodeLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusCodeLbl.Location = new Point(19, 6);
            statusCodeLbl.Name = "statusCodeLbl";
            statusCodeLbl.Size = new Size(65, 25);
            statusCodeLbl.TabIndex = 0;
            statusCodeLbl.Text = "label1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(939, 535);
            Controls.Add(statusPanel);
            Controls.Add(loadingLbl);
            Controls.Add(HTTPcbx);
            Controls.Add(Globaltbc);
            Controls.Add(urlTbx);
            Controls.Add(sendReqBtn);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "WiGet";
            Load += Main_Load;
            Shown += Main_Shown;
            Globaltbc.ResumeLayout(false);
            reqConf.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)headerDGV).EndInit();
            headerRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHeader).EndInit();
            contentRes.ResumeLayout(false);
            contentRes.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendReqBtn;
        private TextBox urlTbx;
        private TabControl Globaltbc;
        private TabPage reqConf;
        private TabPage contentRes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitAppBtn;
        private ComboBox HTTPcbx;
        private Label loadingLbl;
        private RichTextBox resultBox;
        private TabPage headerRes;
        private Panel statusPanel;
        private Label statusCodeLbl;
        private ToolStripMenuItem infosToolStripMenuItem;
        internal ToolStripMenuItem kinideszToolStripMenuItem;
        private DataGridView dgHeader;
        private Label label1;
        private ComboBox displayCbx;
        private ToolStripMenuItem requToolStripMenuItem;
        private ToolStripMenuItem runLastReq;
        private ToolStripMenuItem showHistory;
        private GroupBox groupBox1;
        private Button delHeaderBtn;
        private Button headerAddBtn;
        private DataGridView headerDGV;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}