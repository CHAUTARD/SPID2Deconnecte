using System;
using System.Globalization;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT")]
    [PrimaryKey("CAT_CD", AutoIncrement = false)]

    internal class TableauRef : TableBase
    {
        // NUMERIC( 15,0)
        public ulong TABREF_ID;

        // VARCHAR(5)
         public string TABREF_CD;

        // VARCHAR(32)
         public string TABREF_LB;

        // CHAR(2)
         public string TABREF_FG;

        // INTEGER
         public int TABREF_NB_JOUEURS_REF;

        // VARCHAR(255)
         public string TABREF_CM;

        // VARCHAR(15)
         public string TABREF_LB_USER_MODIF;

        // DATE
         public DateTime TABREF_DT_MODIFICATION;

        // DATE
         public DateTime TABREF_DT_CREATION;

        // CHAR(1)
         public char TABREF_SAISIE_TYPE;

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9         10        11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28        29        30        31        32        33        34        35          
             * 01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 164523              34_4D-4J-TED                      4                                                                                                                                                                                                                                                                      system_admin   13/07/202108/07/2021 
             * 164524              36_8D-8J-TED                      8                                                                                                                                                                                                                                                                      system_admin   13/07/202108/07/2021 
             * 
             * TABREF_ID                NUMERIC(15,0)
             * TABREF_CD                VARCHAR(5)
             * TABREF_LB                VARCHAR(32)
             * TABREF_FG                CHAR(2)
             * TABREF_NB_JOUEUR_REF     INTEGER
             * TABREF_CM                VARCHAR(255)
             * TABREF_LB_USER_MOTIF     VARCHAR(15)
             * TABREF_DT_MODIFICATION   DATE
             * TABREF_DT_CREATION       DATE
             * TABREF_SAISIE_TYPE       CHAR(1)
             * BL_MAJ                   NUMERIC(1,0)
             */

            TABREF_ID = Convert.ToUInt64(line.Substring(0, 15));
            TABREF_CD = line.Substring(15, 5).TrimEnd();
            TABREF_LB = line.Substring(20, 32).TrimEnd();
            TABREF_FG = line.Substring(52, 2).TrimEnd();
            TABREF_NB_JOUEURS_REF = short.Parse(line.Substring(54, 8));
            TABREF_CM = line.Substring(62, 255).Trim();
            TABREF_LB_USER_MODIF = line.Substring(317, 15).TrimEnd();
            TABREF_DT_MODIFICATION = DateTime.ParseExact(line.Substring(332, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TABREF_DT_CREATION = DateTime.ParseExact(line.Substring(342, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TABREF_SAISIE_TYPE = line.Substring(352, 1)[0];
        }
    }
}
