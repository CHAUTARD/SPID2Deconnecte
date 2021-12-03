using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("INSCRIPTION")]
    [PrimaryKey("INSC_ID", AutoIncrement = false)]
    internal class Inscription
    {
        // INSC_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong INSC_ID;

        // JOUE_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong JOUE_ID;

        // TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TOUR_ID;

        // INSC_NB_DOSSARD"	INTEGER NOT NULL,
        public int INSC_NB_DOSSARD;

        // INSC_NB_RANG_POULE"	INTEGER NOT NULL,
        public int INSC_NB_RANG_POULE;

        // INSC_NB_POINT_TOUR"	INTEGER,
        public int INSC_NB_POINT_TOUR;

        // INSC_BL_ABSENT"	NUMERIC(1, 0) NOT NULL,
        public int INSC_BL_ABSENT;

        // POUL_ID"	NUMERIC(15, 0),
        public ulong POUL_ID;

        // TOUR_ID_PREC"	NUMERIC(15, 0),
        public ulong TOUR_ID_PREC;

        // INSC_NB_RANG_TOUR"	INTEGER,
        public int INSC_NB_RANG_TOUR;

        // INSC_NM_RANG_TABLEAU"	INTEGER,
        public int INSC_NM_RANG_TABLEAU;

        // INSC_CD_LETTRE"	CHAR(1),
        public char INSC_CD_LETTRE;

        // TAB_ID"	NUMERIC(15, 0),
        public ulong TAB_ID;

        // INSC_BL_TETE_SERIE"	NUMERIC(1, 0),
        public int INSC_BL_TETE_SERIE;

        // INSC_NM_CLASSEMENT"	INTEGER,
        public int INSC_NM_CLASSEMENT;

        // INSC_TIRAGE_POS_TAB"	INTEGER,
        public int INSC_TIRAGE_POS_TAB;

        // INSC_BL_TIRAGE_TETE_SERIE"	NUMERIC(1, 0),
        public int INSC_BL_TIRAGE_TETE_SERIE;
    }
}
