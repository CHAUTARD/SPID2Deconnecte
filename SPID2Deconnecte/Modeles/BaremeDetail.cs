using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("BAREME_DETAIL")]
    [PrimaryKey("BAR_ID", AutoIncrement = false)]

    internal class BaremeDetail : TableBase
    {
        // NUMERIC(15,0)
        public ulong BAR_ID { get; set; }

        // NUMERIC(15,0)
        public ulong DBAR_ID_DETAILS { get; set; }

        // INTEGER
        public int DBAR_NB_PLACE { get; set; }

        // INTEGER
        public int DBAR_NB_POINT { get; set; }
    }
}
