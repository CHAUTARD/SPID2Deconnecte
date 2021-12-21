namespace SPID2Deconnecte.Forms
{
    partial class FormMAJBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMAJBase));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonAbandon = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(22, 70);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(143, 137);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ButtonAbandon
            // 
            this.ButtonAbandon.AutoSize = true;
            this.ButtonAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAbandon.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAbandon.Image")));
            this.ButtonAbandon.Location = new System.Drawing.Point(408, 312);
            this.ButtonAbandon.Name = "ButtonAbandon";
            this.ButtonAbandon.Size = new System.Drawing.Size(120, 54);
            this.ButtonAbandon.TabIndex = 8;
            this.ButtonAbandon.Text = "Abandon";
            this.ButtonAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAbandon.UseVisualStyleBackColor = true;
            this.ButtonAbandon.Click += new System.EventHandler(this.ButtonAbandon_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.Enabled = false;
            this.ButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("ButtonImport.Image")));
            this.ButtonImport.Location = new System.Drawing.Point(160, 312);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(120, 54);
            this.ButtonImport.TabIndex = 7;
            this.ButtonImport.Text = "Importation";
            this.ButtonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(183, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(502, 240);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // FormMAJBase
            // 
            this.AcceptButton = this.ButtonImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonAbandon;
            this.ClientSize = new System.Drawing.Size(708, 393);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ButtonAbandon);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMAJBase";
            this.Text = "Initialisation de la base de donnée";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button ButtonAbandon;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}