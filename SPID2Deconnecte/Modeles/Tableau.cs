using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("TABLEAU")]
    [PrimaryKey("TAB_ID", AutoIncrement = false)]

    internal class Tableau
    {
        // TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TAB_ID;

        // TABREF_ID"	NUMERIC(15, 0),
        public ulong TABREF_ID;

        // TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TOUR_ID;

        // TAB_NB_GROUPE"	INTEGER NOT NULL,
        public int TAB_NB_GROUPE;

        // TAB_CD_TABLEAU"	VARCHAR(5),
        public string TAB_CD_TABLEAU;

        // TAB_LB"	VARCHAR(32) NOT NULL,
        public string TAB_LB;

        // TAB_DT_HEURE"	DATE NOT NULL,
        public DateTime TAB_DT_HEURE;

        // TAB_LB_LIEU"	VARCHAR(32),
        public string TAB_LB_LIEU;

        // TAB_CM_TABLEAU"	VARCHAR(255),
        public string TAB_CM_TABLEAU;

        // TAB_CM_TABLE_JUGE"	VARCHAR(255),
        public string TAB_CM_TABLE_JUGE;

        // TAB_LB_RAPPORT"	VARCHAR(64),
        public string TAB_LB_RAPPORT;

        // TAB_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string TAB_LB_USER_MODIF;

        // TAB_DT_MODIFICATION"	DATE,
        public DateTime TAB_DT_MODIFICATION;

        // TAB_DT_CREATION"	DATE NOT NULL,
        public DateTime TAB_DT_CREATION;
    }
}
