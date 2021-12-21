using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("PACKAGE_TABLEAU")]
    [PrimaryKey("PKG_ID", AutoIncrement = false)]

    internal class PackageTableau
    {
        // "PKG_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong PKG_ID { get; set; }

        // "TAB_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong TAB_ID { get; set; }
    }
}
