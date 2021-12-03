using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("TOUR")]
    [PrimaryKey("TOUR_ID", AutoIncrement = false)]
    internal class Tour
    {
        // "TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TOUR_ID;

        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong DIV_ID;

        // "TOUR_LB"	VARCHAR(32),
        public string TOUR_LB;

        // "TOUR_NB_GROUPE"	INTEGER,
        public int TOUR_NB_GROUPE;

        // "TOUR_NB_POULE"	INTEGER,
        public int TOUR_NB_POULE;

        // "TOUR_NB_JOUEUR"	INTEGER,
        public ulong TOUR_NB_JOUEUR;

        // "TOUR_NB_JOUEUR_DESC"	INTEGER,
        public int TOUR_NB_JOUEUR_DESC;

        // "TOUR_NB_JOUEUR_MONT"	INTEGER,
        public int TOUR_NB_JOUEUR_MONT;

        // "TOUR_DT"	DATE,
        public DateTime TOUR_DT;

        // "TOUR_LB_USER_MODIF"	VARCHAR(15),
        public string TOUR_LB_USER_MODIF;

        // "TOUR_DT_MODIFICATION"	DATE,
        public DateTime TOUR_DT_MODIFICATION;

        // "TOUR_DT_CREATION"	DATE,
        public DateTime TOUR_DT_CREATION;

        // "GRIL_ID_RENC"	NUMERIC(15, 0),
        public ulong GRIL_ID_RENC;

        // "TOUR_BL_CLOTURE"	NUMERIC(1, 0),
        public int TOUR_BL_CLOTURE;

        // "TOUR_NM"	INTEGER,
        public int TOUR_NM;

        // "DIV_DIV_LB"	VARCHAR(32),
        public string DIV_DIV_LB;

        // "DIV2_DIV_LB"	VARCHAR(32),
        public string DIV2_DIV_LB;
    }
}
