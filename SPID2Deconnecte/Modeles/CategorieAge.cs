namespace SPID2Deconnecte.Modeles
{
    internal class CategorieAge : TableBase
    {
        // CHAR(5)
        public string GCAT_CD { get; set; }

        // VARCHAR(5)
        public string GCAT_LB_COURT { get; set;  }

        // VARCHAR(32)
        public string GCAT_LB { get; set; }
    }
}
