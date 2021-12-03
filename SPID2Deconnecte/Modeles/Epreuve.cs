using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("EPREUVE")]
    [PrimaryKey("EPRV_ID", AutoIncrement = false)]

    internal class Epreuve
    {
        //  "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong PKG_ID;

        //  "ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong ORGA_ID;

        //  "EPR_EPRV_ID"	NUMERIC(15, 0),
        public ulong EPR_EPRV_ID;

        //  "EPRV_CD"	CHAR(2) NOT NULL,
        public string EPRV_CD;

        //  "EPRV_LB_COURT"	VARCHAR(5) NOT NULL,
        public string EPRV_LB_COURT;

        //  "EPRV_LB"	VARCHAR(32) NOT NULL,
        public string EPRV_LB;

        //  "EPRV_FG"	CHAR(1) NOT NULL,
        public char EPRV_FG;

        //  "EPRV_CM"	VARCHAR(255),
        public string EPRV_CM;

        //  "EPRV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string EPRV_LB_USER_MODIF;
    }
}
