﻿using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("LICENCIE")]
    [PrimaryKey("LIC_ID", AutoIncrement = false)]

    internal class Licencie
    {
        //         NUMERIC(15,0)
        public ulong  LIC_ID { get; set; }

        //  NUMERIC(15,0)
        public ulong?  CAT_ID { get; set; }

        // NUMERIC(15,0)
        public ulong? CLUB_ID { get; set; }

        //  NUMERIC(15,0)
        public ulong? CLU_CLUB_ID { get; set; }

        //  NUMERIC(15,0)
        public ulong? TCLST_ID { get; set; }

        // VARCHAR(64)
        public string PERS_LB_NOM { get; set; }

        //VARCHAR(15)
        public string PERS_LB_PRENOM { get; set; }

        //CHAR(1)
        public char? PERS_FG_SEXE { get; set; }
        
        //DATE
        public DateTime? PERS_DT_NAISSANCE { get; set; }
        
        //VARCHAR(8)
        public string LIC_NB_LICENCE { get; set; }
        
        //CHAR(1)
        public char? LIC_FG_NATIONALITE { get; set; }
        
        //CHAR(1)
        public char? LIC_FG { get; set; }

        //CHAR(1)
        public char? LIC_FG_MODULE { get; set; }

        //CHAR(1)
        public char? LIC_FG_CERTIFICAT { get; set; }

        // DATE
        public DateTime? LIC_DT_CERTIFICAT { get; set; }

        // DATE
        public DateTime? LIC_DT_VALIDATION { get; set; }

        // INTEGER
        public int? LIC_NB_PLACE { get; set; }

        // NUMERIC(7,3)
        public string LIC_NB_POINT { get; set; }

        // CHAR(1)
        public char? LIC_FG_ECHELON { get; set; }

        // VARCHAR(64)
        public string LIC_NB_POINT_CF_PREC { get; set; }

        // VARCHAR(64)
        public string LIC_NB_POINT_TOTAL_CF { get; set; }

        // VARCHAR(64)
        public string LIC_NB_TRI_POINT_CF { get; set; }

        // NUMERIC(1,0)
        public char? LIC_BL_LOCAL { get; set; }

        // NUMERIC(1,0)
        public char? LIC_BL_DOUBLE { get; set; }

        // NUMERIC(7,3)
        public string LIC_NB_TOTAL_POINT_DOUBLE { get; set; }

        // VARCHAR(64) 
        public string LIC_NB_POINT_TOUR_PREC_CF { get; set; }

        // NUMERIC(15,0)
        public ulong? EPRV_ID { get; set; }

        // NUMERIC(15,0)
        public ulong? DOUBLE_CLUB_ID { get; set; }

        // NUMERIC(15,0)
        public ulong? DOUBLE_CLU_CLUB_ID { get; set; }

    }
}
