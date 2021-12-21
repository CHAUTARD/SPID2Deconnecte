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

        public void FromTxt(string line)
        {
            /*
                *           1         2         3         
                * 0123456789012345678901234567890123456
                * 2250           1       360     2
                * 
                * DBAR_ID_DETAILS      NUMERIC(15,0)
                * DBAR_NB_PLACE        INTEGER
                * DBAR_NB_POINT        INTEGER
                * DBAR_ID              NUMERIC(15,0)
                * BL_MAJ               NUM(1,0)
                */

            DBAR_ID_DETAILS = Convert.ToUInt64(line.Substring(0, 15));
            DBAR_NB_PLACE = short.Parse(line.Substring(15, 8));
            DBAR_NB_POINT = short.Parse(line.Substring(23, 8));
            BAR_ID = Convert.ToUInt64(line.Substring(31, 15));
        }
    }
}
