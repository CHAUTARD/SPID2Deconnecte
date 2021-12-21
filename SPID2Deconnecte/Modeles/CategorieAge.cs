using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT_AGE_GROUP")]
    [PrimaryKey("GCAT_CD", AutoIncrement = false)]

    internal class CategorieAge : TableBase
    {
        // CHAR(5)
        public string GCAT_CD;

        // VARCHAR(5)
        public string GCAT_LB_COURT { get; set;  }

        // VARCHAR(32)
        public string GCAT_LB;

        public void FromTxt(string line)
        {
            /*
                *           1         2         3         4         5         6         7
                * 0123456789012345678901234567890123456789012345678901234567890123456789012345
                * POU  POU  Poussins
                * 
                * GCAT_CD          CHAR(5)
                * GCAT_LB_COURT    VARCHAR(5)
                * GCAT_LB          VARCHAR(32)
                * LB_MAJ           NUM(1,0)
                */

            GCAT_CD = line.Substring(0, 5).TrimEnd();
            GCAT_LB_COURT = line.Substring(5, 5).TrimEnd();
            GCAT_LB = line.Substring(10, 32).TrimEnd();
        }
    }
}
