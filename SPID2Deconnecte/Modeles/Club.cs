using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CLUB")]
    [PrimaryKey("CLUB_ID", AutoIncrement = false)]

    internal class Club
    {
        // NUMERIC(15,0)
        public ulong CLUB_ID;

        // NUMERIC(15,0) - Non renseigné
        public ulong? ORGA_ID;

        // VARCHAR(8)
        public string CLUB_NM;

        // VARCHAR(32)
        public string CLUB_LB_LONG;

        // VARCHAR(15)
        public string CLUB_LB_COURT;

        // CHAR(1)
        public string CLUB_FG;

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 01234567890123456789012345678901234567890123456789012345678901234567890
             */
            /*
             *           1         2         3         4         5         6         7
             * 012345678901234567890123456789012345678901234567890123456789012345678901234
             * 1010001        01010001HAUT BUGEY TT                   La Cluse 01HBTTL
             * 
             * CLUB_ID          NUMERIC(15,0)
             *  // ORGA_ID          NUMERIC(8,0) - Non renseigné
             * CLUB_NM          VARCHAR(8)
             * CLUB_LG_LONG     VARCHAR(32)
             * CLUB_LB_COURT    VARCHAR(15)
             * CLUB_FG          CHAR(1)
             */

            CLUB_ID = Convert.ToUInt64(line.Substring(0, 15));

            // Si le champ n'est pas renseigné
            ORGA_ID = null;
            CLUB_NM = line.Substring(15, 8).TrimEnd();
            CLUB_LB_LONG = line.Substring(23, 32).TrimEnd();
            CLUB_LB_COURT = line.Substring(55, 15);
            CLUB_FG = SingletonOutils.CharParse(line.Substring(70, 1));

        }
    }
}
