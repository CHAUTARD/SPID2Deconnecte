namespace SPID2Deconnecte.Modeles
{
    internal class Classement
    {
        // "CLST_ID"	NUMERIC(15, 0) NOT NULL,
        public long CLST_ID { get; set; }

        // "POUL_ID"	NUMERIC(15, 0),
        public long? POUL_ID { get; set; }

        // "CLST_NB_RANG"	INTEGER,
        public int? CLST_NB_RANG { get; set; }

        // "CLST_NB_POINTS"	INTEGER,
        public int? CLST_NB_POINTS { get; set; }

        // "CLST_NB_VICTOIRE"	INTEGER,
        public int? CLST_NB_VICTOIRE { get; set; }

        // "CLST_NB_DEFAITE"	INTEGER,
        public int? CLST_NB_DEFAITE { get; set; }

        // "CLST_NB_EGALITE"	INTEGER,
        public int? CLST_NB_EGALITE { get; set; }

        // "CLST_NB_FORFAITS"	INTEGER,
        public int? CLST_NB_FORFAITS { get; set; }

        // "CLST_NB_PENALITE"	INTEGER,
        public int? CLST_NB_PENALITE { get; set; }

        // "CLST_NB_GAGNE"	INTEGER,
        public int? CLST_NB_GAGNE { get; set; }

        // "CLST_NB_PERDUES"	INTEGER,
        public int? CLST_NB_PERDUES { get; set; }

        // "EQUIP_ID"	NUMERIC(15, 0),
        public long? EQUIP_ID { get; set; }

        // "LIC_ID"	NUMERIC(15, 0),
        public long? LIC_ID { get; set; }

        // "TAB_ID"	NUMERIC(15, 0),
        public long? TAB_ID { get; set; }

        // "CLST_CD_LETTRE"	CHAR(1),
        public char CLST_CD_LETTRE { get; set; }

        // "NIV_ID"	NUMERIC(15, 0),
        public long? NIV_ID { get; set; }

        // "CLST_RANG_FORFAIT"	CHAR(2)
        public string CLST_RANG_FORFAIT { get; set; }

    }
}
