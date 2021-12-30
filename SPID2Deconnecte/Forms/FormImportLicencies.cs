
using System;
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

            string sQuery;

            FromTxt fromTxt = new FromTxt();

            Club club = new Club();
            Licencie licencie = new Licencie();

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            using (var tx = connection.BeginTransaction())
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

                            // Vidage table strTable ( CLUB, LICENCIE )
                            connection.Execute("DROP TABLE IF EXISTS " + strTable + ";");

                            counter++;
                        }
                        else
                        {
                            switch (strTable)
                            {
                                case "CLUB":
                                    club = fromTxt.ClubFromTxt(line);

                                    /*
                                    sQuery = "INSERT INTO `club` (`CLUB_ID`, `ORGA_ID`, `CLUB_NM`, `CLUB_LB_LONG`, `CLUB_LB_COURT`, `CLUB_FG`) VALUES( " +
                                       "@CLUB_ID, @ORGA_ID, @CLUB_NM, @CLUB_LB_LONG, @CLUB_LB_COURT, @CLUB_FG );";
                                    */
                                    sQuery = DBUtils.BuildInsertSQL("club");
                                    connection.Execute(sQuery, club);
                                    break;

                                case "LICENCIE":
                                    licencie = fromTxt.LicencieFromTxt(line);

                                    /*
                                    sQuery = "INSERT INTO `licencie` (`LIC_ID`, `CAT_ID`, `CLUB_ID`, `CLU_CLUB_ID`, `TCLST_ID`, `PERS_LB_NOM`, `PERS_LB_PRENOM`, " +
                                        "`PERS_FG_SEXE`, `PERS_DT_NAISSANCE`, `LIC_NB_LICENCE`, `LIC_FG_NATIONALITE`, `LIC_FG`, `LIC_FG_MODULE`, `LIC_FG_CERTIFICAT`, " +
                                        "`LIC_DT_CERTIFICAT`, `LIC_DT_VALIDATION`, `LIC_NB_PLACE`, `LIC_NB_POINT`, `LIC_FG_ECHELON`, `LIC_NB_POINT_CF_PREC`, `LIC_NB_POINT_TOTAL_CF`, " +
                                        "`LIC_NB_TRI_POINT_CF`, `LIC_BL_LOCAL`, `LIC_BL_DOUBLE`, `LIC_NB_TOTAL_POINT_DOUBLE`, `LIC_NB_POINT_TOUR_PREC_CF`, `EPRV_ID`, `DOUBLE_CLUB_ID`, `DOUBLE_CLU_CLUB_ID`) " +
                                        "VALUES( @LIC_ID, @CAT_ID, @CLUB_ID, @CLU_CLUB_ID, @TCLST_ID, @PERS_LB_NOM, @PERS_LB_PRENOM, @PERS_FG_SEXE, @PERS_DT_NAISSANCE, @LIC_NB_LICENCE, " +
                                        "@LIC_FG_NATIONALITE, @LIC_FG, @LIC_FG_MODULE, @LIC_FG_CERTIFICAT, @LIC_DT_CERTIFICAT, @LIC_DT_VALIDATION, @LIC_NB_PLACE, @LIC_NB_POINT, @LIC_FG_ECHELON, @LIC_NB_POINT_CF_PREC, @LIC_NB_POINT_TOTAL_CF, " +
                                        "@LIC_NB_TRI_POINT_CF, @LIC_BL_LOCAL, @LIC_BL_DOUBLE, @LIC_NB_TOTAL_POINT_DOUBLE, @LIC_NB_POINT_TOUR_PREC_CF,@EPRV_ID, @DOUBLE_CLUB_ID, @DOUBLE_CLU_CLUB_ID );";
                                    */
                                    sQuery = DBUtils.BuildInsertSQL("licencie");
                                    connection.Execute( sQuery, licencie);
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

                if (connection != null)
                {
                    try
                    {
                        tx.Commit();

                        TextBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
                        TextBoxMessage.Refresh();
                    }
                    catch
                    {
                        tx.Commit();
                        MessageBox.Show("Information non sauvées !");
                    }
                }
            }

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
