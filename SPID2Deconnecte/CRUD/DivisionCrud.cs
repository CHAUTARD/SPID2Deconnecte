using SPID2Deconnecte.Modeles;
using System;
using System.Windows.Forms;

namespace SPID2Deconnecte
{
    class DivisionCrud : Division
    {
        public DivisionCrud()
        {
        }

        public void Delete()
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Delete("DIVISION");
            }
            MessageBox.Show("Division supprimmée !");
        }

        public long CountEpreuve (long idEpreuve)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // Recherche du joueur dans la table des licenciers
                return db.ExecuteScalar<long>("SELECT COUNT(*) FROM DIVISION WHERE EPRV_ID=@0", idEpreuve);
            }
        }

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10                  11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28         30        31        32       33        34        35        36        37        38        39        40        41  
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
             * 36295          16                            2302           R118DL08LocalR1 - 18 ans dames           4       FT04D                                                                                                                                                                                                                                                               9999    0       sportive.ligue@90             SEN  21/11/2021
             */
            int pos = 0;

            DIV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos = 15;
            ORGA_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;

            // ???
            pos += 15;

            EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            DIV_CD = line.Substring(pos, 5).Trim();
            pos += 5;
            DIV_LB = line.Substring(pos, 32).Trim();
            pos += 32;
            DIV_NB_POULE = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            DIV_FG_SEXE = line.Substring(pos, 1);
            pos++;
            DIV_FG_TYPE_LICENCE = line.Substring(pos, 1);
            pos++;
            DIV_BL_CORPO = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            DIV_NB_TOUR = Convert.ToInt16(line.Substring(pos, 1));
            pos++;
            DIV_CD_LETTRE = line.Substring(pos, 1)[0];
            pos++;
            DIV_CM = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            DIV_NB_POINT_MAX = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            DIV_NB_POINT_MIN = Convert.ToInt16(line.Substring(pos, 8));
            pos += 8;
            DIV_LB_USER_MODIF = line.Substring(pos, 15).Trim();
            pos += 15;
            BAR_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            GCAT_CD = SingletonOutils.StringParse(line.Substring(pos, 5));
            pos += 5;
            DIV_DT_TOUR = SingletonOutils.DateParse(line.Substring(pos, 10));

            /*
            string s = string.Format("INSERT INTO DIVISION (DIV_ID, ORGA_ID, EPRV_ID, DIV_CD, DIV_LB, DIV_NB_POULE, DIV_FG_SEXE, DIV_FG_TYPE_LICENCE, DIV_BL_CORPO, DIV_NB_TOUR, DIV_CD_LETTRE, DIV_CM, DIV_NB_POINT_MAX, DIV_NB_POINT_MIN, DIV_LB_USER_MODIF, BAR_ID, GCAT_CD, DIV_DT_TOUR) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');",
                DIV_ID, ORGA_ID, EPRV_ID, DIV_CD, DIV_LB, DIV_NB_POULE, DIV_FG_SEXE, DIV_FG_TYPE_LICENCE, DIV_BL_CORPO,
                DIV_NB_TOUR, DIV_CD_LETTRE, DIV_CM, DIV_NB_POINT_MAX, DIV_NB_POINT_MIN, DIV_LB_USER_MODIF, BAR_ID, GCAT_CD, DIV_DT_TOUR
            );
            */

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("DIVISION");
            }
        }
    }
}