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
            sendReqBtn = new Button();
            urlTbx = new TextBox();
            Globaltbc = new TabControl();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            resultBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            kinideszToolStripMenuItem = new ToolStripMenuItem();
            infosToolStripMenuItem = new ToolStripMenuItem();
            quitAppBtn = new ToolStripMenuItem();
            HTTPcbx = new ComboBox();
            loadingLbl = new Label();
            statusPanel = new Panel();
            statusCodeLbl = new Label();
            Globaltbc.SuspendLayout();
            tabPage2.SuspendLayout();
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
            Globaltbc.Controls.Add(tabPage1);
            Globaltbc.Controls.Add(tabPage3);
            Globaltbc.Controls.Add(tabPage2);
            Globaltbc.Location = new Point(0, 151);
            Globaltbc.Name = "Globaltbc";
            Globaltbc.SelectedIndex = 0;
            Globaltbc.Size = new Size(880, 356);
            Globaltbc.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 328);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Configuration de la requête";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(872, 328);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "En-tête de la réponse";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(resultBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 328);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contenu de la réponse";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(3, 0);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(863, 328);
            resultBox.TabIndex = 0;
            resultBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.IndianRed;
            menuStrip1.Items.AddRange(new ToolStripItem[] { kinideszToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(880, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // kinideszToolStripMenuItem
            // 
            kinideszToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infosToolStripMenuItem, quitAppBtn });
            kinideszToolStripMenuItem.Name = "kinideszToolStripMenuItem";
            kinideszToolStripMenuItem.Size = new Size(80, 20);
            kinideszToolStripMenuItem.Text = "Application";
            // 
            // infosToolStripMenuItem
            // 
            infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            infosToolStripMenuItem.Size = new Size(180, 22);
            infosToolStripMenuItem.Text = "Infos";
            infosToolStripMenuItem.Click += showClientInfos;
            // 
            // quitAppBtn
            // 
            quitAppBtn.Name = "quitAppBtn";
            quitAppBtn.Size = new Size(180, 22);
            quitAppBtn.Text = "Quitter l'application";
            quitAppBtn.Click += quitApp;
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
            loadingLbl.Location = new Point(46, 93);
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
            ClientSize = new Size(880, 505);
            Controls.Add(statusPanel);
            Controls.Add(loadingLbl);
            Controls.Add(HTTPcbx);
            Controls.Add(Globaltbc);
            Controls.Add(urlTbx);
            Controls.Add(sendReqBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "WiGet";
            Load += Main_Load;
            Shown += Main_Shown;
            Globaltbc.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kinideszToolStripMenuItem;
        private ToolStripMenuItem quitAppBtn;
        private ComboBox HTTPcbx;
        private Label loadingLbl;
        private RichTextBox resultBox;
        private TabPage tabPage3;
        private Panel statusPanel;
        private Label statusCodeLbl;
        private ToolStripMenuItem infosToolStripMenuItem;
    }
}