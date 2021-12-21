using SPID2Deconnecte.Modeles;
using System;
using System.Globalization;

namespace SPID2Deconnecte
{
    internal class NiveauCrud : Niveau
    {
        public NiveauCrud()
        {
        }


        public void FromTxt(string line)
        {
            int pos = 0;

            NIV_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            TAB_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            NIVREF_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos += 15;

            NIV_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;

            NIV_LB_LIEU = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;

            NIV_CM = SingletonOutils.StringParse(line.Substring(pos, 5));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("NIVEAU");
            }
        }
    }
}