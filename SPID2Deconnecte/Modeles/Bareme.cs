using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("BAREME")]
    [PrimaryKey("BAR_ID", AutoIncrement = false)]

    internal class Bareme : TableBase
    {
        // VARCHAR(5)
        public string BAR_CD { get; set; }

        // VARCHAR(32)
        public string BAR_LB { get; set; }

        // VARCHAR(5), Null)
        public string BAR_LB_COURT { get; set; }

        // NUMERIC(15,0)
        public ulong BAR_ID { get; set; }

        // NUMERIC(15,0)
        public ulong ORGA_ID { get; set; }

        // INTEGER, Null
        public int? BAR_NB_JOUEUR { get; set; }
    }
}
