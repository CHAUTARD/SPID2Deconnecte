namespace SPID2Deconnecte.Forms
{
    partial class FormFindClub
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindClub));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBoxNum = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripTextBox2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBoxNom = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripTextBox3 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBoxNbr = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.TextBoxLibelleCourt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxLibelleLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxClubId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewClub = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClub)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripTextBox1,
            this.ToolStripTextBoxNum,
            this.ToolStripTextBox2,
            this.ToolStripTextBoxNom,
            this.ToolStripTextBox3,
            this.ToolStripTextBoxNbr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ToolStripTextBox1.Enabled = false;
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(102, 20);
            this.ToolStripTextBox1.Text = "Numéro de club : ";
            // 
            // ToolStripTextBoxNum
            // 
            this.ToolStripTextBoxNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBoxNum.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ToolStripTextBoxNum.Name = "ToolStripTextBoxNum";
            this.ToolStripTextBoxNum.Size = new System.Drawing.Size(100, 23);
            this.ToolStripTextBoxNum.TextChanged += new System.EventHandler(this.ToolStripTextBoxNum_TextChanged);
            // 
            // ToolStripTextBox2
            // 
            this.ToolStripTextBox2.Enabled = false;
            this.ToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox2.Name = "ToolStripTextBox2";
            this.ToolStripTextBox2.Size = new System.Drawing.Size(86, 20);
            this.ToolStripTextBox2.Text = "Nom du club : ";
            // 
            // ToolStripTextBoxNom
            // 
            this.ToolStripTextBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ToolStripTextBoxNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBoxNom.Name = "ToolStripTextBoxNom";
            this.ToolStripTextBoxNom.Size = new System.Drawing.Size(250, 23);
            this.ToolStripTextBoxNom.TextChanged += new System.EventHandler(this.ToolStripTextBoxNom_TextChanged_1);
            // 
            // ToolStripTextBox3
            // 
            this.ToolStripTextBox3.Enabled = false;
            this.ToolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox3.Name = "ToolStripTextBox3";
            this.ToolStripTextBox3.Size = new System.Drawing.Size(99, 20);
            this.ToolStripTextBox3.Text = "Nombre de club :";
            // 
            // ToolStripTextBoxNbr
            // 
            this.ToolStripTextBoxNbr.Enabled = false;
            this.ToolStripTextBoxNbr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBoxNbr.Name = "ToolStripTextBoxNbr";
            this.ToolStripTextBoxNbr.ReadOnly = true;
            this.ToolStripTextBoxNbr.Size = new System.Drawing.Size(100, 23);
            this.ToolStripTextBoxNbr.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ButtonDel);
            this.panel1.Controls.Add(this.ButtonSave);
            this.panel1.Controls.Add(this.ButtonNew);
            this.panel1.Controls.Add(this.TextBoxLibelleCourt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBoxLibelleLong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxClubId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(767, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 553);
            this.panel1.TabIndex = 10;
            // 
            // ButtonDel
            // 
            this.ButtonDel.Image = global::SPID2Deconnecte.Properties.Resources.edit_clear;
            this.ButtonDel.Location = new System.Drawing.Point(18, 497);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(221, 48);
            this.ButtonDel.TabIndex = 21;
            this.ButtonDel.Text = "Supprimer";
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Image = global::SPID2Deconnecte.Properties.Resources.document_save;
            this.ButtonSave.Location = new System.Drawing.Point(18, 443);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(221, 48);
            this.ButtonSave.TabIndex = 20;
            this.ButtonSave.Text = "Enregistrer";
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Image = global::SPID2Deconnecte.Properties.Resources.document_new1;
            this.ButtonNew.Location = new System.Drawing.Point(18, 387);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(221, 50);
            this.ButtonNew.TabIndex = 19;
            this.ButtonNew.Text = "Nouveau";
            this.ButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // TextBoxLibelleCourt
            // 
            this.TextBoxLibelleCourt.Enabled = false;
            this.TextBoxLibelleCourt.Location = new System.Drawing.Point(14, 231);
            this.TextBoxLibelleCourt.Name = "TextBoxLibelleCourt";
            this.TextBoxLibelleCourt.Size = new System.Drawing.Size(231, 20);
            this.TextBoxLibelleCourt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Libellé court * :";
            // 
            // TextBoxLibelleLong
            // 
            this.TextBoxLibelleLong.Enabled = false;
            this.TextBoxLibelleLong.Location = new System.Drawing.Point(13, 157);
            this.TextBoxLibelleLong.Name = "TextBoxLibelleLong";
            this.TextBoxLibelleLong.Size = new System.Drawing.Size(231, 20);
            this.TextBoxLibelleLong.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Libellé long * :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Enabled = false;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Libre",
            "Mixte"});
            this.comboBoxType.Location = new System.Drawing.Point(13, 83);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(231, 21);
            this.comboBoxType.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type :";
            // 
            // TextBoxClubId
            // 
            this.TextBoxClubId.Enabled = false;
            this.TextBoxClubId.Location = new System.Drawing.Point(14, 25);
            this.TextBoxClubId.Name = "TextBoxClubId";
            this.TextBoxClubId.Size = new System.Drawing.Size(230, 20);
            this.TextBoxClubId.TabIndex = 12;
            this.TextBoxClubId.TextChanged += new System.EventHandler(this.TextBoxClubId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numéro de club * :";
            // 
            // DataGridViewClub
            // 
            this.DataGridViewClub.AllowUserToAddRows = false;
            this.DataGridViewClub.AllowUserToDeleteRows = false;
            this.DataGridViewClub.AllowUserToResizeRows = false;
            this.DataGridViewClub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClub.Location = new System.Drawing.Point(0, 30);
            this.DataGridViewClub.MultiSelect = false;
            this.DataGridViewClub.Name = "DataGridViewClub";
            this.DataGridViewClub.ReadOnly = true;
            this.DataGridViewClub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClub.Size = new System.Drawing.Size(761, 547);
            this.DataGridViewClub.TabIndex = 11;
            this.DataGridViewClub.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridViewClub_RowStateChanged);
            // 
            // FormFindClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 595);
            this.Controls.Add(this.DataGridViewClub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormFindClub";
            this.Text = "E021 - Recherche des clubs";
            this.Load += new System.EventHandler(this.FormFindClub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripLabel ToolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBoxNum;
        private System.Windows.Forms.ToolStripLabel ToolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBoxNom;
        private System.Windows.Forms.ToolStripLabel ToolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBoxNbr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.TextBox TextBoxLibelleCourt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxLibelleLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxClubId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewClub;
    }
}