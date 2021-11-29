using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT")]
    [PrimaryKey("CAT_CD", AutoIncrement = false)]

    internal class GrilleDetail : TableBase
    {
        // NUMERIC( 15,0)
        public ulong DGRIL_ID_DETAIL { get; set; }

        // INTEGER
         public int DGRIL_NB_JOURNEE { get; set; }

        // INTEGER
         public int DGRIL_NB_EQUIPE1 { get; set; }

        // INTEGER
         public int DGRIL_NB_EQUIPE2 { get; set; }

        // NUMERIC( 15,0)
        public ulong GRIL_ID_RENC { get; set; }
    }
}
