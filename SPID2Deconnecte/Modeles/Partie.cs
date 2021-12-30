using System;

namespace SPID2Deconnecte.Modeles
{
    internal class Partie
    {
        // "PARTI_ID"	NUMERIC(15, 0) NOT NULL,
        public long PARTI_ID { get; set; }

        // "LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public long LIC_ID { get; set; }

        // "LIC_LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public long LIC_LIC_ID { get; set; }

        // "RENC_ID"	NUMERIC(15, 0),
        public long? RENC_ID { get; set; }

        // "PARTI_NB_ORDRE"	INTEGER NOT NULL,
        public int PARTI_NB_ORDRE { get; set; }

        // "PARTI_BL_GAGNE1"	NUMERIC(1, 0) NOT NULL,
        public int PARTI_BL_GAGNE1 { get; set; }

        // "PARTI_BL_GAGNE2"	NUMERIC(1, 0) NOT NULL,
        public int PARTI_BL_GAGNE2 { get; set; }

        // "PARTI_BL_FORFAIT"	NUMERIC(1, 0) NOT NULL,
        public int PARTI_BL_FORFAIT { get; set; }

        // "EPRV_ID"	NUMERIC(15, 0),
        public long? EPRV_ID { get; set; }

        // "PARTI_BL_SUPPRIMEE"	NUMERIC(1, 0),
        public int PARTI_BL_SUPPRIMEE { get; set; }

        // "PARTI_DT"	DATE NOT NULL,
        public DateTime PARTI_DT { get; set; }

        // "PARTI_NM_TOUR"	INTEGER,
        public int? PARTI_NM_TOUR { get; set; }

        // "PARTI_BL_DOUBLE"	NUMERIC(1, 0),
        public int PARTI_BL_DOUBLE { get; set; }

        // "TAB_ID"	NUMERIC(15, 0),
        public long? TAB_ID { get; set; }

        // "PARTI_NB_POINT1"	INTEGER,
        public int? PARTI_NB_POINT1 { get; set; }

        // "PARTI_NB_POINT2"	INTEGER,
        public int? PARTI_NB_POINT2 { get; set; }

        // "PARTI_BL_CLST"	NUMERIC(1, 0),
        public int PARTI_BL_CLST { get; set; }

        // "PARTI_BL_NONJOUEE"	NUMERIC(1, 0),
        public int PARTI_BL_NONJOUEE { get; set; }
    }
}
