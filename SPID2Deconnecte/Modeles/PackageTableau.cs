using System;

namespace SPID2Deconnecte.Modeles
{
    internal class PackageTableau
    {
        // "PKG_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong PKG_ID { get; set; }

        // "TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TAB_ID { get; set; }
    }
}
