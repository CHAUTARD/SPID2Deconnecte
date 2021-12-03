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
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxNom = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxNbr = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxLibelleCourt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLibelleLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClubId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewClub = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBoxNum,
            this.toolStripTextBox2,
            this.toolStripTextBoxNom,
            this.toolStripTextBox3,
            this.toolStripTextBoxNbr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(102, 20);
            this.toolStripTextBox1.Text = "Numéro de club : ";
            // 
            // toolStripTextBoxNum
            // 
            this.toolStripTextBoxNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxNum.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripTextBoxNum.Name = "toolStripTextBoxNum";
            this.toolStripTextBoxNum.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxNum.TextChanged += new System.EventHandler(this.toolStripTextBoxNum_TextChanged);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(86, 20);
            this.toolStripTextBox2.Text = "Nom du club : ";
            // 
            // toolStripTextBoxNom
            // 
            this.toolStripTextBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBoxNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxNom.Name = "toolStripTextBoxNom";
            this.toolStripTextBoxNom.Size = new System.Drawing.Size(250, 23);
            this.toolStripTextBoxNom.TextChanged += new System.EventHandler(this.toolStripTextBoxNom_TextChanged_1);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Enabled = false;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(99, 20);
            this.toolStripTextBox3.Text = "Nombre de club :";
            // 
            // toolStripTextBoxNbr
            // 
            this.toolStripTextBoxNbr.Enabled = false;
            this.toolStripTextBoxNbr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxNbr.Name = "toolStripTextBoxNbr";
            this.toolStripTextBoxNbr.ReadOnly = true;
            this.toolStripTextBoxNbr.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxNbr.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Controls.Add(this.textBoxLibelleCourt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLibelleLong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxClubId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(767, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 553);
            this.panel1.TabIndex = 10;
            // 
            // buttonDel
            // 
            this.buttonDel.Image = global::SPID2Deconnecte.Properties.Resources.edit_clear;
            this.buttonDel.Location = new System.Drawing.Point(18, 497);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(221, 48);
            this.buttonDel.TabIndex = 21;
            this.buttonDel.Text = "Supprimer";
            this.buttonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = global::SPID2Deconnecte.Properties.Resources.document_save;
            this.buttonSave.Location = new System.Drawing.Point(18, 443);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(221, 48);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::SPID2Deconnecte.Properties.Resources.document_new1;
            this.buttonNew.Location = new System.Drawing.Point(18, 387);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(221, 50);
            this.buttonNew.TabIndex = 19;
            this.buttonNew.Text = "Nouveau";
            this.buttonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxLibelleCourt
            // 
            this.textBoxLibelleCourt.Enabled = false;
            this.textBoxLibelleCourt.Location = new System.Drawing.Point(14, 231);
            this.textBoxLibelleCourt.Name = "textBoxLibelleCourt";
            this.textBoxLibelleCourt.Size = new System.Drawing.Size(231, 20);
            this.textBoxLibelleCourt.TabIndex = 18;
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
            // textBoxLibelleLong
            // 
            this.textBoxLibelleLong.Enabled = false;
            this.textBoxLibelleLong.Location = new System.Drawing.Point(13, 157);
            this.textBoxLibelleLong.Name = "textBoxLibelleLong";
            this.textBoxLibelleLong.Size = new System.Drawing.Size(231, 20);
            this.textBoxLibelleLong.TabIndex = 16;
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
            // textBoxClubId
            // 
            this.textBoxClubId.Enabled = false;
            this.textBoxClubId.Location = new System.Drawing.Point(14, 25);
            this.textBoxClubId.Name = "textBoxClubId";
            this.textBoxClubId.Size = new System.Drawing.Size(230, 20);
            this.textBoxClubId.TabIndex = 12;
            this.textBoxClubId.TextChanged += new System.EventHandler(this.textBoxClubId_TextChanged);
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
            // dataGridViewClub
            // 
            this.dataGridViewClub.AllowUserToAddRows = false;
            this.dataGridViewClub.AllowUserToDeleteRows = false;
            this.dataGridViewClub.AllowUserToResizeRows = false;
            this.dataGridViewClub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClub.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewClub.MultiSelect = false;
            this.dataGridViewClub.Name = "dataGridViewClub";
            this.dataGridViewClub.ReadOnly = true;
            this.dataGridViewClub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClub.Size = new System.Drawing.Size(761, 547);
            this.dataGridViewClub.TabIndex = 11;
            this.dataGridViewClub.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewClub_RowStateChanged);
            // 
            // FormFindClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 595);
            this.Controls.Add(this.dataGridViewClub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormFindClub";
            this.Text = "E021 - Recherche des clubs";
            this.Load += new System.EventHandler(this.FormFindClub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxNum;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxNom;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxNbr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxLibelleCourt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLibelleLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClubId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClub;
    }
}