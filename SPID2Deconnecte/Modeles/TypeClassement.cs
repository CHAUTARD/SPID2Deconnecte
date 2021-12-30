using System;

namespace SPID2Deconnecte.Modeles
{
    internal class TypeClassement : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TCLST_ID;

        // VARCHAR(32)
        public string TCLST_LB;

        // VARCHAR(2)
        public string TCLST_CD;

        // INTEGER
        public int TCLST_NB_POINT_MIN;

    }
}
