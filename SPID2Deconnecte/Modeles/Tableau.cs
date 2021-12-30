using System;
using System.Globalization;

namespace SPID2Deconnecte.Modeles
{
    internal class Tableau
    {
        // TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public long TAB_ID { get; set; }

        // TABREF_ID"	NUMERIC(15, 0),
        public long? TABREF_ID { get; set; }

        // TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public long TOUR_ID { get; set; }

        // TAB_NB_GROUPE"	INTEGER NOT NULL,
        public int TAB_NB_GROUPE { get; set; }

        // TAB_CD_TABLEAU"	VARCHAR(5),
        public string TAB_CD_TABLEAU { get; set; }

        // TAB_LB"	VARCHAR(32) NOT NULL,
        public string TAB_LB { get; set; }

        // TAB_DT_HEURE"	DATE NOT NULL,
        public DateTime TAB_DT_HEURE { get; set; }

        // TAB_LB_LIEU"	VARCHAR(32),
        public string TAB_LB_LIEU { get; set; }

        // TAB_CM_TABLEAU"	VARCHAR(255),
        public string TAB_CM_TABLEAU { get; set; }

        // TAB_CM_TABLE_JUGE"	VARCHAR(255),
        public string TAB_CM_TABLE_JUGE { get; set; }

        // TAB_LB_RAPPORT"	VARCHAR(64),
        public string TAB_LB_RAPPORT { get; set; }

        // TAB_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string TAB_LB_USER_MODIF { get; set; }

        // TAB_DT_MODIFICATION"	DATE,
        public DateTime? TAB_DT_MODIFICATION { get; set; }

        // TAB_DT_CREATION"	DATE NOT NULL,
        public DateTime TAB_DT_CREATION { get; set; }
    }
}
