
using System;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte
{
    internal class TourCrud : Tour
    {
        public TourCrud()
        {
        }

        public void FromTxt(string line)
        {
            int pos = 0;

            TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            DIV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            TOUR_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            TOUR_NB_GROUPE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TOUR_NB_POULE = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TOUR_NB_JOUEUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TOUR_NB_JOUEUR_DESC = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TOUR_NB_JOUEUR_MONT = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TOUR_DT = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            TOUR_LB_USER_MODIF = SingletonOutils.StringParse(line.Substring(pos, 15));
            pos += 15;
            TOUR_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            TOUR_DT_CREATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            GRIL_ID_RENC = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            TOUR_BL_CLOTURE = SingletonOutils.ShortParse(line.Substring(pos, 1));
            pos++;
            TOUR_NM = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            DIV_DIV_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            DIV2_DIV_LB = SingletonOutils.StringParse(line.Substring(pos, 32));

            /*
            string s = string.Format("INSERT INTO TOUR (TOUR_ID, DIV_ID, TOUR_LB, TOUR_NB_GROUPE, TOUR_NB_POULE, TOUR_NB_JOUEUR, TOUR_NB_JOUEUR_DESC, TOUR_NB_JOUEUR_MONT, TOUR_DT, TOUR_LB_USER_MODIF, TOUR_DT_MODIFICATION, TOUR_DT_CREATION, GRIL_ID_RENC, TOUR_BL_CLOTURE, TOUR_NM, DIV_DIV_LB, DIV2_DIV_LB) VALUES ({0}, {1}, '{2}');",
                TOUR_ID, DIV_ID, TOUR_LB, TOUR_NB_GROUPE, TOUR_NB_POULE, TOUR_NB_JOUEUR, TOUR_NB_JOUEUR_DESC, TOUR_NB_JOUEUR_MONT,
                TOUR_DT, TOUR_LB_USER_MODIF, TOUR_DT_MODIFICATION, TOUR_DT_CREATION, GRIL_ID_RENC, TOUR_BL_CLOTURE, TOUR_NM, DIV_DIV_LB, DIV2_DIV_LB
            );
            */
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("TOUR");
            }
        }

    }
}