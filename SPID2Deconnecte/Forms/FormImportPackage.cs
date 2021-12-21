using System;
using System.IO;
using System.Windows.Forms;
using SPID2Deconnecte.CRUD;
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

            // Premiére ligne du fichier
            bool bFirst = true;

            // Nombre de ligne de la table
            int iNbr = 0;

            PackageCrud package = new PackageCrud();
            EpreuveCrud epreuve = new EpreuveCrud();
            DivisionCrud division = new DivisionCrud();
            CategorieEpreuveCrud categorieEpreuve = new CategorieEpreuveCrud();
            TourCrud tour = new TourCrud();
            TableauCrud tableau = new TableauCrud();
            PackageTableauCrud packageTableau = new PackageTableauCrud();
            JoueurCrud joueur = new JoueurCrud();
            InscriptionCrud inscription = new InscriptionCrud();
            NiveauCrud niveau = new NiveauCrud();
            PartieCrud partie = new PartieCrud();
            TableauPartieCrud tableauPartie = new TableauPartieCrud();
            ClassementCrud classement = new ClassementCrud();

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
                        using (var db = new PetaPoco.Database("SqliteConnect"))
                        {
                            db.Execute("DELETE FROM " + strTable + ";");
                            db.Execute("VACUUM;");
                        }
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
                        switch(strTable)
                        {
                            case "PACKAGE":
                                package.FromTxt(line);
                                break;

                            case "EPREUVE":
                                epreuve.FromTxt(line);
                                break;

                            case "DIVISION":
                                division.FromTxt(line);
                                break;

                            case "CATEGORIE_EPREUVE":
                                categorieEpreuve.FromTxt(line);
                                break;

                            case "TOUR":
                                tour.FromTxt(line);
                                break;

                            case "TABLEAU":
                                tableau.FromTxt(line);
                                break;

                            case "PACKAGE_TABLEAU":
                                packageTableau.FromTxt(line);
                                break;

                            case "JOUEUR":
                                joueur.FromTxt(line);
                                break;

                            case "INSCRIPTION":
                                inscription.FromTxt(line);
                                break;

                            case "NIVEAU":
                                niveau.FromTxt(line);
                                break;

                            case "PARTIE":
                                partie.FromTxt(line);
                                break;

                            case "TABLEAU_PARTIE":
                                tableauPartie.FromTxt(line);
                                break;

                            case "CLASSEMENT":
                                classement.FromTxt(line);
                                break;
                        }

                        counter++;

                        // Affichage d'un message tous les 100 enregistrements
                        if(counter % 100 == 0)
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

            TextBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
            TextBoxMessage.Refresh();

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
