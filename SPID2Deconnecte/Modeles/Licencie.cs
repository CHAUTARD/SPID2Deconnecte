using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("LICENCIE")]
    [PrimaryKey("LIC_ID", AutoIncrement = false)]

    internal class Licencie
    {
        //         NUMERIC(15,0)
        public ulong  LIC_ID;

        //  NUMERIC(15,0)
        public ulong?  CAT_ID;

        // NUMERIC(15,0)
        public ulong? CLUB_ID;

        //  NUMERIC(15,0)
        public ulong? CLU_CLUB_ID;

        //  NUMERIC(15,0)
        public ulong? TCLST_ID;

        // VARCHAR(64)
        public string PERS_LB_NOM;

        //VARCHAR(15)
        public string PERS_LB_PRENOM;

        //CHAR(1)
        public char? PERS_FG_SEXE;
        
        //DATE
        public DateTime? PERS_DT_NAISSANCE;
        
        //VARCHAR(8)
        public string LIC_NB_LICENCE;
        
        //CHAR(1)
        public char? LIC_FG_NATIONALITE;
        
        //CHAR(1)
        public char? LIC_FG;

        //CHAR(1)
        public char? LIC_FG_MODULE;

        //CHAR(1)
        public char? LIC_FG_CERTIFICAT;

        // DATE
        public DateTime? LIC_DT_CERTIFICAT;

        // DATE
        public DateTime? LIC_DT_VALIDATION;

        // INTEGER
        public int? LIC_NB_PLACE;

        // NUMERIC(7,3)
        public string LIC_NB_POINT;

        // CHAR(1)
        public char? LIC_FG_ECHELON;

        // VARCHAR(64)
        public string LIC_NB_POINT_CF_PREC;

        // VARCHAR(64)
        public string LIC_NB_POINT_TOTAL_CF;

        // VARCHAR(64)
        public string LIC_NB_TRI_POINT_CF;

        // NUMERIC(1,0)
        public char? LIC_BL_LOCAL;

        // NUMERIC(1,0)
        public char? LIC_BL_DOUBLE;

        // NUMERIC(7,3)
        public string LIC_NB_TOTAL_POINT_DOUBLE;

        // VARCHAR(64) 
        public string LIC_NB_POINT_TOUR_PREC_CF;

        // NUMERIC(15,0)
        public ulong? EPRV_ID;

        // NUMERIC(15,0)
        public ulong? DOUBLE_CLUB_ID;

        // NUMERIC(15,0)
        public ulong? DOUBLE_CLU_CLUB_ID;

    }
}
