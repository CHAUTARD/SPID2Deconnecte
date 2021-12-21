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

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4        
             * 01234567890123456789012345678901234567890123456
             * 29             1       1       4       481 
             * 
             * DGRIL_ID_DETAIL          NUMERIC(15,0)
             * DGRIL_NB_JOURNEE         INTEGER
             * DGRIL_NB_EQUIPE1         INTEGER
             * DGRIL_NB_EQUIPE2         INTEGER
             * GRIL_ID_RENC            NUMERIC(15,0)
             * BL_MAJ                   NUMERIC(1,0)
             */

            DGRIL_ID_DETAIL = Convert.ToUInt64(line.Substring(0, 15));
            DGRIL_NB_JOURNEE = short.Parse(line.Substring(15, 8));
            DGRIL_NB_EQUIPE1 = short.Parse(line.Substring(23, 8));
            DGRIL_NB_EQUIPE2 = short.Parse(line.Substring(31, 8));
            GRIL_ID_RENC = Convert.ToUInt64(line.Substring(39, 15));
        }
    }
}
