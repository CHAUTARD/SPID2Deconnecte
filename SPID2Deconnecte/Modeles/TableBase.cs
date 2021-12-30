using System;


namespace SPID2Deconnecte.Modeles
{
    public abstract class TableBase
    {
        // NUMERIC(1,0) NUll
        public bool BL_MAJ { get; set; }

        protected TableBase() { BL_MAJ = true; }
    }
}
