using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using SPID2Deconnecte.Modeles;
using MySql.Data.MySqlClient;
using Dapper;

namespace SPID2Deconnecte
{
    public partial class FormImportReferentiel : Form
    {
        public FormImportReferentiel()
        {
            InitializeComponent();
        }

        private void ButtonParcourir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + SingletonOutils.REP_IMPORT;
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.Filter = "Document texte référentiel (.TXT)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    TextBoxUploadFile.Text = openFileDialog.FileName;

                    TextBoxMessage.Text = "Fichier à importer : " + TextBoxUploadFile.Text + Environment.NewLine;

                    ButtonImport.Enabled = true;
                }
            }

        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            ButtonImport.Enabled=false;

            TextBoxMessage.Text = "Importation du fichier :" + Environment.NewLine;

            string filePath = TextBoxUploadFile.Text;
            TextBoxMessage.Text = filePath + Environment.NewLine;

            // Lecture du fichier référentiel
            int counter = 0;

            string strTable = "";

            // Premiére ligne du fichier
            bool bFirst = true;

            // Nombre de ligne de la table
            int iNbr = 0;

            Organisme organisme = new Organisme();
            Bareme bareme = new Bareme();
            CategorieAge catAge = new CategorieAge();
            Categorie categorie = new Categorie();
            BaremeDetail baremeDetail = new BaremeDetail();
            GrilleRencontre grilleRencontre = new GrilleRencontre();
            GrilleDetail grilleDetail = new GrilleDetail();
            TableauRef tableauRef = new TableauRef();
            NiveauRef niveauRef = new NiveauRef();
            PartieRef partieRef = new PartieRef();
            TypeClassement typeClassement = new TypeClassement();

            FromTxt fromTxt = new FromTxt();

            string sQueryOrganisme = DBUtils.BuildInsertSQL("ORGANISME");
            string sQueryBareme = DBUtils.BuildInsertSQL("BAREME");
            string sQueryCatAge = DBUtils.BuildInsertSQL("CAT_AGE_GROUP");
            string sQueryCat = DBUtils.BuildInsertSQL("CAT");
            string sQueryBaremeDetail = DBUtils.BuildInsertSQL("BAREME_DETAIL");
            string sQueryGrilleRencontre = DBUtils.BuildInsertSQL("GRILLE_RENCONTRE");
            string sQueryGrilleDetail = DBUtils.BuildInsertSQL("GRILLE_DETAIL");
            string sQueryTableauRef = DBUtils.BuildInsertSQL("TABLEAU_REF");
            string sQueryNiveauRef = DBUtils.BuildInsertSQL("NIVEAU_REF");
            string sQueryPartieRef = DBUtils.BuildInsertSQL("PARTIE_REF");
            string sQueryTypeClassement = DBUtils.BuildInsertSQL("TYPE_CLASSEMENT");

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            using (var transaction = connection.BeginTransaction())
            {
                // Read the file and display it line by line.  
                foreach (string line in File.ReadLines(filePath))
                {
                    if (bFirst)
                    {
                        DecoupeLigneDate(line);
                        bFirst = false;
                    }
                    else
                    {
                        /*
                            *           1         2
                            * 0123456789012345678901234
                            * ORGANISME           131
                            * BAREME              24
                            * TYPE_CLASSEMENT     33
                            */
                        if (counter == 0)
                        {
                            strTable = line.Substring(0, 20).Trim();
                            iNbr = int.Parse(line.Substring(20));
                            TextBoxMessage.Text += "Table : " + strTable + " - Nombre de ligne : " + iNbr;
                            TextBoxMessage.Refresh();

                            // Vidage table xxxx
                            connection.Execute("TRUNCATE `" + strTable + "`;");
                            counter++;
                        }
                        else
                        {
                            switch (strTable)
                            {
                                case "ORGANISME":
                                    organisme = fromTxt.OrganismeFromTxt(line);
                                    connection.Execute(sQueryOrganisme, organisme);
                                    break;

                                case "BAREME":
                                    bareme = fromTxt.BaremeFromTxt(line);
                                    connection.Execute(sQueryBareme, bareme);
                                    break;

                                case "CAT_AGE_GROUP":
                                    catAge = fromTxt.CategorieAgeFromTxt(line);
                                    connection.Execute(sQueryCatAge, catAge);
                                    break;

                                case "CAT":
                                    categorie = fromTxt.CategorieFromTxt(line);
                                    connection.Execute(sQueryCat, categorie);
                                    break;

                                case "BAREME_DETAIL":
                                    baremeDetail = fromTxt.BaremeDetailFromTxt(line);
                                    connection.Execute(sQueryBaremeDetail, baremeDetail);
                                    break;

                                case "GRILLE_RENCONTRE":
                                    grilleRencontre = fromTxt.GrilleRencontreFromTxt(line);
                                    connection.Execute(sQueryGrilleRencontre, grilleRencontre);
                                    break;

                                case "GRILLE_DETAIL":
                                    grilleDetail = fromTxt.GrilleDetailFromTxt(line);
                                    connection.Execute(sQueryGrilleDetail, grilleDetail);
                                    break;

                                case "TABLEAU_REF":
                                    tableauRef = fromTxt.TableauRefFromTxt(line);
                                    connection.Execute(sQueryTableauRef, tableauRef);
                                    break;

                                case "NIVEAU_REF":
                                    niveauRef = fromTxt.NiveauRefFromTxt(line);
                                    connection.Execute(sQueryNiveauRef, niveauRef);
                                    break;

                                case "PARTIE_REF":
                                    partieRef = fromTxt.PartieRefFromTxt(line);
                                    connection.Execute(sQueryPartieRef, partieRef);
                                    break;

                                case "TYPE_CLASSEMENT":
                                    typeClassement = fromTxt.TypeClassementFromTxt(line);
                                    connection.Execute(sQueryTypeClassement, typeClassement);
                                    break;
                            }

                            counter++;

                            // Affichage d'un message tous les 100 enregistrements
                            if (counter % 100 == 0)
                            {
                                TextBoxMessage.Text += " : " + counter;
                                TextBoxMessage.Refresh();
                            }

                            // Importation de la table fini !
                            if (counter > iNbr)
                            {
                                TextBoxMessage.Text += " : Terminé." + Environment.NewLine;
                                TextBoxMessage.Refresh();

                                counter = 0;
                            }
                        }

                    }
                }
                try
                {
                    transaction.Commit();

                    TextBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
                    TextBoxMessage.Refresh();
                }
                catch
                {
                    transaction.Rollback();

                    TextBoxMessage.Text += "Erreur lors du traitement !" + Environment.NewLine;
                    TextBoxMessage.Refresh();
                }
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void DecoupeLigneDate(string line)
        {
            // date et heure du fichier, Nombre de table
            // 17/11/2021-16:23:251              16
            TextBoxMessage.Text += "Extraction du " + line.Substring(0,10) + " à " + line.Substring(11,5) + Environment.NewLine; ;
            TextBoxMessage.Refresh();
        }
    }
}
