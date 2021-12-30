using System;
using System.Windows;
using MySql.Data.MySqlClient;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CATEGORIE_EPREUVE")]
    [PrimaryKey("DIV_ID,CAT_ID", AutoIncrement = false)]

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
