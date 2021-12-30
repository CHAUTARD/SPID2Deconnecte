using System;

namespace SPID2Deconnecte.Modeles
{
    internal class Poule
    {
        // "POUL_ID"	NUMERIC(15, 0) NOT NULL,
        public long POUL_ID{ get; set; }

        // "GRIL_ID_RENC"	NUMERIC(15, 0) NOT NULL,
        public long GRIL_ID_RENC{ get; set; }

        // "CALEN_ID_SPORTIF"	NUMERIC(15, 0),
        public long CALEN_ID_SPORTIF{ get; set; }

        // "FEUIL_ID_RENC"	NUMERIC(15, 0),
        public long FEUIL_ID_RENC{ get; set; }

        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID{ get; set; }

        // "POUL_CD"	VARCHAR(5) NOT NULL,
        public string POUL_CD{ get; set; }

        // "POUL_LB"	VARCHAR(32) NOT NULL,
        public string POUL_LB{ get; set; }

        // "POUL_NM_GROUPE"	SMALLINT,
        public int POUL_NM_GROUPE{ get; set; }

        // "POUL_BL_VIRTUEL"	NUMERIC(1, 0) NOT NULL,
        public int POUL_BL_VIRTUEL{ get; set; }

        // "POUL_DT"	DATE,
        public DateTime POUL_DT{ get; set; }

        // "POUL_DT_VALIDATION"	DATE,
        public DateTime POUL_DT_VALIDATION{ get; set; }

        // "POUL_LB_COMPETIT"	VARCHAR(32),
        public string POUL_LB_COMPETIT{ get; set; }

        // "POUL_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string POUL_LB_USER_MODIF{ get; set; }

        // "POUL_DT_MODIFICATION"	DATE,
        public DateTime POUL_DT_MODIFICATION{ get; set; }

        // "POUL_DT_CREATION"	DATE NOT NULL,
        public DateTime POUL_DT_CREATION{ get; set; }

        // "TAB_ID"	NUMERIC(15, 0),
        public long TAB_ID{ get; set; }

        // "POUL_NM_TABLEAU"	INTEGER,
        public int POUL_NM_TABLEAU{ get; set; }
    }
}
