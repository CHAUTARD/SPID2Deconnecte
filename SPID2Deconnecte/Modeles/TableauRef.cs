using System;

namespace SPID2Deconnecte.Modeles
{
    internal class TableauRef : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TABREF_ID{ get; set; }

        // VARCHAR(5)
         public string TABREF_CD{ get; set; }

        // VARCHAR(32)
         public string TABREF_LB{ get; set; }

        // CHAR(2)
         public string TABREF_FG{ get; set; }

        // INTEGER
         public int TABREF_NB_JOUEURS_REF{ get; set; }

        // VARCHAR(255)
         public string TABREF_CM{ get; set; }

        // VARCHAR(15)
         public string TABREF_LB_USER_MODIF{ get; set; }

        // DATE
         public DateTime TABREF_DT_MODIFICATION{ get; set; }

        // DATE
         public DateTime TABREF_DT_CREATION{ get; set; }

        // CHAR(1)
         public char TABREF_SAISIE_TYPE{ get; set; }

    }
}
