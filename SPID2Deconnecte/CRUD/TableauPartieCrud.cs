using SPID2Deconnecte.Modeles;
using System;
using System.Globalization;

namespace SPID2Deconnecte
{
    internal class TableauPartieCrud : TableauPartie
    {
        public TableauPartieCrud()
        {
            // Pas initialisé lors de l'import
            TABPART_NB_TABLE = "";
            RPARTI_ID_PARTIE_REF = null;
            TABPART_TYPE_PARTIE = null;
            TABPART_NM_PERDANT = null;
            TABPART_LB_PARTIE = "";
            TABPART_BL_CLST = null;
        }

        public void FromTxt(string line)
        {
            int pos = 0;

            TABPART_ID_TABLEAU = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            POUL_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            NIV_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            INSC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            INS_INSC_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            PARTI_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            TABPART_NM_ORDRE_NIVEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TABPART_NM_TABLEAU = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TABPART_NM_VAINQUEUR = SingletonOutils.ShortParse(line.Substring(pos, 8));
            pos += 8;
            TABPART_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            // pos += 10;
            // TABPART_NBLocalTABLE = SingletonOutils.StringParse(line.Substring(pos, 5));
            // pos += 5;
            // RPARTI_ID_PARTIE_REF = SingletonOutils.LongParse(line.Substring(pos, 15));
            // pos += 15;
            // TABPARTLocalTYPE_PARTIE = Convert.ToInt32(line.Substring(pos, 1));
            // pos++;
            // TABPART_NM_PERDANT = null; //  SingletonOutils.ShortParse(line.Substring(pos, 8));
            // pos += 8;
            // TABPART_LB_PARTIE = ""; //  SingletonOutils.StringParse(line.Substring(pos, 10));
            // pos += 10;
            // TABPART_BL_CLST = null; // Convert.ToInt32(line.Substring(pos, 1));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("TABLEAU_PARTIE");
            }
        }

    }
}