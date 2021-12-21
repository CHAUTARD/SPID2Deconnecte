using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("PARTIE_REF")]
    [PrimaryKey("NIVREF_ID", AutoIncrement = false)]

    internal class PartieRef : TableBase
    {
        // NUMERIC( 15,0)
        public long RPARTI_ID_PARTIE_REF;

        // NUMERIC( 15,0)
        public long NIVREF_ID;

        // NUMERIC( 15,0)
        public long? PAR_RPARTI_ID_PARTIE_REF;

        // NUMERIC( 15,0)
        public long? PAR2_RPARTI_ID_PARTIE_REF;

        // INTEGER
         public int? RPARTI_NM_RANG1;

        // INTEGER
        public int? RPARTI_NM_RANG2;

        // INTEGER
        public int? RPARTI_NM_ORDRE_REF;

        // INTEGER
        public int? RPARTI_NM_PARTIE_REF;

        // CHAR(1)
         public char? RPARTI_FG_PARTIE_1;

        // INTEGER
        public int? RPARTI_NM_CLST_VAINQUEUR;

        // INTEGER
        public int? RPARTI_NM_POULE1;

        // INTEGER
        public int? RPARTI_NM_CLASSEMENT1;

        // INTEGER
        public int? RPARTI_NM_POULE2;

        // INTEGER
        public int? RPARTI_NM_CLASSEMENT2;

        // INTEGER
        public int? RPARTI_NM_POSITION1;

        // INTEGER
        public int? RPARTI_NM_POSITION2;

        // CHAR(1)
         public char? RPARTI_FG_PARTIE_2;

        // INTEGER
        public int? RPARTI_NM_CLST_PERDANT;

        // CHAR(1)
         public char RPARTI_FG_PARTIE_REF;

        // CHAR(1)
         public char? RPARTI_NM_CLST_REF;

        // NUMERIC(1,0)
        public int? RPARTI_BL_CLST_NONJOUEE;

        public void FromTxt(string line)
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

            RPARTI_ID_PARTIE_REF = Convert.ToInt64(line.Substring(0, 15));
            NIVREF_ID = Convert.ToInt64(line.Substring(15, 15));
            PAR_RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(30, 15));
            PAR2_RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(45, 15));
            RPARTI_NM_RANG1 = SingletonOutils.ShortParse(line.Substring(60, 8));
            RPARTI_NM_RANG2 = SingletonOutils.ShortParse(line.Substring(68, 8));
            RPARTI_NM_ORDRE_REF = SingletonOutils.ShortParse(line.Substring(76, 8));
            RPARTI_NM_PARTIE_REF = SingletonOutils.ShortParse(line.Substring(84, 8));
            RPARTI_FG_PARTIE_1 = line.Substring(92, 1)[0];
            RPARTI_NM_CLST_VAINQUEUR = SingletonOutils.ShortParse(line.Substring(93, 8));
            RPARTI_NM_POULE1 = SingletonOutils.ShortParse(line.Substring(101, 8));
            RPARTI_NM_CLASSEMENT1 = SingletonOutils.ShortParse(line.Substring(109, 8));
            RPARTI_NM_POULE2 = SingletonOutils.ShortParse(line.Substring(117, 8));
            RPARTI_NM_POSITION1 = SingletonOutils.ShortParse(line.Substring(133, 8));
            RPARTI_NM_POSITION2 = SingletonOutils.ShortParse(line.Substring(141, 8));
            RPARTI_FG_PARTIE_2 = line.Substring(149, 1)[0];
            RPARTI_NM_CLST_PERDANT = SingletonOutils.ShortParse(line.Substring(150, 8));

            RPARTI_FG_PARTIE_REF = line.Substring(158, 1)[0];
            RPARTI_NM_CLST_REF = line.Substring(159, 1)[0];
            RPARTI_BL_CLST_NONJOUEE = 0;
        }
    }
}
