using System;
using System.Globalization;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("CAT")]
    [PrimaryKey("CAT_CD", AutoIncrement = false)]
    internal class Categorie : TableBase
    {
        // NUMERIC( 15,0)
        public ulong CAT_ID;

        // CHAR(5)
        public string GCAT_CD;

        // VARCHAR(32)
        public string CAT_LB;

        // VARCHAR(5)
        public string CAT_CD;

        // DATE
        public DateTime CAT_DT_DEB;

        // DATE
        public DateTime CAT_DT_FIN { get; set;}

        // CHAR(1)
        public char CAT_FG;

        // NUMERIC( 15,0)
        public ulong DEM_ID;

        public void FromTxt(string line)
        {
            /*
                *           1         2         3         4         5         6         7
                * 01234567890123456789012345678901234567890123456789012345678901234567890123456789 
                * 1                   Veterans 4                      V4   01/01/194231/12/1951X
                * 
                * CAT_ID           NUMERIC(15,0)
                * GCAT_CD          CHAR(5)
                * CAT_LB           VARCHAR(32)
                * CAT_CD           VARCHAR(5)
                * CAT_DT_DEBUT     DATE
                * CAT_DT_FIN       DATE
                * CAT_FG           CHAR(1)
                * DEM_ID           NUMERIC(15,0)
                * LB_MAJ           NUM(1,0)
                */

            CAT_ID = Convert.ToUInt64(line.Substring(0, 15));
            GCAT_CD = line.Substring(15, 5).TrimEnd();
            CAT_LB = line.Substring(20, 32).TrimEnd();
            CAT_CD = line.Substring(52, 5).TrimEnd();

            DateTime dt = DateTime.ParseExact(line.Substring(57, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            CAT_DT_DEB = dt;

            dt = DateTime.ParseExact(line.Substring(67, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            CAT_DT_FIN = dt;

            CAT_FG = line.Substring(77, 1)[0];
            DEM_ID = 0;
        }
    }
}

