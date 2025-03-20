namespace WiGet
{
    partial class addHeaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addHeaderForm));
            addBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            nameTbx = new TextBox();
            valueTbx = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(61, 90);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Ajouter";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(169, 90);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Nom de l'en-tête:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Valeur:";
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(118, 12);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(183, 23);
            nameTbx.TabIndex = 4;
            // 
            // valueTbx
            // 
            valueTbx.Location = new Point(118, 50);
            valueTbx.Name = "valueTbx";
            valueTbx.Size = new Size(183, 23);
            valueTbx.TabIndex = 5;
            // 
            // addHeaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 130);
            Controls.Add(valueTbx);
            Controls.Add(nameTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addHeaderForm";
            Text = "Ajouter une en-tête";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Button cancelBtn;
        private Label label1;
        private Label label2;
        private TextBox nameTbx;
        private TextBox valueTbx;
    }
}