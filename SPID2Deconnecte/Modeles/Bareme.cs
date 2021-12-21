using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("BAREME")]
    [PrimaryKey("BAR_ID", AutoIncrement = false)]

    internal class Bareme : TableBase
    {
        // VARCHAR(5)
        public string BAR_CD;

        // VARCHAR(32)
        public string BAR_LB;

        // VARCHAR(5), Null)
        public string BAR_LB_COURT;

        // NUMERIC(15,0)
        public ulong BAR_ID;

        // NUMERIC(15,0)
        public ulong ORGA_ID;

        // INTEGER, Null
        public int? BAR_NB_JOUEUR;

        public void FromTxt(string line)
        {
            /*
                *           1         2         3         4         5         6         7
                * 0123456789012345678901234567890123456789012345678901234567890123456789012345
                * FED_NFED_N1_Juniors B                     2              1              128  
                * 
                * BAR_CD           VARCHAR(5)      FED_N
                * BAR_LB           VARCHAR(32)     FED_N1_Juniors B                 
                * BAR_LB_COURT     VARCHAR(5)
                * BAR_ID           NUMERIC(15,0)   2
                * ORGA_ID          NUMERIC(15,0)   1
                * BAR_NB_JOUEUR    INTEGER         128
                * LB_MAJ           NUM(1,0)
                */

            BAR_CD = line.Substring(0, 5).TrimEnd();
            BAR_LB = line.Substring(5, 32).TrimEnd();
            BAR_LB_COURT = SingletonOutils.StringParse(line.Substring(37, 5));
            BAR_ID = Convert.ToUInt64(line.Substring(42, 15));
            ORGA_ID = Convert.ToUInt64(line.Substring(57, 15));
            BAR_NB_JOUEUR = SingletonOutils.ShortParse(line.Substring(72, 5));
        }
    }
}
