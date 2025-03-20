namespace WiGet
{
    partial class histoReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(histoReq));
            histoDbg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)histoDbg).BeginInit();
            SuspendLayout();
            // 
            // histoDbg
            // 
            histoDbg.BackgroundColor = Color.White;
            histoDbg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            histoDbg.Location = new Point(-1, -1);
            histoDbg.Name = "histoDbg";
            histoDbg.Size = new Size(410, 524);
            histoDbg.TabIndex = 0;
            // 
            // histoReq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(413, 539);
            Controls.Add(histoDbg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "histoReq";
            Text = "Historique des requêtes";
            Load += histoReq_Load;
            Resize += histoReq_Resize;
            ((System.ComponentModel.ISupportInitialize)histoDbg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView histoDbg;
    }
}