using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("JOUEUR")]
    [PrimaryKey("JOUE_ID", AutoIncrement = true)]

    internal class Joueur
    {
        // "JOUE_ID"	NUMERIC(15, 0) NOT NULL,
        public long JOUE_ID { get; set; }

        // "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public long EPRV_ID { get; set; }

        // "LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public long LIC_ID { get; set; }

        // "JOUE_NB_POINT_TOTAL"	VARCHAR(64),
        public string JOUE_NB_POINT_TOTAL { get; set; }

        // "JOUE_BL_FORFAIT_GENE"	NUMERIC(8, 0) NOT NULL,
        public long JOUE_BL_FORFAIT_GENE { get; set; }

        // "JOUE_LB_TRI_POINT"	VARCHAR(64),
        public string JOUE_LB_TRI_POINT { get; set; }

        public int PRESENT { get; set; }
    }
}
