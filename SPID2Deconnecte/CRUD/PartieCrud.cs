using SPID2Deconnecte.Modeles;
using System;
using System.Globalization;

namespace SPID2Deconnecte
{
    internal class PartieCrud : Partie
    {
        public PartieCrud()
        {
        }

        public void FromTxt(string line)
        {
            int pos = 0;

            PARTI_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            LIC_LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            RENC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            PARTI_NB_ORDRE = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;

            PARTI_BL_GAGNE1 = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            PARTI_BL_GAGNE2 = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            PARTI_BL_FORFAIT = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            PARTI_BL_SUPPRIMEE = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            PARTI_DT = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;

            PARTI_NM_TOUR = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;

            PARTI_BL_DOUBLE = Convert.ToInt32(line.Substring(pos, 1));
            pos++;

            TAB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));

            PARTI_NB_POINT1 = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));

            PARTI_NB_POINT2 = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));

            PARTI_BL_CLST = 0; //  Convert.ToInt32(line.Substring(pos, 1));

            PARTI_BL_NONJOUEE = 0; // Convert.ToInt32(line.Substring(pos, 1));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("PARTIE");
            }
        }

    }
}