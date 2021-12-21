using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("TYPE_CLASSEMENT")]
    [PrimaryKey("TCLS_ID", AutoIncrement = false)]
    internal class TypeClassement : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TCLST_ID;

        // VARCHAR(32)
        public string TCLST_LB;

        // VARCHAR(2)
        public string TCLST_CD;

        // INTEGER
        public int TCLST_NB_POINT_MIN;

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5
             * 012345678901234567890123456789012345678901234567890123456
             * 20             5                               5 500  
             * 
             * TCLS_ID              NUMERIC(15,0)
             * TCLS_LB              VARCHAR(32)
             * TCLS_CD              VARCHAR(2)
             * TCLS_NB_POINT_MIN    INTEGER
             * BL_MAJ               NUMERIC(1,0)
             * 
             */

            TCLST_ID = Convert.ToUInt64(line.Substring(0, 15));
            TCLST_LB = line.Substring(15, 32).TrimEnd();
            TCLST_CD = SingletonOutils.StringParse(line.Substring(47, 2));
            TCLST_NB_POINT_MIN = short.Parse(line.Substring(49, 8));
        }
    }
}
