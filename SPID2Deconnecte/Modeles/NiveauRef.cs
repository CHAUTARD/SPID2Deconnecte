using System;

namespace SPID2Deconnecte.Modeles
{
    internal class NiveauRef : TableBase
    {
        // NUMERIC( 15,0)
        public long NIVREF_ID;

        // NUMERIC( 15,0)
        public long TABREF_ID;
        
        // CHAR(5)
        public string NIVREF_CD;

        // VARCHAR(32)
        public string NIVREF_LB;

        // INTEGER
        public int NIVREF_NB { get; set;}

        // NUMERIC(1,0)
        public char NIVREF_BL_DEPART { get; set;}

        // NUMERIC( 15,0)
        public long? NIVREF_NIVREF_ID;

    }
}
