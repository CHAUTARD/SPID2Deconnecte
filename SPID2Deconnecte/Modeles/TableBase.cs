using System;


namespace SPID2Deconnecte.Modeles
{
    public abstract class TableBase
    {
        protected TableBase()
        {
            BL_MAJ = true;
        }

        // NUMERIC(1,0) NUll
        public bool BL_MAJ; // 1
    }
}
