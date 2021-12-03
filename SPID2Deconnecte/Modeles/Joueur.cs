using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("JOUEUR")]
    [PrimaryKey("JOUE_ID", AutoIncrement = false)]

    internal class Joueur
    {
        // "JOUE_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong JOUE_ID;

        // "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong EPRV_ID;

        // "LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong LIC_ID;

        // "JOUE_NB_POINT_TOTAL"	VARCHAR(64),
        public string JOUE_NB_POINT_TOTAL;

        // "JOUE_BL_FORFAIT_GENE"	NUMERIC(8, 0) NOT NULL,
        public ulong JOUE_BL_FORFAIT_GENE;

        // "JOUE_LB_TRI_POINT"	VARCHAR(64),
        public string JOUE_LB_TRI_POINT;

        public void FromString()
        {
        }
    }
}
