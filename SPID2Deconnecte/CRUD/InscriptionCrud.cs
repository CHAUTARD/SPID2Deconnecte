using SPID2Deconnecte.Modeles;
using System;
using System.Windows;

namespace SPID2Deconnecte
{
    internal class InscriptionCrud : Inscription
    {
        public InscriptionCrud()
        {
        }

        internal int CountInscitr(long dIV_ID)
        {
            throw new NotImplementedException();
        }

        internal void Delete()
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Delete("DIVISION");
            }
            MessageBox.Show("Division supprimmée !");
        }

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10        11        12        13        14    
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345
             * 65241          114564         39879          0       1               0147134                        1       0       D39997          985110         9141941 
             */
            int pos = 0;

            INSC_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            JOUE_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            INSC_NB_DOSSARD = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;
            INSC_NB_RANG_POULE = Convert.ToInt32(line.Substring(pos, 8));
            pos += 8;
            INSC_NB_POINT_TOUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            INSC_BL_ABSENT = Convert.ToInt32(line.Substring(pos, 1));
            pos++;
            POUL_ID = SingletonOutils.LongSParse(line.Substring(pos, 15));
            pos += 15;
            TOUR_ID_PREC = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            INSC_NB_RANG_TOUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            INSC_NM_RANG_TABLEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            INSC_CD_LETTRE = line.Substring(pos, 1);
            // pos++;

            TAB_ID = 0; //  SingletonOutils.LongParse(line.Substring(pos, 15));
            // pos += 15;
            INSC_BL_TETE_SERIE = 0; //  Convert.ToInt32(line.Substring(pos, 1));
            // pos++;
            INSC_NM_CLASSEMENT = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            INSC_TIRAGE_POS_TAB = 0; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            INSC_BL_TIRAGE_TETE_SERIE = 0; //  Convert.ToInt32(line.Substring(pos, 1));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("INSCRIPTION");
            }
        }
    }
}