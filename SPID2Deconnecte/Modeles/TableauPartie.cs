using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("TABLEAU_PARTIE")]
    [PrimaryKey("TABPART_ID_TABLEAU", AutoIncrement = false)]
    internal class TableauPartie
    {
        // "TABPART_ID_TABLEAU"	NUMERIC(15, 0) NOT NULL,
        public long TABPART_ID_TABLEAU { get; set; }

        // "POUL_ID"	NUMERIC(15, 0),
        public long? POUL_ID { get; set; }

        // "NIV_ID"	NUMERIC(15, 0),
        public long? NIV_ID { get; set; }

        // "INSC_ID"	NUMERIC(15, 0),
        public long? INSC_ID { get; set; }

        // "INS_INSC_ID"	NUMERIC(15, 0),
        public long? INS_INSC_ID { get; set; }

        // "PARTI_ID"	NUMERIC(15, 0),
        public long? PARTI_ID { get; set; }

        // "TABPART_NM_ORDRE_NIVEAU"	INTEGER,
        public int? TABPART_NM_ORDRE_NIVEAU { get; set; }

        // "TABPART_NM_TABLEAU"	INTEGER,
        public int? TABPART_NM_TABLEAU { get; set; }

        // "TABPART_NM_VAINQUEUR"	INTEGER,
        public int? TABPART_NM_VAINQUEUR { get; set; }

        // "TABPART_DT_HEURE"	DATE NOT NULL,
        public DateTime TABPART_DT_HEURE { get; set; }

        // "TABPART_NB_TABLE"	CHAR(5),
        public string TABPART_NB_TABLE { get; set; }

        // "RPARTI_ID_PARTIE_REF"	NUMERIC(15, 0),
        public long? RPARTI_ID_PARTIE_REF { get; set; }

        // "TABPART_TYPE_PARTIE"	NUMERIC(1, 0),
        public int? TABPART_TYPE_PARTIE { get; set; }

        // "TABPART_NM_PERDANT"	INTEGER,
        public int? TABPART_NM_PERDANT { get; set; }

        // "TABPART_LB_PARTIE"	VARCHAR(10),
        public string TABPART_LB_PARTIE { get; set; }

        // "TABPART_BL_CLST"	NUMERIC(1, 0) default 0,
        public int? TABPART_BL_CLST { get; set; }
}
}
