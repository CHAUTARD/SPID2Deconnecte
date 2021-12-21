using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("NIVEAU-REF")]
    [PrimaryKey("NIVREF_ID", AutoIncrement = false)]
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

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 13814          164523              1/2 finale                      1       1               
             * 13815          164523              Finale                          2       013814          
             * 
             * NIVREF_ID                NUMERIC(15,0)
             * TABREF_ID                NUMERIC(15,0)
             * NIVREF_CD                VARCHAR(5)
             * NIVREF_LB                VARCHAR(32)
             * NIVREF_NB                INTEGER
             * NIVREF_LB_DEPART         NUMERIC(1,0)
             * NIVREF_NIVREF_ID         NUMERIC(15,0)
             * BL_MAJ                   NUMERIC(1,0)
             */

            NIVREF_ID = Convert.ToInt64(line.Substring(0, 15));
            TABREF_ID = Convert.ToInt64(line.Substring(15, 15));
            NIVREF_CD = line.Substring(30, 5).TrimEnd();
            NIVREF_LB = line.Substring(35, 32).TrimEnd();
            NIVREF_NB = short.Parse(line.Substring(67, 8));
            NIVREF_BL_DEPART = line.Substring(75, 1)[0];
            NIVREF_NIVREF_ID = SingletonOutils.LongParse(line.Substring(76, 15));
        }
    }
}
