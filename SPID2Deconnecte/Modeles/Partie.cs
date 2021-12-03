using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("PARTIE")]
    [PrimaryKey("PARTI_ID", AutoIncrement = false)]

    internal class Partie
    {
        // "PARTI_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong PARTI_ID;

        // "LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong LIC_ID;

        // "LIC_LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong LIC_LIC_ID;

        // "RENC_ID"	NUMERIC(15, 0),
        public ulong RENC_ID;

        // "PARTI_NB_ORDRE"	INTEGER NOT NULL,
        public int PARTI_NB_ORDRE;

        // "PARTI_BL_GAGNE1"	NUMERIC(1, 0) NOT NULL,
        public ulong PARTI_BL_GAGNE1;

        // "PARTI_BL_GAGNE2"	NUMERIC(1, 0) NOT NULL,
        public ulong PARTI_BL_GAGNE2;

        // "PARTI_BL_FORFAIT"	NUMERIC(1, 0) NOT NULL,
        public ulong PARTI_BL_FORFAIT;

        // "EPRV_ID"	NUMERIC(15, 0),
        public ulong EPRV_ID;

        // "PARTI_BL_SUPPRIMEE"	NUMERIC(1, 0),
        public int PARTI_BL_SUPPRIMEE;

        // "PARTI_DT"	DATE NOT NULL,
        public DateTime PARTI_DT;

        // "PARTI_NM_TOUR"	INTEGER,
        public int PARTI_NM_TOUR;

        // "PARTI_BL_DOUBLE"	NUMERIC(1, 0),
        public int PARTI_BL_DOUBLE;

        // "TAB_ID"	NUMERIC(15, 0),
        public ulong TAB_ID;

        // "PARTI_NB_POINT1"	INTEGER,
        public int PARTI_NB_POINT1;

        // "PARTI_NB_POINT2"	INTEGER,
        public int PARTI_NB_POINT2;

        // "PARTI_BL_CLST"	NUMERIC(1, 0),
        public int PARTI_BL_CLST;

        // "PARTI_BL_NONJOUEE"	NUMERIC(1, 0),
        public int PARTI_BL_NONJOUEE;
    }
}
