﻿using System;

namespace SPID2Deconnecte.Modeles
{
    internal class Bareme : TableBase
    {
        // VARCHAR(5)
        public string BAR_CD;

        // VARCHAR(32)
        public string BAR_LB;

        // VARCHAR(5), Null)
        public string BAR_LB_COURT;

        // NUMERIC(15,0)
        public ulong BAR_ID;

        // NUMERIC(15,0)
        public ulong ORGA_ID;

        // INTEGER, Null
        public int? BAR_NB_JOUEUR;
    }
}
