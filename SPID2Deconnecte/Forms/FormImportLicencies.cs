
using System;
using System.Collections.Generic;
using System.IO;

using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte.Forms
{
    public partial class FormImportLicencies : Form
    {
        public FormImportLicencies()
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
            ButtonImport.Enabled = false;

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

            string sQueryClub = "INSERT INTO `club` (CLUB_ID, CLUB_NM, CLUB_LB_LONG, CLUB_LB_COURT, CLUB_FG) VALUES(";
            string sQueryLicencie = "INSERT INTO `licencie` (LIC_ID, CAT_ID, CLUB_ID, CLU_CLUB_ID, TCLST_ID, PERS_LB_NOM, PERS_LB_PRENOM, PERS_FG_SEXE, PERS_DT_NAISSANCE, LIC_NB_LICENCE, LIC_FG_NATIONALITE, LIC_FG, LIC_FG_MODULE, LIC_FG_CERTIFICAT, LIC_DT_CERTIFICAT, LIC_DT_VALIDATION, LIC_NB_PLACE, LIC_NB_POINT, LIC_FG_ECHELON ) VALUES (";
            string sValue;

            List<DBUtils.TypeSize> TypeSizeClub = new List<DBUtils.TypeSize>();
            TypeSizeClub.Add(new DBUtils.TypeSize('N', 15 ));
            TypeSizeClub.Add(new DBUtils.TypeSize('S', 8));
            TypeSizeClub.Add(new DBUtils.TypeSize('S', 32));
            TypeSizeClub.Add(new DBUtils.TypeSize('S', 15));
            TypeSizeClub.Add(new DBUtils.TypeSize('S', 1));

            List<DBUtils.TypeSize> TypeSizeLicencie = new List<DBUtils.TypeSize>();
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 64));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('D', 10));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 8));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('D', 10));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('D', 10));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 8));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 8));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 1));
            /*
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 64));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 64));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 64));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 1));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 8));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('S', 64));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            TypeSizeLicencie.Add(new DBUtils.TypeSize('N', 15));
            */

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            // Read the tempCsvFile and display it line by line.  
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

                        // Vidage table strTable ( CLUB, LICENCIE )
                        connection.Execute("TRUNCATE `" + strTable.ToLower() + "`;");

                        counter++;
                    }
                    else
                    {
                        switch (strTable)
                        {
                            case "CLUB":
                                sValue = DBUtils.Split(line, TypeSizeClub);
                                connection.Execute(sQueryClub + sValue + ");");
                                break;

                            case "LICENCIE":
                                sValue = DBUtils.Split(line, TypeSizeLicencie);
                                connection.Execute( sQueryLicencie + sValue + ");");
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

                            TextBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
                            TextBoxMessage.Refresh();
                        }
                    }
                }
            }

            connection.Close();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void DecoupeLigneDate(string line)
        {
            // date et heure du fichier, Nombre de table
            // 17/11/2021-16:23:251              16
            TextBoxMessage.Text += "Extraction du " + line.Substring(0, 10) + " à " + line.Substring(11, 5) + Environment.NewLine; ;
            TextBoxMessage.Refresh();
        }
    }
}
