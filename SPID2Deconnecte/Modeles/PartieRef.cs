using System;

namespace SPID2Deconnecte.Modeles
{
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

    }
}
