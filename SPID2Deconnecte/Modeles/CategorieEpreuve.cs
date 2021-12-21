using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CATEGORIE_EPREUVE")]
    [PrimaryKey("INDEX", AutoIncrement = true)]

    internal class CategorieEpreuve
    {
        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong DIV_ID { get; set; }

        // "CAT_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong CAT_ID { get; set; }

        // "CAT_EPR_BL_PRINCIPAL"	NUMERIC(1, 0),
        public int CAT_EPR_BL_PRINCIPAL { get; set; }

        public CategorieEpreuve()
        {
            CAT_EPR_BL_PRINCIPAL = 0;
        }
    }
}
