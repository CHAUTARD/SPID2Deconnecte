using System;
using PetaPoco;


namespace SPID2Deconnecte.Modeles
{
    [TableName("ORGANISME")]
    [PrimaryKey("ORAG_ID", AutoIncrement = false)]
    public class Organisme : TableBase
    {
        // NUMERIC(15,0)
        public ulong ORGA_ID { get; set;}

        // NUMERIC(15,0), Null possible
        public ulong? ORG_ORGA_ID { get; set; }

        // VARCHAR(32)
        public string ORGA_LB { get; set;}

        // VARCHAR(5)
        public string ORGA_CD { get; set; }

        // CHAR(1)
        // FG ( Dept, Ligue ,Zone, Fédé)
        public char ORGA_FG { get; set; }

        // NUMERIC(1,0), Null possible
        public char? ORGA_BL_MODULE { get; set; } // 0
    }
}
