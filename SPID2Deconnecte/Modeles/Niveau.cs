using System;

namespace SPID2Deconnecte.Modeles
{
    internal class Niveau
    {
        // NIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong NIV_ID { get; set; }

        // TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TAB_ID { get; set; }

        // NIVREF_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong NIVREF_ID { get; set; }
        // NIV_DT_HEURE"	DATE NOT NULL,
        public DateTime NIV_DT_HEURE { get; set; }

        // NIV_LB_LIEU"	CHAR(32),
        public string NIV_LB_LIEU { get; set; }

        // NIV_CM"	VARCHAR(5),
        public string NIV_CM { get; set; }
    }
}
