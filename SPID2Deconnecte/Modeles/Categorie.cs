using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT")]
    [PrimaryKey("CAT_CD", AutoIncrement = false)]
    internal class Categorie : TableBase
    {
        // NUMERIC( 15,0)
        public ulong CAT_ID;

        // CHAR(5)
        public string GCAT_CD;

        // VARCHAR(32)
        public string CAT_LB;

        // VARCHAR(5)
        public string CAT_CD;

        // DATE
        public DateTime CAT_DT_DEB;

        // DATE
        public DateTime CAT_DT_FIN { get; set;}

        // CHAR(1)
        public char CAT_FG;

        // NUMERIC( 15,0)
        public ulong DEM_ID;
    }
}

