using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CATEGORIE_EPREUVE")]
    [PrimaryKey("DIV_ID,CAT_ID", AutoIncrement = false)]
    internal class CategorieEpreuve
    {
        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong DIV_ID;

        // "CAT_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong CAT_ID;

        // "CAT_EPR_BL_PRINCIPAL"	NUMERIC(1, 0),
        public bool CAT_EPR_BL_PRINCIPAL;
    }
}
