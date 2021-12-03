using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("NIVEAU")]
    [PrimaryKey("NIV_ID", AutoIncrement = false)]

    internal class Niveau
    {
        // NIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong NIV_ID;

        // TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TAB_ID;

        // NIVREF_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong NIVREF_ID
;
        // NIV_DT_HEURE"	DATE NOT NULL,
        public DateTime NIV_DT_HEURE;

        // NIV_LB_LIEU"	CHAR(32),
        public string NIV_LB_LIEU;

        // NIV_CM"	VARCHAR(5),
        public string NIV_CM;
    }
}
