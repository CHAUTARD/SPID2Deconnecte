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
        public ulong? ORG_ORGA_ID;

        // VARCHAR(32)
        public string ORGA_LB { get; set;}

        // VARCHAR(5)
        public string ORGA_CD;

        // CHAR(1)
        // FG ( Dept, Ligue ,Zone, Fédé)
        public string ORGA_FG;

        // NUMERIC(1,0), Null possible
        public string ORGA_BL_MODULE; // 0
    }
}
