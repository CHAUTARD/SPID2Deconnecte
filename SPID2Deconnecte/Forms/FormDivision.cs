using Dapper;
using MySql.Data.MySqlClient;
using SPID2Deconnecte.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormDivision : Form
    {
        private long lEpreuveId;
        private Division division;

        public FormDivision(string v)
        {
            this.Tag = v;

            InitializeComponent();

            InitCombo();
        }

        public FormDivision(string v, long eprvId)
        {
            this.Tag = v;
            this.lEpreuveId = eprvId;

            InitializeComponent();

            InitCombo();

            if ("CREER".CompareTo(Tag) == 0)
            {
                // Création d'une nouvelle division
                comboBoxSexe.SelectedIndex = 2; // Mixte
                comboBoxCategorie.SelectedIndex = 6; // Senior

                //var itemWithKey2 = comboBoxCategorie.(x => x.Key == 2);
            }
        }

        private void InitCombo()
        { 
            // Remplir la combo sur le sexe
            comboBoxSexe.Items.Clear();
            comboBoxSexe.DisplayMember = "Value";
            comboBoxSexe.ValueMember = "Key";

            Dictionary<string, string> dSexes = new Dictionary<string, string>();
            dSexes.Add("F","Féminin");
            dSexes.Add("M", "Masculin");
            dSexes.Add("X", "Mixte");
            comboBoxSexe.DataSource = new BindingSource(dSexes, null);

            // Remplir les groupes de catégorie
            comboBoxCategorie.Items.Clear();
            comboBoxCategorie.DisplayMember = "Value";
            comboBoxCategorie.ValueMember = "Key";

            Dictionary<string, string> dItems = new Dictionary<string, string>();

            CatAgeGroupe catAgeGroupe = new CatAgeGroupe();
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                IEnumerable<CatAgeGroupe> catAgeGroupes = connection.Query<CatAgeGroupe>("SELECT * FROM CAT_AGE_GROUP;");

                foreach (CatAgeGroupe c in catAgeGroupes)
                {
                    checkedListBoxCategorie.Items.Add(new { Key = c.GCAT_CD, Value = string.Format("{0} - {1}", c.GCAT_LB_COURT, c.GCAT_LB) }, true);
                }
                connection.Close();
            }
            comboBoxCategorie.DataSource = new BindingSource(dItems, null);


            // Remplir les catégories
            checkedListBoxCategorie.DisplayMember = "Value";
            checkedListBoxCategorie.ValueMember = "Key";

            Dictionary<string, string> dCategories = new Dictionary<string, string>();

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                IEnumerable<Categorie> categories = connection.Query<Categorie>("SELECT * FROM categorie ORDER BY CAT_DT_DEB DESC;");

                foreach (Categorie c in categories )
                {
                    checkedListBoxCategorie.Items.Add(new { Key = c.CAT_ID, Value = string.Format("{0} - {1}", c.CAT_CD, c.CAT_LB) }, true);
                }
                connection.Close();
            }
        }

        internal void SetData(Division div)
        {
            this.division = div;

            // Organisme < 0 = Inc
            // > 0, bloquer les zone de saisie

            // Recherche de l'organisme
            Organisme organisme = new Organisme();

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                organisme = connection.Query<Organisme>( "SELECT * FROM organisme WHERE ORGA_ID = " + division.ORGA_ID).Single();
                connection.Close();
            }

            // Si Inc(connu alors LOCAL)
            TextBoxCodeOrganisme.Text = "Inc".CompareTo(organisme.ORGA_CD) == 0 ? "LOCAL" : organisme.ORGA_CD;
            TextBoxCodeDivision.Text = division.DIV_CD;
            TextBoxLibelle.Text = division.DIV_LB;
            comboBoxCategorie.Text = division.GCAT_CD;

            // Valider actif
            ValidateSave();
        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCheckOff_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCategorie.Items.Count; i++)
            {
                checkedListBoxCategorie.SetItemChecked(i, false);
            }
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCategorie.Items.Count; i++)
            {
                checkedListBoxCategorie.SetItemChecked(i, true);
            }
        }

        // Vérification si les champs obligatoire sont remplis
        private void ValidateSave()
        {
            buttonValider.Enabled = (TextBoxCodeDivision.Text.Trim().Length > 0) && (TextBoxLibelle.Text.Trim().Length > 0) && (numericPointManche.Value > 0);
        }

        private void TextBoxCodeDivision_TextChanged(object sender, EventArgs e)
        {
            ValidateSave();
        }

        private void TextBoxLibelle_TextChanged(object sender, EventArgs e)
        {
            ValidateSave();
        }

        private void numericPointManche_ValueChanged(object sender, EventArgs e)
        {
            ValidateSave();
        }

        // Sauvegarde des informations
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Division division = new Division();
            string sQuery;

            MySqlConnection connection = DBUtils.GetDBConnection();

            // Mise a jour ou sauvegarde
            division.EPRV_ID = lEpreuveId;
            division.DIV_CD = TextBoxCodeDivision.Text.Trim();           
            division.DIV_LB = TextBoxLibelle.Text.Trim();
            division.DIV_FG_SEXE = (string) comboBoxSexe.SelectedValue;
            division.DIV_BL_CORPO = checkBoxCorporative.Checked ? 1 : 0;
            division.DIV_CM = richTextBoxCommentaire.Text.Trim(); 
            division.GCAT_CD = (string)comboBoxCategorie.SelectedValue;
            division.DIV_BL_DOUBLE = checkBoxDouble.Checked ? 1 : 0; ;
            division.DIV_NB_POINT_MANCHE = (int) numericPointManche.Value;
            division.DIV_NB_MANCHE_POULE = (int) numericNbManchePoule.Value;
            division.DIV_NB_MANCHE_TAB = (int) numericNbMancheTableau.Value;
            division.DIV_NB_POINT_MIN = (int)numericPointMin.Value;
            division.DIV_NB_POINT_MAX = (int)numericNbPointMax.Value;

            if ("CREER".CompareTo(Tag) == 0)
            {
                CategorieEpreuve categorieEpreuve = new CategorieEpreuve();

                sQuery = DBUtils.BuildInsertSQL("division");
                int iRet = connection.Execute(sQuery, division);

                categorieEpreuve.DIV_ID = iRet;

                // Pour chaque catégorie créer l'enregistrement dans CATEGORIE_EPREUVE
                if (checkedListBoxCategorie.CheckedItems.Count != 0)
                {
                    // If so, loop through all checked items and print results.  
                    for (int x = 0; x < checkedListBoxCategorie.CheckedItems.Count; x++)
                    {
                        categorieEpreuve.CAT_ID = (long) checkedListBoxCategorie.CheckedItems[x];
                        sQuery = DBUtils.BuildInsertSQL("categorie_epreuve");
                        connection.Execute(sQuery, categorieEpreuve);
                    }
                }
            }
            else
            {
                sQuery = DBUtils.BuildUpdateSQL("division", "`DIV_ID` = " + division.DIV_ID);
                connection.Execute(sQuery, division);

            }
            connection.Close();

            MessageBox.Show("Sauvegarde effectuée", "Division");

            Close();
        }
    }
}
