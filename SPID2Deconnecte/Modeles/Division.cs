using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("DIVISION")]
    [PrimaryKey("DIV_ID", AutoIncrement = false)]

    internal class Division
    {
        // DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID { get; set; }

        // ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public long ORGA_ID { get; set; }

        // EPRV_ID"	NUMERIC(15, 0) NULL,
        public long? EPRV_ID { get; set; }

        // DIV_CD"	VARCHAR(5) NOT NULL,
        public string DIV_CD { get; set; }

        // DIV_LB"	VARCHAR(32) NOT NULL,
        public string DIV_LB { get; set; }

        // DIV_NB_POULE"	INTEGER NOT NULL,
        public int DIV_NB_POULE { get; set; }

        // DIV_FG_SEXE"	CHAR(1) NOT NULL,
        public string DIV_FG_SEXE { get; set; }

        // DIV_FG_TYPE_LICENCE"	CHAR(1) NOT NULL,
        public string DIV_FG_TYPE_LICENCE { get; set; }

        // DIV_BL_CORPO"	NUMERIC(1, 0) NOT NULL,
        public int DIV_BL_CORPO { get; set; }

        // DIV_NB_TOUR"	NUMERIC(1, 0),
        public int? DIV_NB_TOUR { get; set; }

        // DIV_CD_LETTRE"	CHAR(1) NOT NULL,
        public char DIV_CD_LETTRE { get; set; }

        // DIV_CM"	VARCHAR(255),
        public string DIV_CM;

        // DIV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string DIV_LB_USER_MODIF { get; set; }

        // BAR_ID"	NUMERIC(15, 0),
        public long? BAR_ID { get; set; }

        // GCAT_CD"	CHAR(5),
        public string GCAT_CD { get; set; }

        // DIV_DIV_ID"	NUMERIC(15, 0),
        public long? DIV_DIV_ID { get; set; }

        // DIV_BL_DOUBLE"	NUMERIC(1, 0),
        public int? DIV_BL_DOUBLE { get; set; }

        // DIV_NB_POINT_MANCHE"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MANCHE { get; set; }

        // DIV_NB_MANCHE_POULE"	INTEGER NOT NULL,
        public int DIV_NB_MANCHE_POULE { get; set; }

        // DIV_NB_MANCHE_TAB"	INTEGER NOT NULL,
        public int DIV_NB_MANCHE_TAB { get; set; }

        // DIV_NB_POINT_MIN"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MIN { get; set; }

        // DIV_NB_POINT_MAX"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MAX { get; set; }

        // DIV_DT_TOUR"	DATE,
        public DateTime DIV_DT_TOUR { get; set; }

        public Division()
        {
            DIV_DIV_ID = (long?)null;
            DIV_NB_POINT_MANCHE = 11;
            DIV_NB_MANCHE_POULE = 0;
            DIV_NB_MANCHE_TAB = 0;
            DIV_NB_POINT_MIN = 0;
            DIV_NB_POINT_MAX = 9999;


        }
    }
}
