using SPID2Deconnecte.Modeles;
using System;

namespace SPID2Deconnecte
{
    internal class CategorieEpreuveCrud : CategorieEpreuve
    {

        public CategorieEpreuveCrud()
        {
        }

        public void FromTxt(string line)
        {
            DIV_ID = Convert.ToUInt64(line.Substring(0, 15));
            CAT_ID = Convert.ToUInt64(line.Substring(15, 15));
            CAT_EPR_BL_PRINCIPAL = Convert.ToInt16(line.Substring(30, 1));

            /*
            string s = string.Format("INSERT INTO CATEGORIELocalEPREUVE (DIVLocalID, CATLocalID, CATLocalEPRLocalBLLocalPRINCIPAL) VALUES ({0}, {1}, {2});",
                DIVLocalID, CATLocalID, CATLocalEPRLocalBLLocalPRINCIPAL
            );
            */

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("CATEGORIE_EPREUVE");
            }
        }
    }
}