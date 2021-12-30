using System;

namespace SPID2Deconnecte.Modeles
{
    internal class BaremeDetail : TableBase
    {
        // NUMERIC(15,0)
        public ulong BAR_ID{ get; set; }

        // NUMERIC(15,0)
        public ulong DBAR_ID_DETAILS{ get; set; }

        // INTEGER
        public int DBAR_NB_PLACE{ get; set; }

        // INTEGER
        public int DBAR_NB_POINT{ get; set; }
    }
}
