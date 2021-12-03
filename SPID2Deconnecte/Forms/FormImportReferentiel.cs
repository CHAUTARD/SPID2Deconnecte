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
            buttonImport.Enabled=false;

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
                                DecoupeLigneOrganisme(line); 
                                break;

                            case "BAREME":
                                DecoupeBareme(line);
                                break;

                            case "CAT_AGE_GROUP":
                                DecoupeLigneCategorieAge(line);
                                break;

                            case "CAT":
                                DecoupeLigneCategorie(line);
                                break;

                            case "BAREME_DETAIL":
                                DecoupeLigneBaremeDetail(line);
                                break;

                            case "GRILLE_RENCONTRE":
                                DecoupeLigneGrilleRencontre(line);
                                break;

                            case "GRILLE_DETAIL":
                                DecoupeLigneGrilleDetail(line);
                                break;

                            case "TABLEAU_REF":
                                DecoupeLigneTableauRef(line);
                                break;

                            case "NIVEAU_REF":
                                DecoupeLigneNiveauRef(line);
                                break;

                            case "PARTIE_REF":
                                DecoupeLignePartieRef(line);
                                break;

                            case "TYPE_CLASSEMENT":
                                DecoupeLigneTypeClassement(line);
                                break;
                        }

                        counter++;

                        // Affichage d'un message tous les 100 enregistrements
                        if(counter % 100 == 0)
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

            textBoxMessage.Text += "Traitement bien Terminé." + Environment.NewLine;
            textBoxMessage.Refresh();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void DecoupeLigneTypeClassement(string line)
        {
            /*
             *           1         2         3         4         5
             * 012345678901234567890123456789012345678901234567890123456
             * 20             5                               5 500  
             * 
             * TCLS_ID              NUMERIC(15,0)
             * TCLS_LB              VARCHAR(32)
             * TCLS_CD              VARCHAR(2)
             * TCLS_NB_POINT_MIN    INTEGER
             * BL_MAJ               NUMERIC(1,0)
             * 
             */

            TypeClassement typeClassement = new TypeClassement();

            typeClassement.TCLST_ID = Convert.ToUInt64(line.Substring(0, 15));
            typeClassement.TCLST_LB = line.Substring(15, 32).TrimEnd();
            typeClassement.TCLST_CD = SingletonOutils.StringParse( line.Substring(47, 2) );
            typeClassement.TCLST_NB_POINT_MIN = short.Parse(line.Substring(49, 8));
            typeClassement.BL_MAJ = true;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(typeClassement);
            }
        }

        private void DecoupeLignePartieRef(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9         10        11        12        13        14
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123
             * 36863          13814                                                        1       1                                                1       2        3                        
             *
             * RPARTI_ID_PARTIE_REF             NUMERIC(15,0)
             * NIVREF_ID                        NUMERIC(15,0)
             * PAR_RPARTI_ID_PARTIE_REF         NUMERIC(15,0)
             * PAR2_RPARTI_ID_PARTIE_REF        NUMERIC(15,0)
             * RPARTI_NM_RANG1                  INTEGER
             * RPARTI_NM_RANG2                  INTEGER
             * RPARTI_NM_ORDRE_REF              INTEGER
             * RPARTI_NM_PARTIE_REF             INTEGER
             * RPARTI_FG_PARTIE_1               CHAR(1)
             * RPARTI_NM_CLASSEMENT_VAINQUEUR   INTEGER
             * RPARTI_NM_POULE1                 INTEGER
             * RPARTI_NM_CLASSEMENT1            INTEGER
             * RPARTI_NM_POULE2                 INTEGER
             * RPARTI_NM_CLASSEMENT2            INTEGER
             * RPARTI_NM_POSITION1              INTEGER
             * RPARTI_NM_POSITION2              INTEGER
             * RPARTI_FG_PARTIE_2               CHAR(1)
             * RPARTI_NM_CLASSEMENT_PERDANT     INTEGER
             * RPARTI_FG_PARTIE_RF              CHAR(1)
             * RPARTI_NM_CLST_REF               CHAR(1)
             * BL_MAJ                           NUMERIC(1,0)
             * RPARTI_BL_CLST_NONJOUEE          NUMERIC(1,0)
             */

            PartieRef partieRef = new PartieRef();

            partieRef.RPARTI_ID_PARTIE_REF = Convert.ToUInt64(line.Substring(0, 15));
            partieRef.NIVREF_ID = Convert.ToUInt64(line.Substring(15, 15));
            partieRef.PAR_RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(30, 15));
            partieRef.PAR2_RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(45, 15));
            partieRef.RPARTI_NM_RANG1 = SingletonOutils.ShortParse(line.Substring(60, 8));
            partieRef.RPARTI_NM_RANG2 = SingletonOutils.ShortParse(line.Substring(68, 8));
            partieRef.RPARTI_NM_ORDRE_REF = SingletonOutils.ShortParse(line.Substring(76, 8));
            partieRef.RPARTI_NM_PARTIE_REF = SingletonOutils.ShortParse(line.Substring(84, 8));
            partieRef.RPARTI_FG_PARTIE_1 = line.Substring(92, 1)[0];
            partieRef.RPARTI_NM_CLST_VAINQUEUR = SingletonOutils.ShortParse(line.Substring(93, 8));
            partieRef.RPARTI_NM_POULE1 = SingletonOutils.ShortParse(line.Substring(101, 8));
            partieRef.RPARTI_NM_CLASSEMENT1 = SingletonOutils.ShortParse(line.Substring(109, 8));
            partieRef.RPARTI_NM_POULE2 = SingletonOutils.ShortParse(line.Substring(117, 8)); 
            partieRef.RPARTI_NM_POSITION1 = SingletonOutils.ShortParse(line.Substring(133, 8));
            partieRef.RPARTI_NM_POSITION2 = SingletonOutils.ShortParse(line.Substring(141, 8));
            partieRef.RPARTI_FG_PARTIE_2 = line.Substring(149, 1)[0];
            partieRef.RPARTI_NM_CLST_PERDANT = SingletonOutils.ShortParse(line.Substring(150, 8));

            partieRef.RPARTI_FG_PARTIE_REF = line.Substring(158, 1)[0];
            partieRef.RPARTI_NM_CLST_REF = line.Substring(159, 1)[0];
            partieRef.RPARTI_BL_CLST_NONJOUEE = 0;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(partieRef);
            }
        }

        private void DecoupeLigneNiveauRef(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 13814          164523              1/2 finale                      1       1               
             * 13815          164523              Finale                          2       013814          
             * 
             * NIVREF_ID                NUMERIC(15,0)
             * TABREF_ID                NUMERIC(15,0)
             * NIVREF_CD                VARCHAR(5)
             * NIVREF_LB                VARCHAR(32)
             * NIVREF_NB                INTEGER
             * NIVREF_LB_DEPART         NUMERIC(1,0)
             * NIVREF_NIVREF_ID         NUMERIC(15,0)
             * BL_MAJ                   NUMERIC(1,0)
             */

            NiveauRef niveauRef = new NiveauRef();

            niveauRef.NIVREF_ID = Convert.ToUInt64(line.Substring(0, 15));
            niveauRef.TABREF_ID = Convert.ToUInt64(line.Substring(15, 15));
            niveauRef.NIVREF_CD = line.Substring(30, 5).TrimEnd();
            niveauRef.NIVREF_LB = line.Substring(35, 32).TrimEnd();
            niveauRef.NIVREF_NB = short.Parse(line.Substring(67, 8));
            niveauRef.NIVREF_BL_DEPART = line.Substring(75, 1)[0];
            niveauRef.NIVREF_NIVREF_ID = SingletonOutils.LongParse(line.Substring(76, 15));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(niveauRef);
            }
        }

        private void DecoupeLigneTableauRef(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9         10        11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28        29        30        31        32        33        34        35          
             * 01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 164523              34_4D-4J-TED                      4                                                                                                                                                                                                                                                                      system_admin   13/07/202108/07/2021 
             * 164524              36_8D-8J-TED                      8                                                                                                                                                                                                                                                                      system_admin   13/07/202108/07/2021 
             * 
             * TABREF_ID                NUMERIC(15,0)
             * TABREF_CD                VARCHAR(5)
             * TABREF_LB                VARCHAR(32)
             * TABREF_FG                CHAR(2)
             * TABREF_NB_JOUEUR_REF     INTEGER
             * TABREF_CM                VARCHAR(255)
             * TABREF_LB_USER_MOTIF     VARCHAR(15)
             * TABREF_DT_MODIFICATION   DATE
             * TABREF_DT_CREATION       DATE
             * TABREF_SAISIE_TYPE       CHAR(1)
             * BL_MAJ                   NUMERIC(1,0)
             */

            TableauRef tableauRef = new TableauRef();

            tableauRef.TABREF_ID = Convert.ToUInt64(line.Substring(0, 15));
            tableauRef.TABREF_CD = line.Substring(15, 5).TrimEnd();
            tableauRef.TABREF_LB = line.Substring(20, 32).TrimEnd();
            tableauRef.TABREF_FG = line.Substring(52, 2).TrimEnd();
            tableauRef.TABREF_NB_JOUEURS_REF = short.Parse(line.Substring(54, 8));
            tableauRef.TABREF_CM = line.Substring(62, 255).Trim();
            tableauRef.TABREF_LB_USER_MODIF = line.Substring(317, 15).TrimEnd();
            DateTime dt = DateTime.ParseExact(line.Substring(332, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            tableauRef.TABREF_DT_MODIFICATION = dt;
            dt = DateTime.ParseExact(line.Substring(342, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            tableauRef.TABREF_DT_CREATION = dt;
            tableauRef.TABREF_SAISIE_TYPE = line.Substring(352, 1)[0];

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(tableauRef);
            }
        }

        private void DecoupeLigneGrilleDetail(string line)
        {
            /*
             *           1         2         3         4        
             * 01234567890123456789012345678901234567890123456
             * 29             1       1       4       481 
             * 
             * DGRIL_ID_DETAIL          NUMERIC(15,0)
             * DGRIL_NB_JOURNEE         INTEGER
             * DGRIL_NB_EQUIPE1         INTEGER
             * DGRIL_NB_EQUIPE2         INTEGER
             * GRIL_ID_RENC            NUMERIC(15,0)
             * BL_MAJ                   NUMERIC(1,0)
             */

            GrilleDetail grilleDetail = new GrilleDetail();

            grilleDetail.DGRIL_ID_DETAIL = Convert.ToUInt64(line.Substring(0, 15));
            grilleDetail.DGRIL_NB_JOURNEE = short.Parse(line.Substring(15, 8));
            grilleDetail.DGRIL_NB_EQUIPE1 = short.Parse(line.Substring(23, 8));
            grilleDetail.DGRIL_NB_EQUIPE2 = short.Parse(line.Substring(31, 8));
            grilleDetail.GRIL_ID_RENC = Convert.ToUInt64(line.Substring(39, 15));

            grilleDetail.BL_MAJ = true;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(grilleDetail);
            }
        }

        private void DecoupeLigneGrilleRencontre(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9         10        11
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
             * 151            1              FED_JFED_Poule 8 joueurs             8       IFED_Jmichel.bremond@01/07/2021
             * 
             * GRIL_ID_RENC         NUMERIC(15,0)
             * ORGA_ID              NUMERIC(15,0)
             * GRIL_CD_RENC         VARCHAR(5)
             * GRIL_LB_RENC         VARCHAR(32)
             * GRIL_NB_EQUIPE       INTEGER
             * GRIL_FG              CHAR(1)
             * GRIL_LB_USER_MODIF   VARCHAR(15)
             * GRIL_DT_CREATION     DATE
             * BL_MAJ               NUMERIC(1,0)
             */

            GrilleRencontre grilleRencontre = new GrilleRencontre();

            grilleRencontre.GRIL_ID_RENC = Convert.ToUInt64(line.Substring(0, 15));
            grilleRencontre.ORGA_ID = Convert.ToUInt64(line.Substring(15, 15));
            grilleRencontre.GRIL_CD_RENC = line.Substring(30, 5).TrimEnd();
            grilleRencontre.GRIL_LB_RENC = line.Substring(35, 32).TrimEnd();
            grilleRencontre.GRIL_NB_EQUIPE = short.Parse(line.Substring(67, 8));
            grilleRencontre.GRIL_FG = line.Substring(75, 1)[0];
            grilleRencontre.GRIL_LB_USER_MODIF = line.Substring(76, 20).TrimEnd();
            DateTime dt = DateTime.ParseExact(line.Substring(96, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            grilleRencontre.GRIL_DT_CREATION = dt;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(grilleRencontre);
            }
        }

        private void DecoupeLigneBaremeDetail(string line)
        {
            /*
             *           1         2         3         
             * 0123456789012345678901234567890123456
             * 2250           1       360     2
             * 
             * DBAR_ID_DETAILS      NUMERIC(15,0)
             * DBAR_NB_PLACE        INTEGER
             * DBAR_NB_POINT        INTEGER
             * DBAR_ID              NUMERIC(15,0)
             * BL_MAJ               NUM(1,0)
             */

            BaremeDetail baremeDetail = new BaremeDetail();

            baremeDetail.DBAR_ID_DETAILS = Convert.ToUInt64(line.Substring(0, 15));
            baremeDetail.DBAR_NB_PLACE = short.Parse(line.Substring(15, 8));
            baremeDetail.DBAR_NB_POINT = short.Parse(line.Substring(23, 8));
            baremeDetail.BAR_ID = Convert.ToUInt64(line.Substring(31, 15));
            baremeDetail.BL_MAJ = true;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(baremeDetail);
            }
        }

        private void DecoupeLigneCategorie(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 01234567890123456789012345678901234567890123456789012345678901234567890123456789 
             * 1                   Veterans 4                      V4   01/01/194231/12/1951X
             * 
             * CAT_ID           NUMERIC(15,0)
             * GCAT_CD          CHAR(5)
             * CAT_LB           VARCHAR(32)
             * CAT_CD           VARCHAR(5)
             * CAT_DT_DEBUT     DATE
             * CAT_DT_FIN       DATE
             * CAT_FG           CHAR(1)
             * DEM_ID           NUMERIC(15,0)
             * LB_MAJ           NUM(1,0)
             */

            Categorie categorie  = new Categorie();

            categorie.CAT_ID = Convert.ToUInt64(line.Substring(0, 15));
            categorie.GCAT_CD = line.Substring(15, 5).TrimEnd();
            categorie.CAT_LB = line.Substring(20, 32).TrimEnd();
            categorie.CAT_CD = line.Substring(52, 5).TrimEnd();

            DateTime dt = DateTime.ParseExact(line.Substring(57, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            categorie.CAT_DT_DEB = dt;

            dt = DateTime.ParseExact(line.Substring(67, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            categorie.CAT_DT_FIN = dt;

            categorie.CAT_FG = line.Substring(77, 1)[0];
            categorie.DEM_ID = 0;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(categorie);
            }
        }

        private void DecoupeLigneCategorieAge(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345
             * POU  POU  Poussins
             * 
             * GCAT_CD          CHAR(5)
             * GCAT_LB_COURT    VARCHAR(5)
             * GCAT_LB          VARCHAR(32)
             * LB_MAJ           NUM(1,0)
             */

            CategorieAge catAge = new CategorieAge();

            catAge.GCAT_CD = line.Substring(0, 5).TrimEnd();
            catAge.GCAT_LB_COURT = line.Substring(5, 5).TrimEnd();
            catAge.GCAT_LB = line.Substring(10, 32).TrimEnd();

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(catAge);
            }
        }

        private void DecoupeBareme(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345
             * FED_NFED_N1_Juniors B                     2              1              128  
             * 
             * BAR_CD           VARCHAR(5)      FED_N
             * BAR_LB           VARCHAR(32)     FED_N1_Juniors B                 
             * BAR_LB_COURT     VARCHAR(5)
             * BAR_ID           NUMERIC(15,0)   2
             * ORGA_ID          NUMERIC(15,0)   1
             * BAR_NB_JOUEUR    INTEGER         128
             * LB_MAJ           NUM(1,0)
             */

            Bareme bareme = new Bareme();

            bareme.BAR_CD = line.Substring(0, 5).TrimEnd();
            bareme.BAR_LB = line.Substring(5, 32).TrimEnd();
            bareme.BAR_LB_COURT = SingletonOutils.StringParse(line.Substring(37, 5));
            bareme.BAR_ID = Convert.ToUInt64(line.Substring(42, 15));
            bareme.ORGA_ID = Convert.ToUInt64(line.Substring(57, 15));
            bareme.BAR_NB_JOUEUR = SingletonOutils.ShortParse(line.Substring(72, 5));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(bareme);
            }
        }

        private void DecoupeLigneOrganisme(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 01234567890123456789012345678901234567890123456789012345678901234567890
             * 46             9              ISERE                           D38  D0
             * 
             * ORGA_IG          NUM(15,0)               46
             * ORG_ORAG_IG      NUM(15,0)               9
             * ORGA_LB          VARCHAR(32)             ISERE
             * ORGA_CD          VARCHAR(5)              D38
             * ORGA_FG          CHAR(1)                 D ( Dept, Ligue ,Zone, Fédé)
             * ORGA_LB_MODULE   NUN(1,0)                0
             * LB_MAJ           NUM(1,0)
             * 
             */

            Organisme organisme = new Organisme();

            organisme.ORGA_ID = Convert.ToUInt64(line.Substring(0,15));

            // Si le champ n'est pas renseigné
            organisme.ORG_ORGA_ID = SingletonOutils.LongParse(line.Substring(15, 15));
            organisme.ORGA_LB = line.Substring(30,32).TrimEnd();
            organisme.ORGA_CD = line.Substring(62,5).TrimEnd();
            organisme.ORGA_FG = SingletonOutils.CharParse(line.Substring(67, 1));
            organisme.ORGA_BL_MODULE = SingletonOutils.CharParse( line.Substring(68, 1) );

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(organisme);
            }
        }

        private void DecoupeLigneDate(string line)
        {
            // date et heure du fichier, Nombre de table
            // 17/11/2021-16:23:251              16
            textBoxMessage.Text += "Extraction du " + line.Substring(0,10) + " à " + line.Substring(11,5) + Environment.NewLine; ;
            textBoxMessage.Refresh();
        }
    }
}
