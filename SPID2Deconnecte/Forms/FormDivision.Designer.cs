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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxNbPointManche = new System.Windows.Forms.TextBox();
            this.TextBoxNbManchePoule = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxNbMancheTableau = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxPointMin = new System.Windows.Forms.TextBox();
            this.TextBoxNbPointMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxCategorie = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.TextBoxCodeOrganisme.Size = new System.Drawing.Size(44, 20);
            this.TextBoxCodeOrganisme.TabIndex = 18;
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
            this.ButtonAbandon.Location = new System.Drawing.Point(703, 351);
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
            this.buttonValider.Location = new System.Drawing.Point(55, 352);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(120, 54);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.Text = "Valider";
            this.buttonValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValider.UseVisualStyleBackColor = true;
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
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(132, 56);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(178, 21);
            this.comboBoxCategorie.TabIndex = 29;
            // 
            // checkBoxCorporative
            // 
            this.checkBoxCorporative.AutoSize = true;
            this.checkBoxCorporative.Location = new System.Drawing.Point(520, 60);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Féminin",
            "Masculin",
            "Mixte"});
            this.comboBox1.Location = new System.Drawing.Point(132, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Nb de points d\'une manche * :";
            // 
            // TextBoxNbPointManche
            // 
            this.TextBoxNbPointManche.Location = new System.Drawing.Point(558, 88);
            this.TextBoxNbPointManche.Name = "TextBoxNbPointManche";
            this.TextBoxNbPointManche.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNbPointManche.TabIndex = 36;
            // 
            // TextBoxNbManchePoule
            // 
            this.TextBoxNbManchePoule.Location = new System.Drawing.Point(224, 121);
            this.TextBoxNbManchePoule.Name = "TextBoxNbManchePoule";
            this.TextBoxNbManchePoule.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNbManchePoule.TabIndex = 37;
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
            // TextBoxNbMancheTableau
            // 
            this.TextBoxNbMancheTableau.Location = new System.Drawing.Point(558, 122);
            this.TextBoxNbMancheTableau.Name = "TextBoxNbMancheTableau";
            this.TextBoxNbMancheTableau.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNbMancheTableau.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Nb de points min * :";
            // 
            // TextBoxPointMin
            // 
            this.TextBoxPointMin.Location = new System.Drawing.Point(224, 152);
            this.TextBoxPointMin.Name = "TextBoxPointMin";
            this.TextBoxPointMin.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPointMin.TabIndex = 41;
            this.TextBoxPointMin.Text = "0";
            this.TextBoxPointMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxNbPointMax
            // 
            this.TextBoxNbPointMax.Location = new System.Drawing.Point(558, 155);
            this.TextBoxNbPointMax.Name = "TextBoxNbPointMax";
            this.TextBoxNbPointMax.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNbPointMax.TabIndex = 43;
            this.TextBoxNbPointMax.Text = "10000";
            this.TextBoxNbPointMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nb de points max * :";
            // 
            // checkedListBoxCategorie
            // 
            this.checkedListBoxCategorie.FormattingEnabled = true;
            this.checkedListBoxCategorie.Location = new System.Drawing.Point(558, 203);
            this.checkedListBoxCategorie.Name = "checkedListBoxCategorie";
            this.checkedListBoxCategorie.Size = new System.Drawing.Size(310, 139);
            this.checkedListBoxCategorie.TabIndex = 44;
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
            // FormDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 409);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkedListBoxCategorie);
            this.Controls.Add(this.TextBoxNbPointMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxPointMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBoxNbMancheTableau);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxNbManchePoule);
            this.Controls.Add(this.TextBoxNbPointManche);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxNbPointManche;
        private System.Windows.Forms.TextBox TextBoxNbManchePoule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxNbMancheTableau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxPointMin;
        private System.Windows.Forms.TextBox TextBoxNbPointMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategorie;
        private System.Windows.Forms.Label label12;
    }
}