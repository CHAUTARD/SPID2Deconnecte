using System;
using System.Globalization;

namespace SPID2Deconnecte.Modeles
{
    internal class GrilleRencontre : TableBase
    {
        // NUMERIC( 15,0)
        public ulong GRIL_ID_RENC;

        // NUMERIC( 15,0)
        public ulong ORGA_ID;

        // VARCHAR(5)
        public string GRIL_CD_RENC { set; get; }

        // VARCHAR(32)
        public string GRIL_LB_RENC { set; get; }

        // INTEGER
         public int GRIL_NB_EQUIPE;

        // CHAR(1)
         public char GRIL_FG;

        // // VARCHAR(15), Null
        public string GRIL_LB_USER_MODIF;

        // DATE, Null
        public DateTime GRIL_DT_CREATION;
    }
}
