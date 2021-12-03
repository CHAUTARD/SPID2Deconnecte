using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("BAREME_DETAIL")]
    [PrimaryKey("BAR_ID", AutoIncrement = false)]

    internal class BaremeDetail : TableBase
    {
        // NUMERIC(15,0)
        public ulong BAR_ID;

        // NUMERIC(15,0)
        public ulong DBAR_ID_DETAILS;

        // INTEGER
        public int DBAR_NB_PLACE;

        // INTEGER
        public int DBAR_NB_POINT;
    }
}
