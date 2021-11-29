using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("GRILLE_RENCONTRE")]
    [PrimaryKey("GRIL_ID_RENC", AutoIncrement = false)]

    internal class GrilleRencontre : TableBase
    {
        // NUMERIC( 15,0)
        public ulong GRIL_ID_RENC { get; set; }

        // NUMERIC( 15,0)
        public ulong ORGA_ID { get; set; }

        // VARCHAR(5)
        public string GRIL_CD_RENC { set; get; }

        // VARCHAR(32)
        public string GRIL_LB_RENC { set; get; }

        // INTEGER
         public int GRIL_NB_EQUIPE { get; set; }

        // CHAR(1)
         public char GRIL_FG { get; set; }

        // // VARCHAR(15), Null
        public string GRIL_LB_USER_MODIF { get; set; }

        // DATE, Null
        public DateTime GRIL_DT_CREATION { get; set; }
    }
}
