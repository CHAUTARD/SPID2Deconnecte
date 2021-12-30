namespace SPID2Deconnecte.Modeles
{
    public class Organisme : TableBase
    {
        // NUMERIC(15,0)
        public long ORGA_ID { get; set;}

        // NUMERIC(15,0), Null possible
        public long? ORG_ORGA_ID { get; set; }

        // VARCHAR(32)
        public string ORGA_LB { get; set;}

        // VARCHAR(5)
        public string ORGA_CD { get; set; }

        // CHAR(1)
        // FG ( Dept, Ligue ,Zone, Fédé)
        public string ORGA_FG { get; set; }

        // NUMERIC(1,0), Null possible
        public string ORGA_BL_MODULE { get; set;}
}
}
