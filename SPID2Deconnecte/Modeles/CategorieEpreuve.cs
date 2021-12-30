namespace SPID2Deconnecte.Modeles
{
    internal class CategorieEpreuve
    {
        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID { get; set; }

        // "CAT_ID"	NUMERIC(15, 0) NOT NULL,
        public long CAT_ID { get; set; }

        // "CAT_EPR_BL_PRINCIPAL"	NUMERIC(1, 0),
        public int CAT_EPR_BL_PRINCIPAL { get; set; }

        public CategorieEpreuve()
        {
            CAT_EPR_BL_PRINCIPAL = 0;
        }
    }
}
