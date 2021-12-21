using System;
using PetaPoco;


namespace SPID2Deconnecte.Modeles
{
    [TableName("ORGANISME")]
    [PrimaryKey("ORAG_ID", AutoIncrement = false)]
    public class Organisme : TableBase
    {
        // NUMERIC(15,0)
        public long ORGA_ID { get; set;}

        // NUMERIC(15,0), Null possible
        public long? ORG_ORGA_ID;

        // VARCHAR(32)
        public string ORGA_LB { get; set;}

        // VARCHAR(5)
        public string ORGA_CD;

        // CHAR(1)
        // FG ( Dept, Ligue ,Zone, Fédé)
        public string ORGA_FG;

        // NUMERIC(1,0), Null possible
        public string ORGA_BL_MODULE; // 0

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7
             * 01234567890123456789012345678901234567890123456789012345678901234567890
             * 46             9              ISERE                           D38  D0
             * 
             * ORGA_IG          NUM(15,0)               46
             * ORG_ORAG_IG      NUM(15,0)               9
             * ORGA_LB          VARCHAR(32)             ISERE
             * ORGA_CD          VARCHAR(5)              D38
             * ORGA_FG          CHAR(1)                 D ( Dept, Ligue ,Zone, Fédé)
             * ORGA_LB_MODULE   NUN(1,0)                0
             * LB_MAJ           NUM(1,0)
             * 
             */

            ORGA_ID = Convert.ToInt64(line.Substring(0, 15));

            // Si le champ n'est pas renseigné
            ORG_ORGA_ID = SingletonOutils.LongParse(line.Substring(15, 15));
            ORGA_LB = line.Substring(30, 32).TrimEnd();
            ORGA_CD = line.Substring(62, 5).TrimEnd();
            ORGA_FG = SingletonOutils.CharParse(line.Substring(67, 1));
            ORGA_BL_MODULE = SingletonOutils.CharParse(line.Substring(68, 1));

        }
    }
}
