using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("TABLEAU_PARTIE")]
    [PrimaryKey("TABPART_ID_TABLEAU", AutoIncrement = false)]
    internal class TableauPartie
    {
        // "TABPART_ID_TABLEAU"	NUMERIC(15, 0) NOT NULL,
        public ulong TABPART_ID_TABLEAU;

        // "POUL_ID"	NUMERIC(15, 0),
        public ulong POUL_ID;

        // "NIV_ID"	NUMERIC(15, 0),
        public ulong NIV_ID;

        // "INSC_ID"	NUMERIC(15, 0),
        public ulong INSC_ID;

        // "INS_INSC_ID"	NUMERIC(15, 0),
        public ulong INS_INSC_ID;

        // "PARTI_ID"	NUMERIC(15, 0),
        public ulong PARTI_ID;

        // "TABPART_NM_ORDRE_NIVEAU"	INTEGER,
        public int TABPART_NM_ORDRE_NIVEAU;

        // "TABPART_NM_TABLEAU"	INTEGER,
        public int TABPART_NM_TABLEAU;

        // "TABPART_NM_VAINQUEUR"	INTEGER,
        public int TABPART_NM_VAINQUEUR;

        // "TABPART_DT_HEURE"	DATE NOT NULL,
        public DateTime TABPART_DT_HEURE;

        // "TABPART_NB_TABLE"	CHAR(5),
        public string TABPART_NB_TABLE;

        // "RPARTI_ID_PARTIE_REF"	NUMERIC(15, 0),
        public ulong RPARTI_ID_PARTIE_REF;

        // "TABPART_TYPE_PARTIE"	NUMERIC(1, 0),
        public int TABPART_TYPE_PARTIE;

        // "TABPART_NM_PERDANT"	INTEGER,
        public int TABPART_NM_PERDANT;

        // "TABPART_LB_PARTIE"	VARCHAR(10),
        public string TABPART_LB_PARTIE;

        // "TABPART_BL_CLST"	NUMERIC(1, 0) default 0,
        public int TABPART_BL_CLST;
    }
}
