using System;
using System.IO;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte
{
    public partial class FormImportPackage : Form
    {
        public FormImportPackage()
        {
            InitializeComponent();
        }

        private void ButtonParcourir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + SingletonOutils.REP_IMPORT;
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.Filter = "Document texte package (.TXT)|*.txt";
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

            // Lecture du fichier package
            int counter = 0;

            string strTable = "";
            string sQuery;

            // Premiére ligne du fichier
            bool bFirst = true;

            // Nombre de ligne de la table
            int iNbr = 0;

            FromTxt fromTxt = new FromTxt();

            Package package = new Package();
            Epreuve epreuve = new Epreuve();
            Division division = new Division();
            CategorieEpreuve categorieEpreuve = new CategorieEpreuve();
            Tour tour = new Tour();
            Tableau tableau = new Tableau();
            PackageTableau packageTableau = new PackageTableau();
            Joueur joueur = new Joueur();
            Inscription inscription = new Inscription();
            Niveau niveau = new Niveau();
            Partie partie = new Partie();
            TableauPartie tableauPartie = new TableauPartie();
            Classement classement = new Classement();

            string sQueryPackage = DBUtils.BuildInsertSQL("PACKAGE");
            string sQueryEpreuve = DBUtils.BuildInsertSQL("EPREUVE");
            string sQueryDivision = DBUtils.BuildInsertSQL("DIVISION");
            string sQueryCategorieEpreuve = DBUtils.BuildInsertSQL("CATEGORIE_EPREUVE");
            string sQueryTour = DBUtils.BuildInsertSQL("TOUR");
            string sQueryTableau = DBUtils.BuildInsertSQL("TABLEAU");
            string sQueryJoueur = DBUtils.BuildInsertSQL("JOUEUR");
            string sQueryInscription = DBUtils.BuildInsertSQL("INSCRIPTION");
            string sQueryNiveau = DBUtils.BuildInsertSQL("NIVEAU");
            string sQueryPartie = DBUtils.BuildInsertSQL("PARTIE");
            string sQueryTableauPartie = DBUtils.BuildInsertSQL("TABLEAU_PARTIE");
            string sQueryClassement = DBUtils.BuildInsertSQL("CLASSEMENT");

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
                            connection.Execute("TRUNCATE `" + strTable.ToLower() + "`;");

                            counter++;

                            // Pas d'enregistremlent dans la table
                            if (iNbr == 0)
                            {
                                TextBoxMessage.Text += " : Terminé." + Environment.NewLine;
                                TextBoxMessage.Refresh();

                                counter = 0;
                            }
                        }
                        else
                        {
                            switch (strTable)
                            {
                                case "PACKAGE":
                                    package = fromTxt.PackageFromTxt(line);
                                    connection.Execute( sQueryPackage, new {
                                        PKG_ID = package.PKG_ID,
                                        UTIL_LB_LOGIN = package.UTIL_LB_LOGIN,
                                        PKG_LB = package.PKG_LB,
                                        PKG_ETAT = package.PKG_ETAT,
                                        PKG_LB_USER_MODIF = package.PKG_LB_USER_MODIF,
                                        PKG_DT_MODIFICATION = package.PKG_DT_MODIFICATION,
                                        PKG_DT_CREATION = package.PKG_DT_CREATION,
                                        PKG_DATE_DESC = package.PKG_DT_CREATION,
                                        PKG_DATE_MONTE = DateTime.MinValue
                                    });
                                    break;

                                case "EPREUVE":
                                    epreuve = fromTxt.EpreuveFromTxt(line);
                                    connection.Execute(sQueryEpreuve, epreuve);
                                    break;

                                case "DIVISION":
                                    division = fromTxt.DivisionFromTxt(line);
                                    connection.Execute(sQueryDivision, division);
                                    break;

                                case "CATEGORIE_EPREUVE":
                                    categorieEpreuve = fromTxt.CategorieEpreuveFromTxt(line);
                                    connection.Execute(sQueryCategorieEpreuve, categorieEpreuve);
                                    break;

                                case "TOUR":
                                    tour = fromTxt.TourFromTxt(line);
                                    connection.Execute(sQueryTour, tour);
                                    break;

                                case "TABLEAU":
                                    tableau = fromTxt.TableauFromTxt(line);
                                    connection.Execute(sQueryTableau, tableau);
                                    break;

                                case "PACKAGE_TABLEAU":
                                    packageTableau = fromTxt.PackageTableauFromTxt(line);
                                    sQuery = DBUtils.BuildInsertSQL(strTable);
                                    connection.Execute(sQuery, packageTableau);
                                    break;

                                case "JOUEUR":
                                    joueur = fromTxt.JoueurFromTxt(line);
                                    connection.Execute(sQueryJoueur, joueur);
                                    break;

                                case "INSCRIPTION":
                                    inscription = fromTxt.InscriptionFromTxt(line);
                                    connection.Execute(sQueryInscription, inscription);
                                    break;

                                case "NIVEAU":
                                    niveau = fromTxt.NiveauFromTxt(line);
                                    connection.Execute(sQueryNiveau, niveau);
                                    break;

                                case "PARTIE":
                                    partie = fromTxt.PartieFromTxt(line);
                                    connection.Execute(sQueryPartie, partie);
                                    break;

                                case "TABLEAU_PARTIE":
                                    tableauPartie = fromTxt.TableauPartieFromTxt(line);
                                    connection.Execute(sQueryTableauPartie, tableauPartie);
                                    break;

                                case "CLASSEMENT":
                                    classement = fromTxt.ClassementFromTxt(line);
                                    connection.Execute(sQueryClassement, classement);
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
