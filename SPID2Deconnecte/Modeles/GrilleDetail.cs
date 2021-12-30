using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("GRILLE_DETAIL")]
    [PrimaryKey("DGRIL_ID_DETAIL", AutoIncrement = false)]

    internal class GrilleDetail : TableBase
    {
        // NUMERIC( 15,0)
        public ulong DGRIL_ID_DETAIL;

        // INTEGER
         public int DGRIL_NB_JOURNEE;

        // INTEGER
         public int DGRIL_NB_EQUIPE1;

        // INTEGER
         public int DGRIL_NB_EQUIPE2;

        // NUMERIC( 15,0)
        public ulong GRIL_ID_RENC;
    }
}
