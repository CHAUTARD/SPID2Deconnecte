using System;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte
{
    internal class EpreuveCrud : Epreuve
    {
        public EpreuveCrud()
        {
        }

        public long GetIdMax()
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // Recherche du joueur dans la table des licenciers
                return db.ExecuteScalar<long>("SELECT MAX(EPRV_ID) from EPREUVE");
            }
        }

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10                  11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28         30        31        32         
             * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456
             * 2302           1              I FED_CFED_Criterium Federal           C                                                                                                                                                                                                                                                               system_admin   
             */
            int pos = 0;

            EPRV_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos = 15;

            ORGA_ID = Convert.ToInt64(line.Substring(pos, 15).Trim());
            pos += 15;

            // EPR_EPRV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            //
            // pos += 15;

            EPRV_CD = line.Substring(pos, 2).Trim();
            pos += 2;

            EPRV_LB_COURT = line.Substring(pos, 5).Trim();
            pos += 5;

            EPRV_LB = line.Substring(pos, 32).Trim();
            pos += 32;

            EPRV_FG = line.Substring(pos, 10).Trim();
            pos++;

            EPRV_CM = line.Substring(pos, 255).Trim();
            pos += 255;

            EPRV_LB_USER_MODIF = line.Substring(pos, 15).Trim();

            /*
            string s = string.Format("INSERT INTO EPREUVE (EPRV_ID, ORGA_ID, EPRV_CD, EPRV_LB_COURT, EPRV_LB, EPRV_FG, EPRV_CM, EPRV_LB_USER_MODIF) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                EPRV_ID,
                ORGA_ID,
                EPRV_CD,
                EPRV_LB_COURT,
                EPRV_LB,
                EPRV_FG,
                EPRV_CM,
                EPRV_LB_USER_MODIF
            );
            */
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("EPREUVE");
            }
        }

        internal void Read(long id)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.SingleOrDefault<EpreuveCrud>("WHERE EPRV_ID=@0", id);
            }
        }

        internal void Insert()
        {
            // Création de l'objet petapoco
            Epreuve epreuve = new Epreuve();

            // Epreuve locale
            epreuve.EPRV_ID = 0;
            epreuve.ORGA_ID = -101; // ???
            epreuve.EPR_EPRV_ID = 9; // ???
            epreuve.EPRV_FG = "I"; // ???
            epreuve.EPRV_LB_USER_MODIF = "SPID2D";

            epreuve.EPRV_CD = EPRV_CD;
            epreuve.EPRV_LB_COURT = EPRV_LB_COURT;
            epreuve.EPRV_LB = EPRV_LB;
            epreuve.EPRV_CM = EPRV_CM;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert(epreuve);
            }
        }

        internal void Update()
        {
            // Création de l'objet petapoco
            Epreuve epreuve = new Epreuve();

            epreuve.EPRV_LB_USER_MODIF = "SPID2D";

            epreuve.EPRV_ID = EPRV_ID;
            epreuve.ORGA_ID = ORGA_ID;
            epreuve.EPR_EPRV_ID = EPR_EPRV_ID;
            epreuve.EPRV_CD = EPRV_CD;
            epreuve.EPRV_LB_COURT = EPRV_LB_COURT;
            epreuve.EPRV_LB = EPRV_LB;
            epreuve.EPRV_FG = EPRV_FG;
            epreuve.EPRV_CM = EPRV_CM;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Update(epreuve);
            }
        }

        internal void Delete(Epreuve epreuve)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Delete("EPREUVE", "EPRV_ID", epreuve);
            }
        }
    }
}