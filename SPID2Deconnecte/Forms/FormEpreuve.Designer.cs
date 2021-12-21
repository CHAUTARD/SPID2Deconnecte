namespace SPID2Deconnecte.Forms
{
    partial class FormEpreuve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEpreuve));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLibelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxOrganisme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RichTextBoxCommentaire = new System.Windows.Forms.RichTextBox();
            this.ButtonAbandon = new System.Windows.Forms.Button();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code épreuve :";
            // 
            // TextBoxCD
            // 
            this.TextBoxCD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxCD.Enabled = false;
            this.TextBoxCD.Location = new System.Drawing.Point(137, 23);
            this.TextBoxCD.Name = "TextBoxCD";
            this.TextBoxCD.Size = new System.Drawing.Size(44, 20);
            this.TextBoxCD.TabIndex = 6;
            this.TextBoxCD.Text = "L";
            this.TextBoxCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(289, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code libellé * :";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Location = new System.Drawing.Point(385, 22);
            this.TextBoxCode.MaxLength = 5;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCode.TabIndex = 8;
            this.TextBoxCode.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Libellé * :";
            // 
            // TextBoxLibelle
            // 
            this.TextBoxLibelle.Location = new System.Drawing.Point(137, 63);
            this.TextBoxLibelle.MaxLength = 32;
            this.TextBoxLibelle.Name = "TextBoxLibelle";
            this.TextBoxLibelle.Size = new System.Drawing.Size(348, 20);
            this.TextBoxLibelle.TabIndex = 10;
            this.TextBoxLibelle.TextChanged += new System.EventHandler(this.TextBoxLibelle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Organisme :";
            // 
            // TextBoxOrganisme
            // 
            this.TextBoxOrganisme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxOrganisme.Enabled = false;
            this.TextBoxOrganisme.Location = new System.Drawing.Point(137, 99);
            this.TextBoxOrganisme.Name = "TextBoxOrganisme";
            this.TextBoxOrganisme.Size = new System.Drawing.Size(348, 20);
            this.TextBoxOrganisme.TabIndex = 12;
            this.TextBoxOrganisme.Text = "Local";
            this.TextBoxOrganisme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Commentaires :";
            // 
            // RichTextBoxCommentaire
            // 
            this.RichTextBoxCommentaire.Location = new System.Drawing.Point(137, 147);
            this.RichTextBoxCommentaire.Name = "RichTextBoxCommentaire";
            this.RichTextBoxCommentaire.Size = new System.Drawing.Size(347, 143);
            this.RichTextBoxCommentaire.TabIndex = 14;
            this.RichTextBoxCommentaire.Text = "";
            // 
            // ButtonAbandon
            // 
            this.ButtonAbandon.AutoSize = true;
            this.ButtonAbandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAbandon.Image = global::SPID2Deconnecte.Properties.Resources.cance_32l;
            this.ButtonAbandon.Location = new System.Drawing.Point(364, 312);
            this.ButtonAbandon.Name = "ButtonAbandon";
            this.ButtonAbandon.Size = new System.Drawing.Size(120, 54);
            this.ButtonAbandon.TabIndex = 4;
            this.ButtonAbandon.Text = "Abandon";
            this.ButtonAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAbandon.UseVisualStyleBackColor = true;
            this.ButtonAbandon.Click += new System.EventHandler(this.ButtonAbandon_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.Enabled = false;
            this.ButtonValider.Image = global::SPID2Deconnecte.Properties.Resources.OK_32;
            this.ButtonValider.Location = new System.Drawing.Point(55, 312);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(120, 54);
            this.ButtonValider.TabIndex = 3;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // FormEpreuve
            // 
            this.AcceptButton = this.ButtonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.ButtonAbandon;
            this.ClientSize = new System.Drawing.Size(538, 375);
            this.Controls.Add(this.RichTextBoxCommentaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxOrganisme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxLibelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAbandon);
            this.Controls.Add(this.ButtonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEpreuve";
            this.Text = "E004 - Fiche épreuve";
            this.Load += new System.EventHandler(this.FormEpreuve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAbandon;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLibelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxOrganisme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RichTextBoxCommentaire;
    }
}