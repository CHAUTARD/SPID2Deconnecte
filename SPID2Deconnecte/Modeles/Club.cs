using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CLUB")]
    [PrimaryKey("CLUB_ID", AutoIncrement = false)]

    internal class Club
    {
        // NUMERIC(15,0)
        public ulong CLUB_ID;

        // NUMERIC(15,0) - Non renseigné
        public ulong? ORGA_ID;

        // VARCHAR(8)
        public string CLUB_NM;

        // VARCHAR(32)
        public string CLUB_LB_LONG;

        // VARCHAR(15)
        public string CLUB_LB_COURT;

        // CHAR(1)
        public string CLUB_FG;
    }
}
