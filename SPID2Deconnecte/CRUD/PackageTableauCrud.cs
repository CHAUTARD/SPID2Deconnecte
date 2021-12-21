using SPID2Deconnecte.Modeles;
using System;

namespace SPID2Deconnecte
{
    internal class PackageTableauCrud : PackageTableau
    {
        public PackageTableauCrud()
        {
        }

        public void FromTxt(string line)
        {
            PKG_ID = Convert.ToUInt64(line.Substring( 0, 15));
            TAB_ID = Convert.ToUInt64(line.Substring(15, 15));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("PACKAGE_TABLEAU");
            }
        }
    }
}