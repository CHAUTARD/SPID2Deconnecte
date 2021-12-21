using System;
using System.Windows.Forms;
using SPID2Deconnecte.CRUD;

namespace SPID2Deconnecte.Forms
{
    public partial class FormEpreuve : Form
    {
        // Epreuve sélectionné dans la TreeView
        private EpreuveCrud epreuveCrud = new EpreuveCrud();

        public FormEpreuve()
        {
            InitializeComponent();
        }

        public FormEpreuve(string sTag)
        {
            InitializeComponent();

            Tag = sTag;           
        }

        internal void SetData(EpreuveCrud treeEpreuve)
        {
            epreuveCrud = treeEpreuve;

            // Recherche de l'organisme
            OrganismeCrud organismeCrud = new OrganismeCrud(epreuveCrud.ORGA_ID);

            TextBoxCD.Text = epreuveCrud.EPRV_CD;
            TextBoxCode.Text = epreuveCrud.EPRV_LB_COURT;
            TextBoxOrganisme.Text = organismeCrud.ORGA_LB;
            TextBoxLibelle.Text = epreuveCrud.EPRV_LB;
            RichTextBoxCommentaire.Text= epreuveCrud.EPRV_CM;
        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            // Mise a jour ou sauvegarde
            epreuveCrud.EPRV_CD = TextBoxCD.Text;
            epreuveCrud.EPRV_LB_COURT = TextBoxCode.Text.Trim();
            epreuveCrud.EPRV_LB = TextBoxLibelle.Text.Trim();
            epreuveCrud.EPRV_CM = RichTextBoxCommentaire.Text.Trim();
            
            if("CREER".CompareTo(Tag) == 0)
            {
                epreuveCrud.Insert();
            }
            else
            {
                epreuveCrud.Update();
            }

            MessageBox.Show("Sauvegarde effectuée", "Epreuve");
            Close();
        }

        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {
             EnableValider();
        }

        private void TextBoxLibelle_TextChanged(object sender, EventArgs e)
        {
            EnableValider();
        }

        private void EnableValider()
        {
            ButtonValider.Enabled = (TextBoxCode.Text.Trim().Length > 0) && (TextBoxLibelle.Text.Trim().Length > 0);
        }

        private void FormEpreuve_Load(object sender, EventArgs e)
        {
            if ("UPDATE".CompareTo(Tag) == 0)
            {

            }
        }
    }
}
