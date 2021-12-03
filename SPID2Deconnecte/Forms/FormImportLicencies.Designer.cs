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
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUploadFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonAbandon = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonParcourir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUploadFile);
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
            // buttonParcourir
            // 
            this.buttonParcourir.AutoSize = true;
            this.buttonParcourir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonParcourir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonParcourir.Image = ((System.Drawing.Image)(resources.GetObject("buttonParcourir.Image")));
            this.buttonParcourir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParcourir.Location = new System.Drawing.Point(607, 12);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(120, 73);
            this.buttonParcourir.TabIndex = 2;
            this.buttonParcourir.Text = "&Parcourir";
            this.buttonParcourir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonParcourir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
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
            // textBoxUploadFile
            // 
            this.textBoxUploadFile.Enabled = false;
            this.textBoxUploadFile.Location = new System.Drawing.Point(115, 35);
            this.textBoxUploadFile.Name = "textBoxUploadFile";
            this.textBoxUploadFile.Size = new System.Drawing.Size(486, 20);
            this.textBoxUploadFile.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMessage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(0, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat de l\'import du référentiel";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Location = new System.Drawing.Point(3, 16);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(731, 289);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonAbandon
            // 
            this.buttonAbandon.AutoSize = true;
            this.buttonAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbandon.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbandon.Image")));
            this.buttonAbandon.Location = new System.Drawing.Point(404, 406);
            this.buttonAbandon.Name = "buttonAbandon";
            this.buttonAbandon.Size = new System.Drawing.Size(120, 54);
            this.buttonAbandon.TabIndex = 6;
            this.buttonAbandon.Text = "Abandon";
            this.buttonAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbandon.UseVisualStyleBackColor = true;
            this.buttonAbandon.Click += new System.EventHandler(this.buttonAbandon_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.Location = new System.Drawing.Point(151, 406);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(120, 54);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "Importation";
            this.buttonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // FormImportLicencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAbandon);
            this.Controls.Add(this.buttonImport);
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
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUploadFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonAbandon;
        private System.Windows.Forms.Button buttonImport;
    }
}