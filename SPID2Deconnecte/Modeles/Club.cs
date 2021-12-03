using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CLUB")]
    [PrimaryKey("CLUB_ID", AutoIncrement = false)]

    internal class Club
    {
        // NUMERIC(15,0)
        public ulong CLUB_ID { get; set; }

        // NUMERIC(15,0) - Non renseigné
        public ulong? ORGA_ID { get; set; }

        // VARCHAR(8)
        public string CLUB_NM { get; set; }

        // VARCHAR(32)
        public string CLUB_LB_LONG { get; set; }

        // VARCHAR(15)
        public string CLUB_LB_COURT { get; set; }

        // CHAR(1)
        public string CLUB_FG { get; set; }
    }
}
