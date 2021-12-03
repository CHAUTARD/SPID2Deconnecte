using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT_AGE_GROUP")]
    [PrimaryKey("GCAT_CD", AutoIncrement = false)]

    internal class CategorieAge : TableBase
    {
        // CHAR(5)
        public string GCAT_CD;

        // VARCHAR(5)
        public string GCAT_LB_COURT { get; set;  }

        // VARCHAR(32)
        public string GCAT_LB;
    }
}
