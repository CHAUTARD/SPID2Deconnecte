using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CLASSEMENT")]
    [PrimaryKey("CLST_ID", AutoIncrement = false)]

    internal class Classement
    {
        // "CLST_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong CLST_ID;

        // "POUL_ID"	NUMERIC(15, 0),
        public ulong POUL_ID;

        // "CLST_NB_RANG"	INTEGER,
        public int CLST_NB_RANG;

        // "CLST_NB_POINTS"	INTEGER,
        public int CLST_NB_POINTS;

        // "CLST_NB_VICTOIRE"	INTEGER,
        public int CLST_NB_VICTOIRE;

        // "CLST_NB_DEFAITE"	INTEGER,
        public int CLST_NB_DEFAITE;

        // "CLST_NB_EGALITE"	INTEGER,
        public int CLST_NB_EGALITE;

        // "CLST_NB_FORFAITS"	INTEGER,
        public int CLST_NB_FORFAITS;

        // "CLST_NB_PENALITE"	INTEGER,
        public int CLST_NB_PENALITE;

        // "CLST_NB_GAGNE"	INTEGER,
        public int CLST_NB_GAGNE;

        // "CLST_NB_PERDUES"	INTEGER,
        public int CLST_NB_PERDUES;

        // "EQUIP_ID"	NUMERIC(15, 0),
        public ulong EQUIP_ID;

        // "LIC_ID"	NUMERIC(15, 0),
        public ulong LIC_ID;

        // "TAB_ID"	NUMERIC(15, 0),
        public ulong TAB_ID;

        // "CLST_CD_LETTRE"	CHAR(1),
        public char CLST_CD_LETTRE;

        // "NIV_ID"	NUMERIC(15, 0),
        public ulong NIV_ID;

        // "CLST_RANG_FORFAIT"	CHAR(2)
        public string CLST_RANG_FORFAIT;
    }
}
