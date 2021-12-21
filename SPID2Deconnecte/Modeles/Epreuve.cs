using System;
using System.ComponentModel.DataAnnotations.Schema;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("EPREUVE")]
    [PrimaryKey("EPRV_ID", AutoIncrement = true)]

    internal class Epreuve
    {
        public Epreuve()
        {
            EPR_EPRV_ID = (long?)null;
        }

        //  "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public long EPRV_ID { get; set; }

        //  "ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public long ORGA_ID { get; set; }

        //  "EPR_EPRV_ID"	NUMERIC(15, 0), il n'existe pas dans les données en entrées
        public long? EPR_EPRV_ID { get; set; }

        //  "EPRV_CD"	CHAR(2) NOT NULL,
        public string EPRV_CD { get; set; }

        //  "EPRV_LB_COURT"	VARCHAR(5) NOT NULL,
        public string EPRV_LB_COURT { get; set; }

        //  "EPRV_LB"	VARCHAR(32) NOT NULL,
        public string EPRV_LB { get; set; }

        //  "EPRV_FG"	CHAR(1) NOT NULL,
        public string EPRV_FG { get; set; }

        //  "EPRV_CM"	VARCHAR(255),
        public string EPRV_CM { get; set; }

        //  "EPRV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string EPRV_LB_USER_MODIF { get; set; }
    }
}
