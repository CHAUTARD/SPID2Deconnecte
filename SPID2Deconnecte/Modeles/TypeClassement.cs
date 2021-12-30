namespace SPID2Deconnecte.Modeles
{
    internal class TypeClassement : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TCLST_ID{ get; set; }

        // VARCHAR(32)
        public string TCLST_LB{ get; set; }

        // VARCHAR(2)
        public string TCLST_CD{ get; set; }

        // INTEGER
        public int TCLST_NB_POINT_MIN{ get; set; }
    }
}
