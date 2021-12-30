using System;

namespace SPID2Deconnecte.Modeles
{
    internal class PartieRef : TableBase
    {
        // NUMERIC( 15,0)
        public long RPARTI_ID_PARTIE_REF{ get; set; }

        // NUMERIC( 15,0)
        public long NIVREF_ID{ get; set; }

        // NUMERIC( 15,0)
        public long? PAR_RPARTI_ID_PARTIE_REF{ get; set; }

        // NUMERIC( 15,0)
        public long? PAR2_RPARTI_ID_PARTIE_REF{ get; set; }

        // INTEGER
         public int? RPARTI_NM_RANG1{ get; set; }

        // INTEGER
        public int? RPARTI_NM_RANG2{ get; set; }

        // INTEGER
        public int? RPARTI_NM_ORDRE_REF{ get; set; }

        // INTEGER
        public int? RPARTI_NM_PARTIE_REF{ get; set; }

        // CHAR(1)
         public char? RPARTI_FG_PARTIE_1{ get; set; }

        // INTEGER
        public int? RPARTI_NM_CLST_VAINQUEUR{ get; set; }

        // INTEGER
        public int? RPARTI_NM_POULE1{ get; set; }

        // INTEGER
        public int? RPARTI_NM_CLASSEMENT1{ get; set; }

        // INTEGER
        public int? RPARTI_NM_POULE2{ get; set; }

        // INTEGER
        public int? RPARTI_NM_CLASSEMENT2{ get; set; }

        // INTEGER
        public int? RPARTI_NM_POSITION1{ get; set; }

        // INTEGER
        public int? RPARTI_NM_POSITION2{ get; set; }

        // CHAR(1)
         public char? RPARTI_FG_PARTIE_2{ get; set; }

        // INTEGER
        public int? RPARTI_NM_CLST_PERDANT{ get; set; }

        // CHAR(1)
         public char RPARTI_FG_PARTIE_REF{ get; set; }

        // CHAR(1)
         public char? RPARTI_NM_CLST_REF{ get; set; }

        // NUMERIC(1,0)
        public int? RPARTI_BL_CLST_NONJOUEE{ get; set; }

    }
}
