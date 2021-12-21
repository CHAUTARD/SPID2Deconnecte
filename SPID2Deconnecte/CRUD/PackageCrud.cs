/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte.CRUD
{
    internal class PackageCrud : Package
    {
        public PackageCrud()
        {
        }

        public void FromTxt(string line)
        {
            /*
            *           1         2         3         4         5         6         7         8         9         
            * 0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
            * 1923           patrick.chautarCriterium - Tour 2 - R1 - FeminiEpatrick.chautar17/11/202117/11/2021
            */
            int pos = 0;
            //string s;

            PKG_ID = Convert.ToUInt64(line.Substring(pos, 15));
            pos = 15;

            UTIL_LB_LOGIN = line.Substring(pos, 15).Trim();
            pos += 15;

            PKG_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;

            PKG_ETAT = line.Substring(pos, 1)[0];
            pos++;

            PKG_LB_USER_MODIF = SingletonOutils.StringParse(line.Substring(pos, 15));
            pos += 15;

            PKG_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;

            PKG_DT_CREATION = SingletonOutils.DateParse(line.Substring(pos, 10));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("PACKAGE");
                /*
                s = string.Format("INSERT INTO PACKAGE (PKG_ID, UTIL_LB_LOGIN, PKG_LB, PKG_ETAT, PKG_LB_USER_MODIF, PKG_DT_MODIFICATION, PKG_DT_CREATION) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                    PKG_ID,
                    UTIL_LB_LOGIN,
                    PKG_LB,
                    PKG_ETAT,
                    PKG_LB_USER_MODIF,
                    PKG_DT_MODIFICATION,
                    PKG_DT_CREATION
                );
                db.Execute(s);
                */
            }
        }
    }
}
