using System;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte.CRUD
{
    internal class LicencieCrud : Licencie
    {
        public LicencieCrud()
        {
        }

        public Licencie GetByNumLicence(string strNumLicence)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // Recherche du joueur dans la table des licenciers
                return db.First<Licencie>("WHERE LIC_NB_LICENCE=@0", strNumLicence);
            }
        }

        public void FromTxt(string line)
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

            LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos = 15;
            CAT_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            CLU_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            TCLST_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            PERS_LB_NOM = line.Substring(pos, 64).TrimEnd();
            pos += 64;
            PERS_LB_PRENOM = line.Substring(pos, 15).TrimEnd();
            pos += 15;
            PERS_FG_SEXE = line.Substring(pos, 1);
            pos++;
            PERS_DT_NAISSANCE = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            LIC_NB_LICENCE = SingletonOutils.StringParse(line.Substring(pos, 8));
            pos += 8;
            LIC_FG_NATIONALITE = line.Substring(pos, 1);
            pos++;
            LIC_FG = line.Substring(pos, 1);
            pos++;
            LIC_FG_MODULE = line.Substring(pos, 1);
            pos++;
            LIC_FG_CERTIFICAT = line.Substring(pos, 1);
            pos++;
            LIC_DT_CERTIFICAT = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            LIC_DT_VALIDATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            LIC_NB_PLACE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            LIC_NB_POINT = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            LIC_FG_ECHELON = line.Substring(pos, 1);
            pos++;
            LIC_NB_POINT_CF_PREC = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            LIC_NB_POINT_TOTAL_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            LIC_NB_TRI_POINT_CF = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            LIC_BL_LOCAL = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            LIC_BL_DOUBLE = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            LIC_NB_TOTAL_POINT_DOUBLE = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            if (pos + 7 > len)
                LIC_NB_POINT_TOUR_PREC_CF = "";
            else
                LIC_NB_POINT_TOUR_PREC_CF = SingletonOutils.StringParse(line.Substring(pos, 7));
            pos += 7;
            if (pos > len)
                EPRV_ID = null;
            else
                EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            if (pos > len)
                DOUBLE_CLUB_ID = null;
            else
                DOUBLE_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            if (pos > len)
                DOUBLE_CLU_CLUB_ID = null;
            else
                DOUBLE_CLU_CLUB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("LICENCIE");
            }
        }
    }
}
