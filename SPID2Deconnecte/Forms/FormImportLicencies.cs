using PetaPoco;
using SPID2Deconnecte.Modeles;
using System;
using System.IO;

using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormImportLicencies : Form
    {
        PetaPoco.Database __db = null;

        public FormImportLicencies()
        {
            InitializeComponent();
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
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
                    textBoxUploadFile.Text = openFileDialog.FileName;

                    textBoxMessage.Text = "Fichier à importer : " + textBoxUploadFile.Text + Environment.NewLine;

                    buttonImport.Enabled = true;
                }
            }
        }

        private void buttonAbandon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            buttonImport.Enabled = false;

            // Initialisation de la database
            __db = new PetaPoco.Database("SqliteConnect");

            textBoxMessage.Text = "Importation du fichier :" + Environment.NewLine;

            string filePath = textBoxUploadFile.Text;
            textBoxMessage.Text = filePath + Environment.NewLine;

            // Lecture du fichier référentiel
            int counter = 0;

            string strTable = "";
            // Premiére ligne du fichier
            bool bFirst = true;

            // Nombre de ligne de la table
            int iNbr = 0;

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
                        textBoxMessage.Text += "Table : " + strTable + " - Nombre de ligne : " + iNbr;
                        textBoxMessage.Refresh();

                        // Vidage table strTable ( CLUB, LICENCIE )
                        try {
                            __db.Execute("DELETE FROM " + strTable + ";");

                            //__db.BeginTransaction();
                        }
                        catch
                        {
                            //__db.AbortTransaction();
                            __db = null;
                        }
                        counter++;
                    }
                    else
                    {
                        switch (strTable)
                        {
                            case "CLUB":
                                DecoupeLigneClub(line);
                                break;

                            case "LICENCIE":
                                DecoupeLigneLicencie(line);
                                break;
                        }

                        counter++;

                        // Affichage d'un message tous les 100 enregistrements
                        if (counter % 100 == 0)
                        {
                            textBoxMessage.Text += " : " + counter;
                            textBoxMessage.Refresh();
                        }

                        // Importation de la table fini !
                        if (counter > iNbr)
                        {
                            textBoxMessage.Text += " : Terminé." + Environment.NewLine;
                            textBoxMessage.Refresh();

                            counter = 0;
                        }
                    }

                }
            }

            if(__db != null)
            {
                try
                {
                    //__db.CompleteTransaction();
                    __db = null;

                    textBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
                    textBoxMessage.Refresh();
                }
                catch 
                {
                    MessageBox.Show("Abort");
                    //__db.AbortTransaction();
                }
            }

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;

        }

        private void DecoupeLigneLicencie(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9         10        11        12         13       14        15        16        17        18        19        20        21        22        23        24        25        26        27        28        29        30        31        32        33        34        35        36        37        38        39        40        41        42         
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
             * 52154          46             12751163                      31             CHOUADRA                                                        Djamel         M12/10/19727511727 ET C30/09/202108/10/2021        1641                                                                                                                                                                                                              
             *  
             * LIC_ID                   NUMERIC(15,0)
             * CAT_ID                   NUMERIC(15,0)
             * CLUB_ID                  NUMERIC(15,0)
             * CLU_CLUB_ID              NUMERIC(15,0)
             * TCLST_ID                 NUMERIC(15,0)
             * PERS_LB_NOM              VARCHAR(64)
             * PERS_LB_PRENOM           VARCHAR(15)
             * PERS_FG_SEXE             CHAR(1)
             * PERS_DT_NAISSANCE        DATE
             * LIC_NB_LICENCE           VARCHAR(8)
             * LIC_FG_NATIONALITE       CHAR(1)
             * LIC_FG                   CHAR(1)
             * LIC_FG_MODULE            CHAR(1)
             * LIC_FG_CERTIFICAT        CHAR(1)
             * LIC_DT_CERTIFICAT        DATE
             * LIC_DT_VALIDATION        DATE
             * LIC_NB_PLACE             INTEGER
             * LIC_NB_POINT             NUMERIC(7,3)
             * LIC_FG_ECHELON           CHAR(1)
             * LIC_NB_POINT_CF_PREC     VARCHAR(64)
             * LIC_NB_POINT_TOTAL_CF    VARCHAR(64)
             * LIC_NB_TRI_POINT_CF      VARCHAR(64)
             * LIC_BL_LOCAL             NUMERIC(1,0)
             * LIC_BL_DOUBLE            NUMERIC(1,0)
             * LIC_NB_TOTAL_POINT_DOUBLE    NUMERIC(7,3)
             * LIC_NB_POINT_TOUR_PREC_CF    VARCHAR(64)
             * EPRV_ID                      NUMERIC(15,0)
             * DOUBLE_CLUB_ID               NUMERIC(15,0)
             * DOUBLE_CLU_CLUB_ID           NUMERIC(15,0)
             */

            Licencie licencie = new Licencie();
            int pos = 0;
            int len = line.Length;

            licencie.LIC_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos = 15;
            licencie.CAT_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            licencie.CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            licencie.CLU_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            licencie.TCLST_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            licencie.PERS_LB_NOM = line.Substring(pos, 64).TrimEnd();
            pos += 64;
            licencie.PERS_LB_PRENOM = line.Substring(pos, 15).TrimEnd();
            pos += 15;
            licencie.PERS_FG_SEXE = line.Substring(pos, 1)[0];
            pos++;
            licencie.PERS_DT_NAISSANCE = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_NB_LICENCE = SingletonOutils.StringParse( line.Substring(pos, 8));
            pos += 8;
            licencie.LIC_FG_NATIONALITE = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_FG = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_FG_MODULE = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_FG_CERTIFICAT = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_DT_CERTIFICAT = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_DT_VALIDATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_NB_PLACE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            licencie.LIC_NB_POINT = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            licencie.LIC_FG_ECHELON = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_NB_POINT_CF_PREC = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_NB_POINT_TOTAL_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_NB_TRI_POINT_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_BL_LOCAL = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_BL_DOUBLE = line.Substring(pos, 1)[0];
            pos++;
            licencie.LIC_NB_TOTAL_POINT_DOUBLE = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            if (pos+7 > len)
                licencie.LIC_NB_POINT_TOUR_PREC_CF = "";
            else
                licencie.LIC_NB_POINT_TOUR_PREC_CF = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            if (pos > len)
                licencie.EPRV_ID = null;
            else
                licencie.EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            if (pos > len)
                licencie.DOUBLE_CLUB_ID = null;
            else
                licencie.DOUBLE_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            if (pos > len)
                licencie.DOUBLE_CLU_CLUB_ID = null;
            else
                licencie.DOUBLE_CLU_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));

            __db.Insert(licencie);
        }

        private void DecoupeLigneClub(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 01234567890123456789012345678901234567890123456789012345678901234567890
             */
            /*
             *           1         2         3         4         5         6         7
             * 012345678901234567890123456789012345678901234567890123456789012345678901234
             * 1010001        01010001HAUT BUGEY TT                   La Cluse 01HBTTL
             * 
             * CLUB_ID          NUMERIC(15,0)
             *  // ORGA_ID          NUMERIC(8,0) - Non renseigné
             * CLUB_NM          VARCHAR(8)
             * CLUB_LG_LONG     VARCHAR(32)
             * CLUB_LB_COURT    VARCHAR(15)
             * CLUB_FG          CHAR(1)
             */

            Club club = new Club();

            club.CLUB_ID = Convert.ToUInt64(line.Substring(0, 15));

            // Si le champ n'est pas renseigné
            club.ORGA_ID = null;
            club.CLUB_NM = line.Substring(15, 8).TrimEnd();
            club.CLUB_LB_LONG = line.Substring(23, 32).TrimEnd();
            club.CLUB_LB_COURT = line.Substring(55, 15);
            club.CLUB_FG = SingletonOutils.CharParse(line.Substring(70, 1));

            __db.Insert(club);
        }

        private void DecoupeLigneDate(string line)
        {
            // date et heure du fichier, Nombre de table
            // 17/11/2021-16:23:251              16
            textBoxMessage.Text += "Extraction du " + line.Substring(0, 10) + " à " + line.Substring(11, 5) + Environment.NewLine; ;
            textBoxMessage.Refresh();
        }
    }
}
