namespace SPID2Deconnecte.Forms
{
    partial class FormDivision
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDivision));
            this.richTextBoxCommentaire = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxLibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCodeDivision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCodeOrganisme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAbandon = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.checkBoxCorporative = new System.Windows.Forms.CheckBox();
            this.checkBoxDouble = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericPointManche = new System.Windows.Forms.NumericUpDown();
            this.numericNbManchePoule = new System.Windows.Forms.NumericUpDown();
            this.numericNbMancheTableau = new System.Windows.Forms.NumericUpDown();
            this.numericPointMin = new System.Windows.Forms.NumericUpDown();
            this.numericNbPointMax = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTypeLicence = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBareme = new System.Windows.Forms.TextBox();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonCheckOff = new System.Windows.Forms.Button();
            this.checkedListBoxCategorie = new SPID2Deconnecte.ColorCodedCheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericPointManche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbManchePoule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbMancheTableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPointMax)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxCommentaire
            // 
            this.richTextBoxCommentaire.Location = new System.Drawing.Point(15, 203);
            this.richTextBoxCommentaire.Name = "richTextBoxCommentaire";
            this.richTextBoxCommentaire.Size = new System.Drawing.Size(526, 143);
            this.richTextBoxCommentaire.TabIndex = 26;
            this.richTextBoxCommentaire.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Commentaires :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nb de manches en saisie pour les poules :";
            // 
            // TextBoxLibelle
            // 
            this.TextBoxLibelle.Location = new System.Drawing.Point(520, 27);
            this.TextBoxLibelle.Name = "TextBoxLibelle";
            this.TextBoxLibelle.Size = new System.Drawing.Size(348, 20);
            this.TextBoxLibelle.TabIndex = 22;
            this.TextBoxLibelle.TextChanged += new System.EventHandler(this.TextBoxLibelle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Libellé * :";
            // 
            // TextBoxCodeDivision
            // 
            this.TextBoxCodeDivision.Location = new System.Drawing.Point(316, 26);
            this.TextBoxCodeDivision.Name = "TextBoxCodeDivision";
            this.TextBoxCodeDivision.Size = new System.Drawing.Size(83, 20);
            this.TextBoxCodeDivision.TabIndex = 20;
            this.TextBoxCodeDivision.TextChanged += new System.EventHandler(this.TextBoxCodeDivision_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(210, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code division * :";
            // 
            // TextBoxCodeOrganisme
            // 
            this.TextBoxCodeOrganisme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxCodeOrganisme.Enabled = false;
            this.TextBoxCodeOrganisme.Location = new System.Drawing.Point(132, 27);
            this.TextBoxCodeOrganisme.Name = "TextBoxCodeOrganisme";
            this.TextBoxCodeOrganisme.Size = new System.Drawing.Size(62, 20);
            this.TextBoxCodeOrganisme.TabIndex = 18;
            this.TextBoxCodeOrganisme.Text = "LOCAL";
            this.TextBoxCodeOrganisme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Code organisme :";
            // 
            // ButtonAbandon
            // 
            this.ButtonAbandon.AutoSize = true;
            this.ButtonAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAbandon.Image = global::SPID2Deconnecte.Properties.Resources.cance_32l;
            this.ButtonAbandon.Location = new System.Drawing.Point(645, 352);
            this.ButtonAbandon.Name = "ButtonAbandon";
            this.ButtonAbandon.Size = new System.Drawing.Size(120, 54);
            this.ButtonAbandon.TabIndex = 16;
            this.ButtonAbandon.Text = "Abandon";
            this.ButtonAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAbandon.UseVisualStyleBackColor = true;
            this.ButtonAbandon.Click += new System.EventHandler(this.ButtonAbandon_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Image = global::SPID2Deconnecte.Properties.Resources.OK_32;
            this.buttonValider.Location = new System.Drawing.Point(98, 352);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(120, 54);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.Text = "Valider";
            this.buttonValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Catégorie :";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(132, 56);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(178, 21);
            this.comboBoxCategorie.TabIndex = 29;
            // 
            // checkBoxCorporative
            // 
            this.checkBoxCorporative.AutoSize = true;
            this.checkBoxCorporative.Location = new System.Drawing.Point(645, 62);
            this.checkBoxCorporative.Name = "checkBoxCorporative";
            this.checkBoxCorporative.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCorporative.TabIndex = 31;
            this.checkBoxCorporative.Text = "Corporative";
            this.checkBoxCorporative.UseVisualStyleBackColor = true;
            // 
            // checkBoxDouble
            // 
            this.checkBoxDouble.AutoSize = true;
            this.checkBoxDouble.Location = new System.Drawing.Point(746, 64);
            this.checkBoxDouble.Name = "checkBoxDouble";
            this.checkBoxDouble.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDouble.TabIndex = 32;
            this.checkBoxDouble.Text = "Gestion des doubles";
            this.checkBoxDouble.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Sexe :";
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(132, 88);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(86, 21);
            this.comboBoxSexe.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Nb de points d\'une manche * :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nb de manches en saisie pour le tableau :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Nb de points min :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nb de points max :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Catégories authorisées :";
            // 
            // numericPointManche
            // 
            this.numericPointManche.Location = new System.Drawing.Point(415, 94);
            this.numericPointManche.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericPointManche.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPointManche.Name = "numericPointManche";
            this.numericPointManche.Size = new System.Drawing.Size(120, 20);
            this.numericPointManche.TabIndex = 46;
            this.numericPointManche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPointManche.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericPointManche.ValueChanged += new System.EventHandler(this.numericPointManche_ValueChanged);
            // 
            // numericNbManchePoule
            // 
            this.numericNbManchePoule.Location = new System.Drawing.Point(224, 116);
            this.numericNbManchePoule.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericNbManchePoule.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNbManchePoule.Name = "numericNbManchePoule";
            this.numericNbManchePoule.Size = new System.Drawing.Size(100, 20);
            this.numericNbManchePoule.TabIndex = 47;
            this.numericNbManchePoule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNbManchePoule.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericNbMancheTableau
            // 
            this.numericNbMancheTableau.Location = new System.Drawing.Point(559, 124);
            this.numericNbMancheTableau.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericNbMancheTableau.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNbMancheTableau.Name = "numericNbMancheTableau";
            this.numericNbMancheTableau.Size = new System.Drawing.Size(120, 20);
            this.numericNbMancheTableau.TabIndex = 48;
            this.numericNbMancheTableau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNbMancheTableau.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericPointMin
            // 
            this.numericPointMin.Location = new System.Drawing.Point(224, 154);
            this.numericPointMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPointMin.Name = "numericPointMin";
            this.numericPointMin.Size = new System.Drawing.Size(100, 20);
            this.numericPointMin.TabIndex = 49;
            this.numericPointMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericNbPointMax
            // 
            this.numericNbPointMax.Location = new System.Drawing.Point(558, 158);
            this.numericNbPointMax.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericNbPointMax.Name = "numericNbPointMax";
            this.numericNbPointMax.Size = new System.Drawing.Size(120, 20);
            this.numericNbPointMax.TabIndex = 50;
            this.numericNbPointMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNbPointMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Type de licence :";
            this.label13.Visible = false;
            // 
            // textBoxTypeLicence
            // 
            this.textBoxTypeLicence.Enabled = false;
            this.textBoxTypeLicence.Location = new System.Drawing.Point(446, 56);
            this.textBoxTypeLicence.Name = "textBoxTypeLicence";
            this.textBoxTypeLicence.Size = new System.Drawing.Size(144, 20);
            this.textBoxTypeLicence.TabIndex = 52;
            this.textBoxTypeLicence.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(559, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Barême :";
            this.label14.Visible = false;
            // 
            // textBoxBareme
            // 
            this.textBoxBareme.Enabled = false;
            this.textBoxBareme.Location = new System.Drawing.Point(615, 93);
            this.textBoxBareme.Name = "textBoxBareme";
            this.textBoxBareme.Size = new System.Drawing.Size(253, 20);
            this.textBoxBareme.TabIndex = 54;
            this.textBoxBareme.Visible = false;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckAll.Image")));
            this.buttonCheckAll.Location = new System.Drawing.Point(806, 175);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(28, 25);
            this.buttonCheckAll.TabIndex = 55;
            this.toolTip1.SetToolTip(this.buttonCheckAll, "Sélectionner tous");
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonCheckOff
            // 
            this.buttonCheckOff.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckOff.Image")));
            this.buttonCheckOff.Location = new System.Drawing.Point(840, 175);
            this.buttonCheckOff.Name = "buttonCheckOff";
            this.buttonCheckOff.Size = new System.Drawing.Size(28, 25);
            this.buttonCheckOff.TabIndex = 56;
            this.toolTip2.SetToolTip(this.buttonCheckOff, "Désélectionner tous");
            this.buttonCheckOff.UseVisualStyleBackColor = true;
            this.buttonCheckOff.Click += new System.EventHandler(this.buttonCheckOff_Click);
            // 
            // checkedListBoxCategorie
            // 
            this.checkedListBoxCategorie.CheckedColor = System.Drawing.Color.Red;
            this.checkedListBoxCategorie.CheckOnClick = true;
            this.checkedListBoxCategorie.FormattingEnabled = true;
            this.checkedListBoxCategorie.IndeterminateColor = System.Drawing.Color.Orange;
            this.checkedListBoxCategorie.Location = new System.Drawing.Point(558, 203);
            this.checkedListBoxCategorie.Name = "checkedListBoxCategorie";
            this.checkedListBoxCategorie.Size = new System.Drawing.Size(310, 139);
            this.checkedListBoxCategorie.TabIndex = 44;
            this.checkedListBoxCategorie.UncheckedColor = System.Drawing.Color.Green;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Catégories";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Catégories";
            // 
            // FormDivision
            // 
            this.AcceptButton = this.buttonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonAbandon;
            this.ClientSize = new System.Drawing.Size(888, 409);
            this.Controls.Add(this.buttonCheckOff);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.textBoxBareme);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxTypeLicence);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericNbPointMax);
            this.Controls.Add(this.numericPointMin);
            this.Controls.Add(this.numericNbMancheTableau);
            this.Controls.Add(this.numericNbManchePoule);
            this.Controls.Add(this.numericPointManche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkedListBoxCategorie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxDouble);
            this.Controls.Add(this.checkBoxCorporative);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxCommentaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxLibelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxCodeDivision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCodeOrganisme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAbandon);
            this.Controls.Add(this.buttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDivision";
            this.Text = "E005 - Fiche d\'une division";
            ((System.ComponentModel.ISupportInitialize)(this.numericPointManche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbManchePoule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbMancheTableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPointMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCommentaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCodeDivision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCodeOrganisme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAbandon;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.CheckBox checkBoxCorporative;
        private System.Windows.Forms.CheckBox checkBoxDouble;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericPointManche;
        private System.Windows.Forms.NumericUpDown numericNbManchePoule;
        private System.Windows.Forms.NumericUpDown numericNbMancheTableau;
        private System.Windows.Forms.NumericUpDown numericPointMin;
        private System.Windows.Forms.NumericUpDown numericNbPointMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTypeLicence;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBareme;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonCheckOff;
        private ColorCodedCheckedListBox checkedListBoxCategorie;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}