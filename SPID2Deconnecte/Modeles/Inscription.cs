using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("INSCRIPTION")]
    [PrimaryKey("INSC_ID", AutoIncrement = false)]
    internal class Inscription
    {
        // INSC_ID"	NUMERIC(15, 0) NOT NULL,
        public long INSC_ID { get; set; }

        // JOUE_ID"	NUMERIC(15, 0) NOT NULL,
        public long JOUE_ID { get; set; }

        // TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public long TOUR_ID { get; set; }

        // INSC_NB_DOSSARD"	INTEGER NOT NULL,
        public int INSC_NB_DOSSARD { get; set; }

        // INSC_NB_RANG_POULE"	INTEGER NOT NULL,
        public int INSC_NB_RANG_POULE { get; set; }

        // INSC_NB_POINT_TOUR"	INTEGER,
        public int? INSC_NB_POINT_TOUR { get; set; }

        // INSC_BL_ABSENT"	NUMERIC(1, 0) NOT NULL,
        public int INSC_BL_ABSENT { get; set; }

        // POUL_ID"	NUMERIC(15, 0),
        public long? POUL_ID { get; set; }

        // TOUR_ID_PREC"	NUMERIC(15, 0),
        public long? TOUR_ID_PREC { get; set; }

        // INSC_NB_RANG_TOUR"	INTEGER,
        public int? INSC_NB_RANG_TOUR { get; set; }

        // INSC_NM_RANG_TABLEAU"	INTEGER,
        public int? INSC_NM_RANG_TABLEAU { get; set; }

        // INSC_CD_LETTRE"	CHAR(1),
        public string INSC_CD_LETTRE { get; set; }

        // TAB_ID"	NUMERIC(15, 0),
        public long? TAB_ID { get; set; }

        // INSC_BL_TETE_SERIE"	NUMERIC(1, 0),
        public int? INSC_BL_TETE_SERIE { get; set; }

        // INSC_NM_CLASSEMENT"	INTEGER,
        public int? INSC_NM_CLASSEMENT { get; set; }

        // INSC_TIRAGE_POS_TAB"	INTEGER,
        public int? INSC_TIRAGE_POS_TAB { get; set; }

        // INSC_BL_TIRAGE_TETE_SERIE"	NUMERIC(1, 0),
        public int INSC_BL_TIRAGE_TETE_SERIE { get; set; }
    }
}
