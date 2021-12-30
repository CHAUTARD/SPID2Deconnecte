
using System;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using SPID2Deconnecte.Modeles;


namespace SPID2Deconnecte.Forms
{
    public partial class FormEpreuve : Form
    {
        // Epreuve sélectionné dans la TreeView
        private Epreuve epreuve = new Epreuve();

        public FormEpreuve()
        {
            InitializeComponent();
        }

        public FormEpreuve(string sTag)
        {
            InitializeComponent();

            Tag = sTag;           
        }

        internal void SetData(Epreuve treeEpreuve)
        {
            epreuve = treeEpreuve;

            // Recherche de l'organisme
            Organisme organisme;

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                organisme = connection.Query<Organisme>("SELECT * FROM organisme WHERE ORGA_ID = " + epreuve.ORGA_ID).Single();

                connection.Close();
            }

            TextBoxCD.Text = epreuve.EPRV_CD;
            TextBoxCode.Text = epreuve.EPRV_LB_COURT;
            TextBoxOrganisme.Text = organisme.ORGA_LB;
            TextBoxLibelle.Text = epreuve.EPRV_LB;
            RichTextBoxCommentaire.Text= epreuve.EPRV_CM;
        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            string sQuery;

            // Mise a jour ou sauvegarde
            epreuve.EPRV_CD = TextBoxCD.Text;
            epreuve.EPRV_LB_COURT = TextBoxCode.Text.Trim();
            epreuve.EPRV_LB = TextBoxLibelle.Text.Trim();
            epreuve.EPRV_CM = RichTextBoxCommentaire.Text.Trim();

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            if ("CREER".CompareTo(Tag) == 0)
            {
                sQuery = DBUtils.BuildInsertSQL("epreuve");
                connection.Execute(sQuery, epreuve);
            }
            else
            {
                sQuery = DBUtils.BuildUpdateSQL( "epreuve", "EPRV_CD = `" + epreuve.EPRV_CD + "`");
                connection.Execute(sQuery, epreuve);
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
