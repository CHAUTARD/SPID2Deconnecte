using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("POULE")]
    [PrimaryKey("POUL_ID", AutoIncrement = false)]

    internal class Poule
    {
        // "POUL_ID"	NUMERIC(15, 0) NOT NULL,
        public long POUL_ID;

        // "GRIL_ID_RENC"	NUMERIC(15, 0) NOT NULL,
        public long GRIL_ID_RENC;

        // "CALEN_ID_SPORTIF"	NUMERIC(15, 0),
        public long CALEN_ID_SPORTIF;

        // "FEUIL_ID_RENC"	NUMERIC(15, 0),
        public long FEUIL_ID_RENC;

        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID;

        // "POUL_CD"	VARCHAR(5) NOT NULL,
        public string POUL_CD;

        // "POUL_LB"	VARCHAR(32) NOT NULL,
        public string POUL_LB;

        // "POUL_NM_GROUPE"	SMALLINT,
        public int POUL_NM_GROUPE;

        // "POUL_BL_VIRTUEL"	NUMERIC(1, 0) NOT NULL,
        public int POUL_BL_VIRTUEL;

        // "POUL_DT"	DATE,
        public DateTime POUL_DT;

        // "POUL_DT_VALIDATION"	DATE,
        public DateTime POUL_DT_VALIDATION;

        // "POUL_LB_COMPETIT"	VARCHAR(32),
        public string POUL_LB_COMPETIT;

        // "POUL_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string POUL_LB_USER_MODIF;

        // "POUL_DT_MODIFICATION"	DATE,
        public DateTime POUL_DT_MODIFICATION;

        // "POUL_DT_CREATION"	DATE NOT NULL,
        public DateTime POUL_DT_CREATION;

        // "TAB_ID"	NUMERIC(15, 0),
        public long TAB_ID;

        // "POUL_NM_TABLEAU"	INTEGER,
        public int POUL_NM_TABLEAU;
    }
}
