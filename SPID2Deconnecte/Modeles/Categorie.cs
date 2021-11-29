using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT")]
    [PrimaryKey("CAT_CD", AutoIncrement = false)]
    internal class Categorie : TableBase
    {
        // NUMERIC( 15,0)
        public ulong CAT_ID { get; set; }

        // CHAR(5)
        public string GCAT_CD { get; set; }

        // VARCHAR(32)
        public string CAT_LB { get; set; }

        // VARCHAR(5)
        public string CAT_CD { get; set; }

        // DATE
        public DateTime CAT_DT_DEB { get; set; }

        // DATE
        public DateTime CAT_DT_FIN { get; set;}

        // CHAR(1)
        public char CAT_FG { get; set; }

        // NUMERIC( 15,0)
        public ulong DEM_ID { get; set; }
    }
}

