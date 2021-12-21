using SPID2Deconnecte.Modeles;
using System;

namespace SPID2Deconnecte
{
    internal class JoueurCrud : Joueur
    {

        public JoueurCrud()
        {
            PRESENT = 0;
        }

        public void AddJoueur(long eprvId, long licId)
        {
            JOUE_ID = 0;
            EPRV_ID = eprvId;
            LIC_ID = licId;
            JOUE_NB_POINT_TOTAL = null;
            JOUE_BL_FORFAIT_GENE = 0;
            JOUE_LB_TRI_POINT = null;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("JOUEUR");
            }
        }


        public void FromTxt(string line)
        {
            int pos = 0;

            // TAB_ID"	NUMERIC(15, 0) NOT NULL,
            JOUE_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            EPRV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            LIC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            JOUE_NB_POINT_TOTAL = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;

            JOUE_BL_FORFAIT_GENE = Convert.ToInt64(line.Substring(pos, 8));
            pos += 8;

            JOUE_LB_TRI_POINT = SingletonOutils.StringParse(line.Substring(pos, 64));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("JOUEUR");
            }
        }

    }
}