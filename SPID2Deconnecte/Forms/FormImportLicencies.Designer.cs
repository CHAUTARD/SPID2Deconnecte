namespace SPID2Deconnecte.Forms
{
    partial class FormImportLicencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportLicencies));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonParcourir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUploadFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButtonAbandon = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonParcourir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxUploadFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélection du fichier à importer (  généré à partir de SPID )";
            // 
            // ButtonParcourir
            // 
            this.ButtonParcourir.AutoSize = true;
            this.ButtonParcourir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonParcourir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonParcourir.Image = ((System.Drawing.Image)(resources.GetObject("ButtonParcourir.Image")));
            this.ButtonParcourir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonParcourir.Location = new System.Drawing.Point(607, 12);
            this.ButtonParcourir.Name = "ButtonParcourir";
            this.ButtonParcourir.Size = new System.Drawing.Size(120, 73);
            this.ButtonParcourir.TabIndex = 2;
            this.ButtonParcourir.Text = "&Parcourir";
            this.ButtonParcourir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonParcourir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonParcourir.UseVisualStyleBackColor = true;
            this.ButtonParcourir.Click += new System.EventHandler(this.ButtonParcourir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du fichier :";
            // 
            // TextBoxUploadFile
            // 
            this.TextBoxUploadFile.Enabled = false;
            this.TextBoxUploadFile.Location = new System.Drawing.Point(115, 35);
            this.TextBoxUploadFile.Name = "TextBoxUploadFile";
            this.TextBoxUploadFile.Size = new System.Drawing.Size(486, 20);
            this.TextBoxUploadFile.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxMessage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(0, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat de l\'import des licenciés et des clubs";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMessage.Location = new System.Drawing.Point(3, 16);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(10);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMessage.Size = new System.Drawing.Size(731, 289);
            this.TextBoxMessage.TabIndex = 0;
            // 
            // ButtonAbandon
            // 
            this.ButtonAbandon.AutoSize = true;
            this.ButtonAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAbandon.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAbandon.Image")));
            this.ButtonAbandon.Location = new System.Drawing.Point(404, 406);
            this.ButtonAbandon.Name = "ButtonAbandon";
            this.ButtonAbandon.Size = new System.Drawing.Size(120, 54);
            this.ButtonAbandon.TabIndex = 6;
            this.ButtonAbandon.Text = "Abandon";
            this.ButtonAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAbandon.UseVisualStyleBackColor = true;
            this.ButtonAbandon.Click += new System.EventHandler(this.ButtonAbandon_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.Enabled = false;
            this.ButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("ButtonImport.Image")));
            this.ButtonImport.Location = new System.Drawing.Point(151, 406);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(120, 54);
            this.ButtonImport.TabIndex = 5;
            this.ButtonImport.Text = "Importation";
            this.ButtonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // FormImportLicencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonAbandon);
            this.Controls.Add(this.ButtonImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportLicencies";
            this.Text = "E024 - Importation licences et clubs  SPID  - SPIDD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonParcourir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUploadFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButtonAbandon;
        private System.Windows.Forms.Button ButtonImport;
    }
}