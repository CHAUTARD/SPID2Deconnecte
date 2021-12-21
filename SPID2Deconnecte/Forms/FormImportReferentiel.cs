using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using SPID2Deconnecte.Modeles;

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
                           
                        // Vidage table ORGANISME
                        using (var db = new PetaPoco.Database("SqliteConnect"))
                        {
                            db.Execute("DELETE FROM " + strTable + ";");
                            db.Execute("VACUUM;");
                        }
                        counter++;
                    }
                    else
                    {
                        switch(strTable)
                        {
                            case "ORGANISME":
                                organisme.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(organisme);
                                }
                                break;

                            case "BAREME":
                                bareme.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(bareme);
                                }
                                break;

                            case "CAT_AGE_GROUP":
                                catAge.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(catAge);
                                }
                                break;

                            case "CAT":
                                categorie.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(categorie);
                                }
                                break;

                            case "BAREME_DETAIL":
                                baremeDetail.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(baremeDetail);
                                }
                                break;

                            case "GRILLE_RENCONTRE":
                                grilleRencontre.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(grilleRencontre);
                                }
                                break;

                            case "GRILLE_DETAIL":
                                grilleDetail.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(grilleDetail);
                                }
                                break;

                            case "TABLEAU_REF":
                                tableauRef.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(tableauRef);
                                }
                                break;

                            case "NIVEAU_REF":
                                niveauRef.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(niveauRef);
                                }
                                break;

                            case "PARTIE_REF":
                                partieRef.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(partieRef);
                                }
                                break;

                            case "TYPE_CLASSEMENT":
                                typeClassement.FromTxt(line);
                                using (var db = new PetaPoco.Database("SqliteConnect"))
                                {
                                    db.Insert(typeClassement);
                                }
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
