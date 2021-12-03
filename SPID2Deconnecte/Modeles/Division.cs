using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("DIVISION")]
    [PrimaryKey("DIV_ID", AutoIncrement = false)]

    internal class Division
    {
        // DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong DIV_ID;

        // ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong ORGA_ID;

        // EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong EPRV_ID;

        // DIV_CD"	VARCHAR(5) NOT NULL,
        public string DIV_CD;

        // DIV_LB"	VARCHAR(32) NOT NULL,
        public string DIV_LB;

        // DIV_NB_POULE"	INTEGER NOT NULL,
        public ulong DIV_NB_POULE;

        // DIV_FG_SEXE"	CHAR(1) NOT NULL,
        public char DIV_FG_SEXE;

        // DIV_FG_TYPE_LICENCE"	CHAR(1) NOT NULL,
        public char DIV_FG_TYPE_LICENCE;

        // DIV_BL_CORPO"	NUMERIC(1, 0) NOT NULL,
        public int DIV_BL_CORPO;

        // DIV_NB_TOUR"	NUMERIC(1, 0),
        public int DIV_NB_TOUR;

        // DIV_CD_LETTRE"	CHAR(1) NOT NULL,
        public char DIV_CD_LETTRE;

        // DIV_CM"	VARCHAR(255),
        public string DIV_CM;

        // DIV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string DIV_LB_USER_MODIF;

        // BAR_ID"	NUMERIC(15, 0),
        public ulong BAR_ID;

        // GCAT_CD"	CHAR(5),
        public string GCAT_CD;

        // DIV_DIV_ID"	NUMERIC(15, 0),
        public ulong DIV_DIV_ID;

        // DIV_BL_DOUBLE"	NUMERIC(1, 0),
        public int DIV_BL_DOUBLE;

        // DIV_NB_POINT_MANCHE"	INTEGER NOT NULL,
        public ulong DIV_NB_POINT_MANCHE;

        // DIV_NB_MANCHE_POULE"	INTEGER NOT NULL,
        public ulong DIV_NB_MANCHE_POULE;

        // DIV_NB_MANCHE_TAB"	INTEGER NOT NULL,
        public ulong DIV_NB_MANCHE_TAB;

        // DIV_NB_POINT_MIN"	INTEGER NOT NULL,
        public ulong DIV_NB_POINT_MIN;

        // DIV_NB_POINT_MAX"	INTEGER NOT NULL,
        public ulong DIV_NB_POINT_MAX;

        // DIV_DT_TOUR"	DATE,
        public DateTime DIV_DT_TOUR;
    }
}
