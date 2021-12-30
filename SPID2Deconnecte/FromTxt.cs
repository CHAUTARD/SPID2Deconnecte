using SPID2Deconnecte.Modeles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPID2Deconnecte
{
    internal class FromTxt
    {
        public BaremeDetail BaremeDetailFromTxt(string line)
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

            return baremeDetail;
        }

        public Bareme BaremeFromTxt(string line)
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

            return bareme;
        }

        public Categorie CategorieFromTxt(string line)
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
            Categorie categorie = new Categorie();

            categorie.CAT_ID = Convert.ToUInt64(line.Substring(0, 15));
            categorie.GCAT_CD = line.Substring(15, 5).TrimEnd();
            categorie.CAT_LB = line.Substring(20, 32).TrimEnd();
            categorie.CAT_CD = line.Substring(52, 5).TrimEnd();

            DateTime dt = DateTime.ParseExact(line.Substring(57, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            categorie.CAT_DT_DEB = dt;

            dt = DateTime.ParseExact(line.Substring(67, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            categorie.CAT_DT_FIN = dt;

            categorie.CAT_FG = line.Substring(77, 1);
            categorie.DEM_ID = 0;

            return categorie;
        }

        public CategorieAge CategorieAgeFromTxt(string line)
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
            CategorieAge categorieAge = new CategorieAge();

            categorieAge.GCAT_CD = line.Substring(0, 5).TrimEnd();
            categorieAge.GCAT_LB_COURT = line.Substring(5, 5).TrimEnd();
            categorieAge.GCAT_LB = line.Substring(10, 32).TrimEnd();

            return categorieAge;
        }

        public CategorieEpreuve CategorieEpreuveFromTxt(string line)
        {
            CategorieEpreuve categorieEpreuve = new CategorieEpreuve();

            categorieEpreuve.DIV_ID = Convert.ToInt64(line.Substring(0, 15));
            categorieEpreuve.CAT_ID = Convert.ToInt64(line.Substring(15, 15));
            categorieEpreuve.CAT_EPR_BL_PRINCIPAL = Convert.ToInt16(line.Substring(30, 1));

            return categorieEpreuve;
        }

        public Classement ClassementFromTxt(string line)
        {
            int pos = 0;
            Classement classement = new Classement();

            classement.CLST_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            classement.POUL_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            classement.CLST_NB_RANG = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_POINTS = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_VICTOIRE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_DEFAITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_EGALITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_FORFAITS = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_PENALITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_GAGNE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.CLST_NB_PERDUES = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            classement.EQUIP_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            classement.LIC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            classement.TAB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            classement.CLST_CD_LETTRE = line.Substring(pos, 1)[0];
            pos++;

            classement.NIV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            classement.CLST_RANG_FORFAIT = line.Substring(pos, 2);

            return classement;
        }

        public Club ClubFromTxt(string line)
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

            club.CLUB_ID = Convert.ToInt64(line.Substring(0, 15));

            // Si le champ n'est pas renseigné
            club.ORGA_ID = null;
            club.CLUB_NM = line.Substring(15, 8).TrimEnd();
            club.CLUB_LB_LONG = line.Substring(23, 32).TrimEnd();
            club.CLUB_LB_COURT = line.Substring(55, 15);
            club.CLUB_FG = SingletonOutils.CharParse(line.Substring(70, 1));

            return club;
        }

        public Division DivisionFromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10                  11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28         30        31        32       33        34        35        36        37        38        39        40        41  
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
             * 36295          16                            2302           R118DL08LocalR1 - 18 ans dames           4       FT04D                                                                                                                                                                                                                                                               9999    0       sportive.ligue@90             SEN  21/11/2021
             */
            int pos = 0;
            Division division = new Division();

            division.DIV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos = 15;
            division.ORGA_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            // ???
            pos += 15;

            division.EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            division.DIV_CD = line.Substring(pos, 5).Trim();
            pos += 5;
            division.DIV_LB = line.Substring(pos, 32).Trim();
            pos += 32;
            division.DIV_NB_POULE = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            division.DIV_FG_SEXE = line.Substring(pos, 1);
            pos++;
            division.DIV_FG_TYPE_LICENCE = line.Substring(pos, 1);
            pos++;
            division.DIV_BL_CORPO = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            division.DIV_NB_TOUR = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            division.DIV_CD_LETTRE = line.Substring(pos, 1);
            pos++;
            division.DIV_CM = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            division.DIV_NB_POINT_MAX = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            division.DIV_NB_POINT_MIN = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            division.DIV_LB_USER_MODIF = line.Substring(pos, 15).Trim();
            pos += 15;
            division.BAR_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            division.GCAT_CD = SingletonOutils.StringParse(line.Substring(pos, 5));
            pos += 5;
            division.DIV_DT_TOUR = SingletonOutils.DateParse(line.Substring(pos, 10));

            return division;
        }

        public Epreuve EpreuveFromTxt(string line)
        {
            /*
                *           1         2         3         4         5         6         7         8         9                   10                  11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28         30        31        32         
                * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456
                * 2302           1              I FED_CFED_Criterium Federal           C                                                                                                                                                                                                                                                               system_admin   
                */
            int pos = 0;
            Epreuve epreuve = new Epreuve();

            epreuve.EPRV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos = 15;

            epreuve.ORGA_ID = Convert.ToInt64(line.Substring(pos, 15).Trim());
            pos += 15;

            // EPR_EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            //
            // pos += 15;

            epreuve.EPRV_CD = line.Substring(pos, 2).Trim();
            pos += 2;

            epreuve.EPRV_LB_COURT = line.Substring(pos, 5).Trim();
            pos += 5;

            epreuve.EPRV_LB = line.Substring(pos, 32).Trim();
            pos += 32;

            epreuve.EPRV_FG = line.Substring(pos, 10)[0];
            pos++;

            epreuve.EPRV_CM = line.Substring(pos, 255).Trim();
            pos += 255;

            epreuve.EPRV_LB_USER_MODIF = line.Substring(pos, 15).Trim();

            return epreuve;
        }

        public GrilleDetail GrilleDetailFromTxt(string line)
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


            return grilleDetail;
        }

        public GrilleRencontre GrilleRencontreFromTxt(string line)
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

            return grilleRencontre;
        }

        public Inscription InscriptionFromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10        11        12        13        14    
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 65241          114564         39879          0       1               0147134                        1       0       D39997          985110         9141941 
             */
            int pos = 0;
            Inscription inscription = new Inscription();

            inscription.INSC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            inscription.JOUE_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            inscription.TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            inscription.INSC_NB_DOSSARD = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;
            inscription.INSC_NB_RANG_POULE = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;
            inscription.INSC_NB_POINT_TOUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            inscription.INSC_BL_ABSENT = Convert.ToInt32(line.Substring(pos, 1));
            pos++;
            inscription.POUL_ID = SingletonOutils.LongSParse(line.Substring(pos, 15));
            pos += 15;
            inscription.TOUR_ID_PREC = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            inscription.INSC_NB_RANG_TOUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            inscription.INSC_NM_RANG_TABLEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            inscription.INSC_CD_LETTRE = line.Substring(pos, 1);
            // pos++;

            inscription.TAB_ID = 0; //  SingletonOutils.LongParse(line.Substring(pos, 15));
            // pos += 15;
            inscription.INSC_BL_TETE_SERIE = 0; //  Convert.ToInt32(line.Substring(pos, 1));
            // pos++;
            inscription.INSC_NM_CLASSEMENT = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            inscription.INSC_TIRAGE_POS_TAB = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            inscription.INSC_BL_TIRAGE_TETE_SERIE = 0; //  Convert.ToInt32(line.Substring(pos, 1));

            return inscription;
        }

        public Joueur JoueurFromTxt(string line)
        {
            int pos = 0;
            Joueur joueur = new Joueur();

            // TAB_ID"	NUMERIC(15, 0) NOT NULL,
            joueur.JOUE_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            joueur.EPRV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            joueur.LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            joueur.JOUE_NB_POINT_TOTAL = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;

            joueur.JOUE_BL_FORFAIT_GENE = Convert.ToInt64(line.Substring(pos, 8));
            pos += 8;

            joueur.JOUE_LB_TRI_POINT = SingletonOutils.StringParse(line.Substring(pos, 64));

            joueur.PRESENT = false;

            return joueur;
        }

        public Licencie LicencieFromTxt(string line)
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

            int pos = 0;
            int len = line.Length;
            Licencie licencie = new Licencie();

            licencie.LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
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
            licencie.PERS_FG_SEXE = line.Substring(pos, 1);
            pos++;
            licencie.PERS_DT_NAISSANCE = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_NB_LICENCE = SingletonOutils.StringParse(line.Substring(pos, 8));
            pos += 8;
            licencie.LIC_FG_NATIONALITE = line.Substring(pos, 1);
            pos++;
            licencie.LIC_FG = line.Substring(pos, 1);
            pos++;
            licencie.LIC_FG_MODULE = line.Substring(pos, 1);
            pos++;
            licencie.LIC_FG_CERTIFICAT = line.Substring(pos, 1);
            pos++;
            licencie.LIC_DT_CERTIFICAT = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_DT_VALIDATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            licencie.LIC_NB_PLACE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            licencie.LIC_NB_POINT = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            licencie.LIC_FG_ECHELON = line.Substring(pos, 1);
            pos++;
            licencie.LIC_NB_POINT_CF_PREC = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_NB_POINT_TOTAL_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_NB_TRI_POINT_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            licencie.LIC_BL_LOCAL = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            licencie.LIC_BL_DOUBLE = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            licencie.LIC_NB_TOTAL_POINT_DOUBLE = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            if (pos + 7 > len)
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

            return licencie;
        }

        public Niveau NiveauFromTxt(string line)
        {
            int pos = 0;
            Niveau niveau = new Niveau();

            niveau.NIV_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            niveau.TAB_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            niveau.NIVREF_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            niveau.NIV_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;

            niveau.NIV_LB_LIEU = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;

            niveau.NIV_CM = SingletonOutils.StringParse(line.Substring(pos, 5));

            return niveau;
        }

        public NiveauRef NiveauRefFromTxt(string line)
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

            niveauRef.NIVREF_ID = Convert.ToInt64(line.Substring(0, 15));
            niveauRef.TABREF_ID = Convert.ToInt64(line.Substring(15, 15));
            niveauRef.NIVREF_CD = line.Substring(30, 5).TrimEnd();
            niveauRef.NIVREF_LB = line.Substring(35, 32).TrimEnd();
            niveauRef.NIVREF_NB = short.Parse(line.Substring(67, 8));
            niveauRef.NIVREF_BL_DEPART = line.Substring(75, 1)[0];
            niveauRef.NIVREF_NIVREF_ID = SingletonOutils.LongParse(line.Substring(76, 15));

            return niveauRef;
        }

        public Organisme OrganismeFromTxt(string line)
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

            organisme.ORGA_ID = Convert.ToInt64(line.Substring(0, 15));

            // Si le champ n'est pas renseigné
            organisme.ORG_ORGA_ID = SingletonOutils.LongParse(line.Substring(15, 15));
            organisme.ORGA_LB = line.Substring(30, 32).TrimEnd();
            organisme.ORGA_CD = line.Substring(62, 5).TrimEnd();
            organisme.ORGA_FG = SingletonOutils.CharParse(line.Substring(67, 1));
            organisme.ORGA_BL_MODULE = SingletonOutils.CharParse(line.Substring(68, 1));

            return organisme;
        }

        public Package PackageFromTxt(string line)
        {
            /*
            *           1         2         3         4         5         6         7         8         9         
            * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
            * 1923           patrick.chautarCriterium - Tour 2 - R1 - FeminiEpatrick.chautar17/11/202117/11/2021
            */
            int pos = 0;
            Package package = new Package();

            package.PKG_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos = 15;

            package.UTIL_LB_LOGIN = line.Substring(pos, 15).Trim();
            pos += 15;

            package.PKG_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;

            package.PKG_ETAT = line.Substring(pos, 1)[0];
            pos++;

            package.PKG_LB_USER_MODIF = SingletonOutils.StringParse(line.Substring(pos, 15));
            pos += 15;

            package.PKG_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;

            package.PKG_DT_CREATION = SingletonOutils.DateParse(line.Substring(pos, 10));

            return package;
        }

        public PackageTableau PackageTableauFromTxt(string line)
        {
            PackageTableau package = new PackageTableau();

            package.PKG_ID = Convert.ToUInt64(line.Substring(0, 15));
            package.TAB_ID = Convert.ToUInt64(line.Substring(15, 15));

            return package;
        }

        public Partie PartieFromTxt(string line)
        {
            int pos = 0;
            Partie partie = new Partie();

            partie.PARTI_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            partie.LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            partie.LIC_LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            partie.RENC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            partie.PARTI_NB_ORDRE = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;

            partie.PARTI_BL_GAGNE1 = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            partie.PARTI_BL_GAGNE2 = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            partie.PARTI_BL_FORFAIT = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            partie.EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            partie.PARTI_BL_SUPPRIMEE = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            partie.PARTI_DT = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;

            partie.PARTI_NM_TOUR = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;

            partie.PARTI_BL_DOUBLE = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            partie.TAB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));

            partie.PARTI_NB_POINT1 = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));

            partie.PARTI_NB_POINT2 = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));

            partie.PARTI_BL_CLST = 0; //  Convert.ToInt32(line.Substring(pos, 1));

            partie.PARTI_BL_NONJOUEE = 0; // Convert.ToInt32(line.Substring(pos, 1));

            return partie;
        }

        public PartieRef PartieRefFromTxt(string line)
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

            partieRef.RPARTI_ID_PARTIE_REF = Convert.ToInt64(line.Substring(0, 15));
            partieRef.NIVREF_ID = Convert.ToInt64(line.Substring(15, 15));
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

            return partieRef;
        }

        public Tableau TableauFromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10        11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28        29        30        31        32        33        34        35   .    36        37        38        39        40        41        42        43        44        45        46        47        48        49        50        51        52        53        54        55        56        57        58        59        60        61        62        63        64        65        66        67        68        69        70        71        72        73           
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123
             * 39997                         39879          Groupe 1     Groupe 1                        21/11/2021                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              sportive.ligue@28/09/202107/07/2021
             */
            int pos = 0;
            Tableau tableau = new Tableau();

            tableau.TAB_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            tableau.TABREF_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableau.TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            //MessageBox.Show(">" + line.Substring(pos, 8)+"<");
            tableau.TAB_NB_GROUPE = 0; //  Convert.ToUInt16( line.Substring(pos, 8));
            pos += 8;
            tableau.TAB_CD_TABLEAU = SingletonOutils.StringParse(line.Substring(pos, 5));
            pos += 5;
            tableau.TAB_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            tableau.TAB_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;
            tableau.TAB_LB_LIEU = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            tableau.TAB_CM_TABLEAU = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            tableau.TAB_CM_TABLE_JUGE = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            tableau.TAB_LB_RAPPORT = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            tableau.TAB_LB_USER_MODIF = line.Substring(pos, 15);
            pos += 15;
            tableau.TAB_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            tableau.TAB_DT_CREATION = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            return tableau;
        }

        public TableauPartie TableauPartieFromTxt(string line)
        {
            int pos = 0;
            TableauPartie tableauPartie = new TableauPartie();

            tableauPartie.TABPART_ID_TABLEAU = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.POUL_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.NIV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.INSC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.INS_INSC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.PARTI_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tableauPartie.TABPART_NM_ORDRE_NIVEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tableauPartie.TABPART_NM_TABLEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tableauPartie.TABPART_NM_VAINQUEUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tableauPartie.TABPART_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            // pos += 10;
            // TABPART_NBLocalTABLE = SingletonOutils.StringParse(line.Substring(pos, 5));
            // pos += 5;
            // RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(pos, 15));
            // pos += 15;
            // TABPARTLocalTYPE_PARTIE = Convert.ToInt32(line.Substring(pos, 1));
            // pos++;
            // TABPART_NM_PERDANT = null; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            // TABPART_LB_PARTIE = ""; //  SingletonOutils.StringParse(line.Substring(pos, 10));
            // pos += 10;
            // TABPART_BL_CLST = null; // Convert.ToInt32(line.Substring(pos, 1));

            return tableauPartie;
        }

        public TableauRef TableauRefFromTxt(string line)
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
            tableauRef.TABREF_DT_MODIFICATION = DateTime.ParseExact(line.Substring(332, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            tableauRef.TABREF_DT_CREATION = DateTime.ParseExact(line.Substring(342, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            tableauRef.TABREF_SAISIE_TYPE = line.Substring(352, 1)[0];

            return tableauRef;
        }

        public Tour TourFromTxt(string line)
        {
            int pos = 0;
            Tour tour = new Tour();

            tour.TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            tour.DIV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            tour.TOUR_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            tour.TOUR_NB_GROUPE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.TOUR_NB_POULE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.TOUR_NB_JOUEUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.TOUR_NB_JOUEUR_DESC = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.TOUR_NB_JOUEUR_MONT = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.TOUR_DT = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            tour.TOUR_LB_USER_MODIF = SingletonOutils.StringParse(line.Substring(pos, 15));
            pos += 15;
            tour.TOUR_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            tour.TOUR_DT_CREATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            tour.GRIL_ID_RENC = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            tour.TOUR_BL_CLOTURE = SingletonOutils.ShortParse(line.Substring(pos, 1));
            pos++;
            tour.TOUR_NM = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            tour.DIV_DIV_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            tour.DIV2_DIV_LB = SingletonOutils.StringParse(line.Substring(pos, 32));

            return tour;
        }

        public TypeClassement TypeClassementFromTxt(string line)
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
            typeClassement.TCLST_CD = SingletonOutils.StringParse(line.Substring(47, 2));
            typeClassement.TCLST_NB_POINT_MIN = short.Parse(line.Substring(49, 8));

            return typeClassement;
        }

    }
}
