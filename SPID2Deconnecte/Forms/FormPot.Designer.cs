namespace SPID2Deconnecte.Forms
{
    partial class FormPot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPot));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBoxParties = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Horaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNbTableMontees = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxDebut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxIntervalle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxTablesAffichees = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonSauver = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxTablesAffichees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ComboBoxIntervalle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBoxDebut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxNbTableMontees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxLibelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations générales";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListBoxParties);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(804, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 428);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des parties";
            // 
            // ListBoxParties
            // 
            this.ListBoxParties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxParties.FormattingEnabled = true;
            this.ListBoxParties.Items.AddRange(new object[] {
            "P1 - 1 / 4",
            "P1 - 2 / 3",
            "P1 - 1 / 3",
            "P1 - 2 / 4",
            "P1 - 1 / 2",
            "P1 - 3 / 4"});
            this.ListBoxParties.Location = new System.Drawing.Point(3, 16);
            this.ListBoxParties.Name = "ListBoxParties";
            this.ListBoxParties.Size = new System.Drawing.Size(158, 409);
            this.ListBoxParties.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horaire,
            this.Util,
            this.Monter,
            this.Table_1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 428);
            this.dataGridView1.TabIndex = 3;
            // 
            // Horaire
            // 
            this.Horaire.Frozen = true;
            this.Horaire.HeaderText = "Horaire";
            this.Horaire.Name = "Horaire";
            this.Horaire.ReadOnly = true;
            // 
            // Util
            // 
            this.Util.Frozen = true;
            this.Util.HeaderText = "Util";
            this.Util.Name = "Util";
            this.Util.ReadOnly = true;
            this.Util.Width = 30;
            // 
            // Monter
            // 
            this.Monter.Frozen = true;
            this.Monter.HeaderText = "Mont";
            this.Monter.Name = "Monter";
            this.Monter.ReadOnly = true;
            this.Monter.Width = 30;
            // 
            // Table_1
            // 
            this.Table_1.Frozen = true;
            this.Table_1.HeaderText = "Table 1";
            this.Table_1.Name = "Table_1";
            this.Table_1.ReadOnly = true;
            this.Table_1.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé * :";
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(67, 12);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(205, 20);
            this.textBoxLibelle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date * :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 11);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nb de table montées * :";
            // 
            // comboBoxNbTableMontees
            // 
            this.comboBoxNbTableMontees.FormattingEnabled = true;
            this.comboBoxNbTableMontees.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNbTableMontees.Location = new System.Drawing.Point(651, 11);
            this.comboBoxNbTableMontees.Name = "comboBoxNbTableMontees";
            this.comboBoxNbTableMontees.Size = new System.Drawing.Size(78, 21);
            this.comboBoxNbTableMontees.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nb d\'horaires * :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Début * :";
            // 
            // ComboBoxDebut
            // 
            this.ComboBoxDebut.FormattingEnabled = true;
            this.ComboBoxDebut.Location = new System.Drawing.Point(278, 41);
            this.ComboBoxDebut.Name = "ComboBoxDebut";
            this.ComboBoxDebut.Size = new System.Drawing.Size(84, 21);
            this.ComboBoxDebut.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Intervalle * :";
            // 
            // ComboBoxIntervalle
            // 
            this.ComboBoxIntervalle.FormattingEnabled = true;
            this.ComboBoxIntervalle.Items.AddRange(new object[] {
            "20 mn",
            "25 mn",
            "30 mn",
            "35 mn",
            "40 mn",
            "45 mn",
            "50 mn",
            "55 mn",
            "60 mn"});
            this.ComboBoxIntervalle.Location = new System.Drawing.Point(445, 42);
            this.ComboBoxIntervalle.Name = "ComboBoxIntervalle";
            this.ComboBoxIntervalle.Size = new System.Drawing.Size(96, 21);
            this.ComboBoxIntervalle.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tables affichées * :";
            // 
            // ComboBoxTablesAffichees
            // 
            this.ComboBoxTablesAffichees.FormattingEnabled = true;
            this.ComboBoxTablesAffichees.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxTablesAffichees.Location = new System.Drawing.Point(653, 41);
            this.ComboBoxTablesAffichees.Name = "ComboBoxTablesAffichees";
            this.ComboBoxTablesAffichees.Size = new System.Drawing.Size(76, 21);
            this.ComboBoxTablesAffichees.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.ButtonSauver);
            this.groupBox2.Location = new System.Drawing.Point(804, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Validate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Choix du tableau :";
            // 
            // ButtonSauver
            // 
            this.ButtonSauver.Image = global::SPID2Deconnecte.Properties.Resources.Validate_64;
            this.ButtonSauver.Location = new System.Drawing.Point(97, 0);
            this.ButtonSauver.Name = "ButtonSauver";
            this.ButtonSauver.Size = new System.Drawing.Size(70, 70);
            this.ButtonSauver.TabIndex = 0;
            this.ButtonSauver.Tag = "Validate";
            this.ButtonSauver.UseVisualStyleBackColor = true;
            this.ButtonSauver.Click += new System.EventHandler(this.ButtonSauver_Click);
            // 
            // FormPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormPot";
            this.Text = "E018 - Plan d\'Occupation des Tables";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListBoxParties;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboBoxTablesAffichees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxIntervalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxDebut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNbTableMontees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonSauver;
    }
}