using System;
using System.Globalization;

namespace SPID2Deconnecte.Modeles
{
    internal class TableauRef : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TABREF_ID;

        // VARCHAR(5)
         public string TABREF_CD;

        // VARCHAR(32)
         public string TABREF_LB;

        // CHAR(2)
         public string TABREF_FG;

        // INTEGER
         public int TABREF_NB_JOUEURS_REF;

        // VARCHAR(255)
         public string TABREF_CM;

        // VARCHAR(15)
         public string TABREF_LB_USER_MODIF;

        // DATE
         public DateTime TABREF_DT_MODIFICATION;

        // DATE
         public DateTime TABREF_DT_CREATION;

        // CHAR(1)
         public char TABREF_SAISIE_TYPE;

    }
}
