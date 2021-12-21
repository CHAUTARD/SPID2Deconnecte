using SPID2Deconnecte.Modeles;
using System;

namespace SPID2Deconnecte
{
    internal class ClassementCrud : Classement
    {

        public ClassementCrud()
        {
        }

        public void FromTxt(string line)
        {
            int pos = 0;

            CLST_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            POUL_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            CLST_NB_RANG = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_POINTS = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_VICTOIRE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_DEFAITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_EGALITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_FORFAITS = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_PENALITE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_GAGNE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            CLST_NB_PERDUES = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;

            EQUIP_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            LIC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            TAB_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            CLST_CD_LETTRE = line.Substring(pos, 1)[0];
            pos++;

            NIV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;

            CLST_RANG_FORFAIT = line.Substring(pos, 2);

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("CLASSEMENT");
            }
        }

    }
}