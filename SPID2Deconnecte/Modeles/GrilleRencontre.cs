using System;
using System.Globalization;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("GRILLE_RENCONTRE")]
    [PrimaryKey("GRIL_ID_RENC", AutoIncrement = false)]

    internal class GrilleRencontre : TableBase
    {
        // NUMERIC( 15,0)
        public ulong GRIL_ID_RENC;

        // NUMERIC( 15,0)
        public ulong ORGA_ID;

        // VARCHAR(5)
        public string GRIL_CD_RENC { set; get; }

        // VARCHAR(32)
        public string GRIL_LB_RENC { set; get; }

        // INTEGER
         public int GRIL_NB_EQUIPE;

        // CHAR(1)
         public char GRIL_FG;

        // // VARCHAR(15), Null
        public string GRIL_LB_USER_MODIF;

        // DATE, Null
        public DateTime GRIL_DT_CREATION;

        public void FromTxt(string line)
        {
            /*
                *           1         2         3         4         5         6         7         8         9         10        11
                * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
                * 151            1              FED_JFED_Poule 8 joueurs             8       IFED_Jmichel.bremond@01/07/2021
                * 
                * GRIL_ID_RENC         NUMERIC(15,0)
                * ORGA_ID              NUMERIC(15,0)
                * GRIL_CD_RENC         VARCHAR(5)
                * GRIL_LB_RENC         VARCHAR(32)
                * GRIL_NB_EQUIPE       INTEGER
                * GRIL_FG              CHAR(1)
                * GRIL_LB_USER_MODIF   VARCHAR(15)
                * GRIL_DT_CREATION     DATE
                * BL_MAJ               NUMERIC(1,0)
                */

            GRIL_ID_RENC = Convert.ToUInt64(line.Substring(0, 15));
            ORGA_ID = Convert.ToUInt64(line.Substring(15, 15));
            GRIL_CD_RENC = line.Substring(30, 5).TrimEnd();
            GRIL_LB_RENC = line.Substring(35, 32).TrimEnd();
            GRIL_NB_EQUIPE = short.Parse(line.Substring(67, 8));
            GRIL_FG = line.Substring(75, 1)[0];
            GRIL_LB_USER_MODIF = line.Substring(76, 20).TrimEnd();
            DateTime dt = DateTime.ParseExact(line.Substring(96, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            GRIL_DT_CREATION = dt;
        }
    }
}
